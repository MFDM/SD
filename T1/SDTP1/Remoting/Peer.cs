using System;
using System.Collections.Generic;

namespace Remoting
{
    public class Peer : MarshalByRefObject
    {
        private string Xmlfile { get; set; }
        public List<Music> MusicLibrary { get; set; }

        public Peer()
        {
            LoadLibrary();
        }

        private void LoadLibrary()
        {
            MusicLibrary = new List<Music>();
            MusicLibrary.Add(new Music("First", "Artist1", "Album1", 2000, "CD"));
            MusicLibrary.Add(new Music("Secons", "Artist2", "Album2", 2001, "MP3"));
        }
    }
}
