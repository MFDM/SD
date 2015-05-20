using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Remoting
{
    public class Peer : MarshalByRefObject, IPeer
    {

        public List<Music> musics { get; set; }
        public List<String> peersLinks { get; set; }
        public string Url { get; set; }

        private List<Task<Music>> tasks = new List<Task<Music>>();

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
            peersLinks.Add(m);
        }


        public Music GetMusicByTitle(String title)
        {
            CancellationTokenSource cts = new CancellationTokenSource();

            if (musics.Exists((m) => m.Title.Equals(title)))
            {
                Music x = musics.Where(m => m.Title == title).First();
                return x;
            }


            AskFriendsForMusic(this, title, cts);


            Task.WaitAll(tasks.ToArray(), cts.Token);

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
        public void AskFriendsForMusic(IPeer p, string title, CancellationTokenSource cts)
        {
            foreach (String url in p.peersLinks)
            {
                if (!cts.IsCancellationRequested)
                {
                    Task<Music> t1 = Task.Factory.StartNew(() =>
                    {
                        try
                        {
                            IPeer peer = ((IPeer)Activator.GetObject(typeof(IPeer), url));
                            Music music = peer.GetMusicByTitle(title);

                            if (music != null) return music;

                            Task.Factory.StartNew(() =>
                           {
                               AskFriendsForMusic(peer, title, cts);
                           });
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
}

