using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Remoting
{
    public class Music
    {
        string Title { get; set; }
        string Artist { get; set; }
        string Album { get; set; }
        int Year { get; set; }
        string Format { get; set; }

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
