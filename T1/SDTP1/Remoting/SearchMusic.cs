using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Remoting
{
    public partial class SearchMusic : Form
    {
        private const string NoSearchTextString = "No title, album or artist were introduced for search.";
        private const string InvalidTextString = "Text insert had no music matched.";

        private Peer PO { get; set; }

        public SearchMusic(Peer po)
        {
            PO = po;
            InitializeComponent();
            peerinfo.Text = PO.name +": " +PO.Url;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Music m = null;
            bool invalidText = false;

            if (Title.Text != "")
            {
                m = PO.SearchMusicByTitle(Title.Text);
                invalidText = m == null;
            }
            else if (Album.Text != "")
            {
                m = PO.GetMusicByAlbum(Album.Text);
                invalidText = m == null;
            }
            else if (Artist.Text != "")
            {
                m = PO.GetMusicByArtist(Artist.Text);
                invalidText = m == null;
            }

            if (m != null)
                MusicInfo.Rows.Add("peearx", m.Artist, m.Title, m.Year, m.Album);
            else
                NoSearchText.Text = invalidText ? InvalidTextString : NoSearchTextString;

        }

        private Dictionary<string, string> CheckFields()
        {
            Dictionary<string, string> musicProps = new Dictionary<string, string>();

            if (Title.Text != "")
                musicProps.Add("Title", Title.Text);
            if (Album.Text != "")
                musicProps.Add("Album", Album.Text);
            if (Artist.Text != "")
                musicProps.Add("Artist", Artist.Text);
            
            return musicProps;
        }
    }
}