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
        public PeerInfo peerOtp;
        public Peer peer;
        public PeerRegistration()
        {
            InitializeComponent();
            peerOtp = new PeerInfo();
        }


        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string pictureFolder = Environment.CurrentDirectory;
            ofd.InitialDirectory = pictureFolder;
            ofd.Filter = @"XML Files|*.xml";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                UserSelectedFilePath = ofd.FileName;
                xml.Text = UserSelectedFilePath;
                XmlLoader xl = new XmlLoader(xml.Text);
                peerOtp = xl.XmlLoad();
            }

        }

        private void register_Click(object sender, EventArgs e)
        {
            ServerRegist(peerOtp.port);
            Hide();
            var form = new SearchMusic(peer);
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
                typeof (Peer), "RemotePeer.soap", WellKnownObjectMode.Singleton);
            
            String url = "http://localhost:" + peerOtp.port +"/RemotePeer.soap";
            Console.WriteLine(url);
            peer = ((Peer) Activator.GetObject(typeof (Peer), url));
            foreach(Music m in peerOtp.musics)
                peer.AddMusic(m);
            foreach (String p in peerOtp.friends)
                peer.AddPeerUrl(p);
        }
    }
}
