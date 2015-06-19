using System;
using System.Windows.Forms;
using Player.Service_References.TP3;

namespace Player
{
    public partial class Player : Form
    {
        private IGamePlayer game;
        public Player()
        {
            InitializeComponent();
            game =new GamePlayerClient();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            String res = game.SetPlay(Int32.Parse(xValue.Text), Int32.Parse(yValue.Text));
            prizeLabel.Text = res;
        }
    }
}
