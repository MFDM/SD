using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Remoting
{
    public partial class SearchMusic : Form
    {

        private Peer PO { get; set; }

        public SearchMusic(Peer po)
        {
            PO = po;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Title_Click(object sender, EventArgs e)
        {
        }

        private void Serach_Click(object sender, EventArgs e)
        {
            Music m = PO.GetMusicByTitle(Title.Text);
            Refs.Text = m.Title;
            
        }

        private void Album_Click(object sender, EventArgs e)
        {

        }
    }
}