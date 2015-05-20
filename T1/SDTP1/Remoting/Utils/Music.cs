using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Remoting
{
    [Serializable]
    public class Music
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Year { get; set; }
        public string Format { get; set; }

        public Music() { }

        public Music(string title, string artist, string album, int year, string format)
        {
            this.Title = title;
            this.Artist = artist;
            this.Album = album;
            this.Year = year;
            this.Format = format;
        }
    }
}
