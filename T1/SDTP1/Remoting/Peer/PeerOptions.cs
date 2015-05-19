using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

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
    }
}
