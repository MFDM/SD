using System;
using System.Collections.Generic;
using System.Linq;

namespace Remoting
{
    public class PeerOptions
    {

        public string name;
        public int port;
        public string portname;
        public List<Music> musics;


        public PeerOptions()
        {
        }

        public IEnumerable<Music> GetMusicByTitle(String title)
        {
            return musics.Where(m => m.Title == title);
        }
    }
}
