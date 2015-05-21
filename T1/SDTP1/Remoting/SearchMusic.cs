using System;
using System.Threading;
using System.Windows.Forms;

namespace Remoting
{
    public partial class SearchMusic : Form
    {
        private const string NoSearchTextString = "No title, album or artist were introduced for search.";
        private const string InvalidTextString = "Text insert had no music matched.";
        private SynchronizationContext _uiContext;
        private Peer PO { get; set; }

        public SearchMusic(Peer po)
        {
            PO = po;
            InitializeComponent();
            _uiContext = SynchronizationContext.Current;
            peerinfo.Text = PO.Name +": " +PO.Url;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            MusicInfo.Rows.Clear();
            NoSearchText.Text = "";

            int depth = 0;
            if (DeepBox.Text != "")
                depth = Int16.Parse(DeepBox.Text);
            
            Music m = null;
            bool invalidText = false;

            if (Title.Text != "")
            {
                m = PO.SearchMusic(Title.Text, depth, PO.ByTitle);
                invalidText = m == null;
            }
            else if (Album.Text != "")
            {
                m = PO.SearchMusic(Album.Text, depth,PO.ByAlbum );
                invalidText = m == null;
            }
            else if (Artist.Text != "")
            {
                m = PO.SearchMusic(Artist.Text, depth, PO.ByArtist);
                invalidText = m == null;
            }

            if (m != null)
                MusicInfo.Rows.Add(m.Owner, m.Artist, m.Title, m.Year, m.Album,m.Format);
            else
                NoSearchText.Text = invalidText ? InvalidTextString : NoSearchTextString;

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

        public void UpdateTextBox(string text)
        {
            _uiContext.Send((o) => connect.AppendText("Peer " + text + " searched you. \r\n"), null);
        }  
    }
}