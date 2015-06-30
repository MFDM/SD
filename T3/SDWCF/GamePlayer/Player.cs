using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;
using Player.ServiceReference1;

namespace GamePlayer
{
    public partial class Player : Form
    {
        private SynchronizationContext _synchronizationContext;
        private IGamePlayer game;
        private int lifes;

        public Player()
        {
            InitializeComponent();
            _synchronizationContext = WindowsFormsSynchronizationContext.Current;
        }


        private void SetLifes(int i)
        {
            lifes = i;
            if (lifes == 0)
                ExitGame("GAME OVER");

            liveslb.Text = lifes.ToString();
        }

        public void ExitGame(String winnerOrLoser)
        {
            game.ExitGame();
            playButton.Visible = false;
            WOL.Text = winnerOrLoser;

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int xvalue = Int32.Parse(xValue.Text);
            int yvalue = Int32.Parse(yValue.Text);

            try
            {
                string res = game.MakeMove(xvalue, yvalue);
                WOL.Text = "";
                lastPlaysTB.Text = lastPlaysTB.Text + String.Format("({0},{1})\n", xvalue, yvalue);
                resultTB.Text = "";

                if (res.Equals("Death"))
                    SetLifes(--lifes);
                else if (res.Equals("Life"))
                    SetLifes(++lifes);

                resultTB.Text = res;
            }
            catch (FaultException<GameNotStartedException> exception)
            {
                WOL.Text = exception.Message + " ";
            }
        }

        private void SetLanguage_Click(object sender, EventArgs e)
        {
            String n = textBox1.Text, l = lngComboBox.Text;
            if (n == "" || l == "") return;
            SetLifes(3);
            Receiver rec = new Receiver(this, _synchronizationContext); // cria um objecto para receber callbacks
            game = new GamePlayerClient(new InstanceContext(rec));
            game.JoinGame(n, l.Substring(lngComboBox.Text.LastIndexOf(' ') + 1));
            RegistButton.Enabled = false;
            playButton.Enabled = true;
        }

        public void SetAdvertisement(string adv)
        {
            advTextBox.Text = adv; ;
        }

        private void Player_Load(object sender, EventArgs e)
        {

        }

        private void WOL_Click(object sender, EventArgs e)
        {

        }
        
    }

    [CallbackBehavior(UseSynchronizationContext = false)]
    public class Receiver : IGamePlayerCallback
    {
        private SynchronizationContext _synchronizationContext;
        private Player player;
        public Receiver(Player player, SynchronizationContext sc)
        {
            this._synchronizationContext = sc;
            this.player = player;
        }
        
        public string NewAnnounce(String msg, int ex)
        {
            _synchronizationContext.Post(o =>
            {
               player.ExitGame(msg);

            }, null);

            return "";
        }

        public string NewAdvertisement(string msg, int ex)
        {
            _synchronizationContext.Post((o =>
            {
               player.SetAdvertisement(msg);
            }), null);
            return null;
        }

    }
}
