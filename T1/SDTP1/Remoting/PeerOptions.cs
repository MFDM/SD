using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Remoting
{
    public class PeerOptions
    {

        public int port;
        public string portname;
        public List<Music> musics;


        public PeerOptions()
        {
            port = 1111;
            portname = "nameport";
            musics = new List<Music>();
            musics.Add(new Music("First", "Artist1", "Album1", 2000, "CD"));
            musics.Add(new Music("Secons", "Artist2", "Album2", 2001, "MP3"));
        }
    }
}
