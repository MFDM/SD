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
       //PeerInfo PeerInfo { get; set; }
       List<Music> musics { get; set; }
       List<String> peersLinks { get; set; }
       void AddMusic(Music m);
       void AddPeerUrl(String url);
       Music GetMusicByTitle(String title);
    }
}
