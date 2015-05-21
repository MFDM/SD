using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remoting
{
    public class Peer : MarshalByRefObject, IPeer
    {
        public String name { get; set; }
        public List<Music> musics { get; set; }
        public List<String> peersLinks { get; set; }
        public string Url { get; set; }

      
        public Peer()
        {
            musics = new List<Music>();
            peersLinks = new List<String>();
        }

        public void AddMusic(Music m)
        {
            musics.Add(m);
        }

        public void AddPeerUrl(String m)
        {
            if(!peersLinks.Contains(m))
                peersLinks.Add(m);
        }

        public string getPeerFriendUrl(int idx)
        {
            return peersLinks.ElementAt(idx);
        }

        public int getNumPeerFriends()
        {
            return peersLinks.Count;
        }

        public Music GetMusicByTitle(string title)
        {
            Music music = null;
            if (musics.Exists((m) => m.Title.Equals(title)))
            {
                music= musics.Where((m) => m.Title.Equals(title)).First();
            }

            return music;
        }

        public Music getMusicByArtist(string artist)
        {
            Music music = null;
            if (musics.Exists((m) => m.Artist.Equals(artist)))
            {
                music = musics.Where((m) => m.Artist.Equals(artist)).First();
            }

            return music;
        }

        private List<Task<Music>> tasks;
        private List<String> peersSerched;

        public Music SearchMusicByTitle(string title, int deep)
        {
            tasks = new List<Task<Music>>();
            peersSerched = new List<String>();
            CancellationTokenSource cts = new CancellationTokenSource();

            if (musics.Exists((m) => m.Title.Equals(title)))
            {
                Music x = musics.Where(m => m.Title == title).First();
                return x;
            }
            peersSerched.Add(this.Url);

            AskFriendsForMusic(this,"title",title, cts, deep);
            
            Task.WaitAll(tasks.ToArray());

            foreach (Task<Music> t in tasks)
            {
                if (t.Result != null)
                {
                  return  t.Result;
                }
            }
            return null;
        }

        // ReSharper disable once UnusedParameter.Local
        public void AskFriendsForMusic(IPeer p,string mode, string search, CancellationTokenSource cts,int deep)
        {
            if (deep == 0)
                return;
            
            for( int i =0; i < p.getNumPeerFriends(); ++i)
            {
                String url = p.getPeerFriendUrl(i);

                if (!peersSerched.Contains(url))
                {
                    peersSerched.Add(url);
                    if (!cts.IsCancellationRequested)
                    {
                        Task<Music> t1 = Task.Factory.StartNew(() =>
                        {
                            try
                            {
                                if (!cts.IsCancellationRequested)
                                {
                                    IPeer peer = ((IPeer) Activator.GetObject(typeof (IPeer), url));
                                    Music music = null;
                                    if(mode.Equals("title"))
                                      music = peer.GetMusicByTitle(search);
                                    else if(mode.Equals("artist"))
                                      music = peer.getMusicByArtist(search);

                                    if (music != null)
                                    {
                                        cts.Cancel();
                                        return music;
                                    }

                                    if (!cts.IsCancellationRequested)
                                        AskFriendsForMusic(peer, mode,search, cts,--deep);
                                }
                                return null;
                            }
                            catch (WebException we)
                            {
                                return null;
                            }
                            catch (OperationCanceledException ce)
                            {
                                return null;
                            }

                        }, cts.Token);
                        tasks.Add(t1);
                    }
                }
            }
        }

        public Music SearchMusicByArtist(string artist, int deep)
        {
            tasks = new List<Task<Music>>();
            peersSerched = new List<String>();
            CancellationTokenSource cts = new CancellationTokenSource();

            if (musics.Exists((m) => m.Artist.Equals(artist)))
            {
                Music x = musics.Where(m => m.Artist == artist).First();
                return x;
            }
            peersSerched.Add(this.Url);

            AskFriendsForMusic(this,"artist" ,artist, cts, deep);

            Task.WaitAll(tasks.ToArray());

            foreach (Task<Music> t in tasks)
            {
                if (t.Result != null)
                {
                    return t.Result;
                }
            }
            return null;
        }

        public Music GetMusicByAlbum(string text)
        {
            throw new NotImplementedException();
        }
    }
}

