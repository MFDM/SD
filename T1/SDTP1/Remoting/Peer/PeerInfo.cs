using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Remoting
{
    public class PeerInfo
    {
        public string name;
        public int port;
        public string portname;
        public List<Music> musics;
        public List<PeerFriend> friends;

        public PeerInfo(){}

        
    }

    public class PeerFriend
    {
        public String Url { get; set; }
        public String Xml { get; set; }

        public PeerFriend() { }

        public PeerFriend(String url, String xml)
        {
            this.Url = url;
        }
    }
}
