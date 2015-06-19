using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameManager.TP3;

namespace GameManager
{
    public partial class Manager : Form
    {
        private IGameManager game;
        public Manager()
        {
            InitializeComponent();
        }

        private void startgameButton_Click(object sender, EventArgs e)
        {
            game = new GameManagerClient();
            game.StartGame(Int32.Parse(xValue.Text), Int32.Parse(yValue.Text));
        }
    }
}
