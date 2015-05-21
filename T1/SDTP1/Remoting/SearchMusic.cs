﻿using System;
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
            MusicInfo.Rows.Clear();
            NoSearchText.Text = "";

            int deep = 0;
            if (DeepBox.Text != "")
                deep = Int16.Parse(DeepBox.Text);
            
            Music m = null;
            bool invalidText = false;

            if (Title.Text != "")
            {
                m = PO.SearchMusicByTitle(Title.Text,deep);
                invalidText = m == null;
            }
            else if (Album.Text != "")
            {
                m = PO.GetMusicByAlbum(Album.Text);
                invalidText = m == null;
            }
            else if (Artist.Text != "")
            {
                m = PO.SearchMusicByArtist(Artist.Text,deep);
                invalidText = m == null;
            }

            if (m != null)
                MusicInfo.Rows.Add(m.Owner, m.Artist, m.Title, m.Year, m.Album,m.Format);
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

        private void addMusicButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in MusicInfo.SelectedRows)
            {
                if (!row.Cells["Peer"].Value.ToString().Equals(PO.Url))
                {
                    PO.AddMusic(new Music(row.Cells["MTitle"].Value.ToString(), row.Cells["MArtist"].Value.ToString(),
                        row.Cells["MAlbum"].Value.ToString(), int.Parse(row.Cells["MYear"].Value.ToString()),
                        row.Cells["MTitle"].Value.ToString(),PO.Url));

                    PO.AddPeerUrl(row.Cells["Peer"].Value.ToString());
                }
            }
        }
    }
}