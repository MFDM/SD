using System;
using System.Collections.Generic;

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

       String getPeerFriendUrl(int idx);

       int getNumPeerFriends();

       Music GetMusicByTitle(String title);

       Music getMusicByArtist(string search);
   }
}
