using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Remoting
{
    public partial class SearchMusic : Form
    {
        public SearchMusic(PeerOptions po)
        {
            PO = po;
            InitializeComponent();
        }

        private PeerOptions PO { get; set; }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Title_Click(object sender, EventArgs e)
        {
        }

        private void Serach_Click(object sender, EventArgs e)
        {
            IEnumerable<Music> res = PO.GetMusicByTitle(Title.Text);
            foreach (Music m in res)
            {
                Refs.Text = m.Title;
            }
        }

        private void Album_Click(object sender, EventArgs e)
        {

        }
    }
}