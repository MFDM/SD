using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Remoting
{
    public partial class SearchMusic : Form
    {
        public SearchMusic(Peer po)
        {
            PO = po;
            InitializeComponent();
        }

        private Peer PO { get; set; }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Title_Click(object sender, EventArgs e)
        {
        }

        private void Serach_Click(object sender, EventArgs e)
        {
            Dictionary<Music, string> res = PO.GetMusicByTitle(Title.Text);
           
        }

        private void Album_Click(object sender, EventArgs e)
        {

        }
    }
}