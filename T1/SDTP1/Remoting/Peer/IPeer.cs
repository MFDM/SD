using System;
using System.Collections.Generic;
using System.Threading;

namespace Remoting
{
   public interface IPeer
   {
       string Url { get; set; }
       //PeerInfo PeerInfo { get; set; }
       SearchMusic myform { get; set; }

       List<Music> musics { get; set; }

       List<String> peersLinks { get; set; }

       void AddMusic(Music m);

       void AddPeerUrl(String url);

       String getPeerFriendUrl(int idx);

       int getNumPeerFriends();

       Music GetMusicByTitle(string title, string whosLooking);

       Music getMusicByArtist(string search, string whosLooking);
       Music GetMusicByAlbum(string search, string whosLooking);
   }
}
