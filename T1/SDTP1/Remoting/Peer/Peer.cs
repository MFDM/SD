using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Remoting
{
    public class Peer : MarshalByRefObject, IPeer
    {
        public String Name { get; set; }
        public SearchMusic myform { get; set; }
        public List<Music> musics { get; set; }
        public List<String> peersLinks { get; set; }
        public string Url { get; set; }
        public delegate bool SearchBy(String s, Music m);
        public SearchBy ByTitle = (title, m) => m.Title.Equals(title);
        public SearchBy ByAlbum = (album, m) => m.Album.Equals(album);
        public SearchBy ByArtist = (artist, m) => m.Artist.Equals(artist);
        private List<Task<Music>> _tasks;
        private List<String> _peersSerched;

      
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

        public Music GetMusic(string by, string whosLooking, SearchBy func)
        {
            myform.UpdateTextBox(whosLooking);
            Music music = null;
            if (musics.Exists(m => func(by, m)))
            {
                music = musics.First(m => func(by, m));
            }
            return music;
        }

        public Music SearchMusic(string search, int depth, SearchBy func)
        {
            _tasks = new List<Task<Music>>();
            _peersSerched = new List<String>();
            CancellationTokenSource cts = new CancellationTokenSource();

            if (musics.Exists(m => func(search, m)))
            {
                Music x = musics.First(m => func(search, m));
                return x;
            }

            _peersSerched.Add(Url);

            AskFriendsForMusic(this, func, search, cts, depth);

            Task.WaitAll(_tasks.ToArray());

            foreach (Task<Music> t in _tasks)
            {
                if (t.Result != null)
                {
                    return t.Result;
                }
            }
            return null;

        }

        public void AskFriendsForMusic(IPeer p, SearchBy del, string search, CancellationTokenSource cts,int depth)
        {
            if (depth == 0)
                return;
            
            for( int i =0; i < p.getNumPeerFriends(); ++i)
            {
                String url = p.getPeerFriendUrl(i);

                if (!_peersSerched.Contains(url))
                {
                    _peersSerched.Add(url);
                    if (!cts.IsCancellationRequested)
                    {
                        Task<Music> t1 = Task.Factory.StartNew(() =>
                        {
                            try
                            {
                                if (!cts.IsCancellationRequested)
                                {
                                    IPeer peer = ((IPeer) Activator.GetObject(typeof (IPeer), url));
                                    Music music = peer.GetMusic(search, Url, del);
                                    if (music != null)
                                    {
                                        cts.Cancel();
                                        return music;
                                    }

                                    if (!cts.IsCancellationRequested)
                                        AskFriendsForMusic(peer, del, search, cts,--depth);
                                }
                                return null;
                            }
                            catch (WebException)
                            {
                                return null;
                            }
                            catch (OperationCanceledException)
                            {
                                return null;
                            }

                        }, cts.Token);
                        _tasks.Add(t1);
                    }
                }
            }
        }
    }
}

