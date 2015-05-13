using System;
using System.Collections;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Windows.Forms;

namespace Remoting
{
    public partial class PeerRegistration : Form
    {

        public string UserSelectedFilePath { get; set; }

        public PeerRegistration()
        {
            InitializeComponent();
        }


        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string pictureFolder = Environment.CurrentDirectory;
            ofd.InitialDirectory = pictureFolder;
            ofd.Filter = @"Config. Files|*.config;";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                UserSelectedFilePath = ofd.FileName;
                xml.Text = UserSelectedFilePath;
            }

        }

        private void register_Click(object sender, EventArgs e)
        {
            ServerRegist(Int32.Parse(PortValue.Text));
            Hide();
            var form = new PeerRegistration();
            form.Show();
        }

        private void ServerRegist(int port)
        {
            SoapServerFormatterSinkProvider serverProv = new SoapServerFormatterSinkProvider();
            serverProv.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            SoapClientFormatterSinkProvider clientProv = new SoapClientFormatterSinkProvider();
            IDictionary props = new Hashtable();
            props["port"] = port;
            HttpChannel ch = new HttpChannel(props, clientProv, serverProv);
            ChannelServices.RegisterChannel(ch, false);
            RemotingConfiguration.RegisterWellKnownServiceType(
                 typeof(Peer), "RemotePeer.soap", WellKnownObjectMode.Singleton);
            Peer peer = (Peer)Activator.GetObject(
                typeof(Peer),
                "http://localhost:" + port + "/RemotePeer.soap");
            Console.Write(peer.MusicLibrary[0]);
        }
    }
}
