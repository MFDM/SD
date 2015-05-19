using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Remoting
{
    public class Peer : MarshalByRefObject, IPeer
    {
        public PeerInfo PeerInfo { get; set; }
        public IPeer ipeer;
        private List<Task<Dictionary<Music, String>>> tasks = new List<Task<Dictionary<Music, String>>>();

        public Peer(PeerInfo po)
        {
            this.PeerInfo = po;
        }

        public string Url { get; set;}

        public List<PeerFriend> GetPeerFriends()
        {
            return PeerInfo.friends;
        }

        public List<Music> GetPeerMusics()
        {
            return PeerInfo.musics;
        }

        public IPeer getInstance()
        {
            return this;
        }


        public Dictionary<Music, String> GetMusicByTitle(String title)
        {
            Dictionary<Music, String> musicsFind = new Dictionary<Music, string>();
            CancellationTokenSource cts = new CancellationTokenSource();

            if (PeerInfo.musics.Exists((m) => m.Title.Equals(title)))
            {
                musicsFind.Add(PeerInfo.musics.Where(m => m.Title == title).First(), Url);
                return musicsFind;
            }

          
              AskFriendsForMusic(this, title, cts);   
           

            Task.WaitAll(tasks.ToArray(), cts.Token);

            foreach (Task<Dictionary<Music,String>> t in tasks)
            {
                if (t.Result != null)
                {
                    return  t.Result;
                }
            }
            return null;
        }

        // ReSharper disable once UnusedParameter.Local
        public void AskFriendsForMusic(IPeer p, string _title, CancellationTokenSource cts)
        {
                foreach (PeerFriend f in p.PeerInfo.friends)
                {
                    if (!cts.IsCancellationRequested)
                    {
                        Task<Dictionary<Music, String>> t1 = Task.Factory.StartNew(() =>
                        {
                            try
                            {
                                Dictionary<Music, String> music = new Dictionary<Music, string>();

                                PeerInfo testpi = new PeerInfo();
                                XmlLoader xl = new XmlLoader(f.Xml);
                                testpi = xl.XmlLoad();
                                Peer peer = new Peer(testpi);
                                peer.ipeer =((IPeer) Activator.GetObject(typeof (IPeer), f.Url));

                                if (peer.GetPeerMusics().Exists((m) => m.Title.Equals(_title)))
                                {
                                    music.Add(peer.GetPeerMusics().Where(m => m.Title == _title).First(), f.Url);
                                    //cts.Cancel();
                                    return music;
                                }
                                    
                                
                                 Task.Factory.StartNew(() =>
                                {
                                    AskFriendsForMusic(this, _title, cts);   
                                });
                                return null;

                            }catch (OperationCanceledException ce)
                            {
                                return null;
                            }
                            
                        }, cts.Token);

                        tasks.Add(t1);
                    }
                }
            }
        }
    }

