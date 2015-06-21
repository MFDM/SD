using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;
using GamePlayer.ServiceReference1;

// ReSharper disable once CheckNamespace
namespace GamePlayer
{
    public partial class Player : Form
    {
        private SynchronizationContext _synchronizationContext;
        private IGamePlayer game;
        private int lifes;
        private string language;
        private string advertisment;
        private Dictionary<string, string> _lngShorts;
        private string targetLng;

        public Player()
        {
            InitializeComponent();
            _synchronizationContext = WindowsFormsSynchronizationContext.Current;
            SetLifes(3);
            Receiver rec = new Receiver(this,_synchronizationContext); // cria um objecto para receber callbacks
            game = new GamePlayerClient(new InstanceContext(rec));
            game.JoinGame();
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
            lastPlaysTB.Text = lastPlaysTB.Text + String.Format("({0},{1})\n", xvalue, yvalue);

            String res = game.MakeMove(xvalue, yvalue);

            resultTB.Text = "";

            if(res.Equals("Death"))
                SetLifes(--lifes);
            else if(res.Equals("Life"))
                SetLifes(++lifes);

            resultTB.Text = res;
        }

        private void SetLanguage_Click(object sender, EventArgs e)
        {
            targetLng = lngComboBox.Text.Substring(lngComboBox.Text.LastIndexOf(' ')+1);
        }

        public void SetAdvertisement(string adv)
        {
            if (targetLng != null)
                advTextBox.Text = game.TranslateAdv(targetLng); ;
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
