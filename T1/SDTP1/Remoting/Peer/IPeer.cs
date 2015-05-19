using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Remoting
{
   public interface IPeer
   {
       string Url { get; set; }
       List<PeerFriend> GetPeerFriends();
       List<Music> GetPeerMusics();
       IPeer getInstance();

    }
}
