using System;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;
using Player.ServiceReference1;

namespace Player
{
    public partial class Player : Form
    {
        private SynchronizationContext _synchronizationContext;
        private IGamePlayer game;
        private int lives;

        public Player()
        {
            InitializeComponent();
            _synchronizationContext = WindowsFormsSynchronizationContext.Current;
            setLives(3);
            Receiver rec = new Receiver(this,_synchronizationContext); // cria um objecto para receber callbacks
            game = new GamePlayerClient(new InstanceContext(rec));
            game.JoinGame();
        }

        private void setLives(int i)
        {
            lives = i;
            if (lives == 0)
                exitGame("GAME OVER");

            liveslb.Text = lives.ToString();
        }

        public void exitGame(String winnerOrLoser)
        {
            game.ExitGame();
            playButton.Visible = false;
            WOL.Text = winnerOrLoser;

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int xvalue = Int32.Parse(xValue.Text);
            int yvalue = Int32.Parse(yValue.Text);
            lastPlaysTB.Text = lastPlaysTB.Text + String.Format("\n({0},{1})", xvalue, yvalue);

            String res = game.MakeMove(xvalue, yvalue);

            resultTB.Text = "";

            if(res.Equals("Death"))
                setLives(--lives);
            else if(res.Equals("Life"))
                setLives(++lives);

            resultTB.Text = res;
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
               player.exitGame(msg);

            }, null);

            return "";
        }

    }
}
