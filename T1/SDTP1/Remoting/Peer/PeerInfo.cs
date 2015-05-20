using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Remoting
{
    public class PeerInfo
    {
        public string name;
        public int port;
        public string portname;
        public List<Music> musics;

        [XmlArrayItem(ElementName = "Url")]
        public List<String> friends;

        public PeerInfo(){}

        
    }
}
