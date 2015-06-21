using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameManager.ServiceReference1;

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
            game.SetAdv(advTextBox.Text);
            game.StartGame(Int32.Parse(xValue.Text), Int32.Parse(yValue.Text));
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

    }
}
