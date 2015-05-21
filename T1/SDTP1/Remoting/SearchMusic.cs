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
        private Peer P { get; set; }

        public SearchMusic(Peer p)
        {
            P = p;
            InitializeComponent();
            _uiContext = SynchronizationContext.Current;
            peerinfo.Text = P.Name + @": " +P.Url;
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
                m = P.SearchMusic(Title.Text, depth, P.ByTitle);
                invalidText = m == null;
            }
            else if (Album.Text != "")
            {
                m = P.SearchMusic(Album.Text, depth,P.ByAlbum );
                invalidText = m == null;
            }
            else if (Artist.Text != "")
            {
                m = P.SearchMusic(Artist.Text, depth, P.ByArtist);
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
                if (!row.Cells["Peer"].Value.ToString().Equals(P.Url))
                {
                    P.AddMusic(new Music(row.Cells["MTitle"].Value.ToString(), row.Cells["MArtist"].Value.ToString(),
                        row.Cells["MAlbum"].Value.ToString(), int.Parse(row.Cells["MYear"].Value.ToString()),
                        row.Cells["MTitle"].Value.ToString(),P.Url));

                    P.AddPeerUrl(row.Cells["Peer"].Value.ToString());
                }
            }
        }

        public void UpdateTextBox(string text)
        {
            _uiContext.Send((o) => connect.AppendText("Peer " + text + " searched you. \r\n"), null);
        }  
    }
}