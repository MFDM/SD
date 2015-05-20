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

        private PeerInfo _peerInfo;
        private Peer _peer;
        private OpenFileDialog _ofd;
        private const string NoPathPresent = "Please insert or browse the xml file path.";

        public PeerRegistration()
        {
            InitializeComponent();
            _peerInfo = new PeerInfo();
        }


        private void browse_Click(object sender, EventArgs e)
        {
            _ofd = new OpenFileDialog();
            _ofd.InitialDirectory = Environment.CurrentDirectory;
            _ofd.Filter = @"XML Files|*.xml";
            DialogResult dr = _ofd.ShowDialog();
            if (dr == DialogResult.OK)
                xml.Text = _ofd.FileName;

        }

        private void register_Click(object sender, EventArgs e)
        {
            if (xml.Text != "")
            {
                XmlLoader xl = new XmlLoader(xml.Text);
                _peerInfo = xl.XmlLoad();
                ServerRegist(_peerInfo.port);
                Hide();
                var form = new SearchMusic(_peer);
                form.Show();

            }
            else
                NoPath.Text = NoPathPresent;

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
            
            String url = "http://localhost:" + _peerInfo.port +"/RemotePeer.soap";
            Console.WriteLine(url);
            _peer = ((Peer) Activator.GetObject(typeof (Peer), url));
            foreach(Music m in _peerInfo.musics)
                _peer.AddMusic(m);
            foreach (String p in _peerInfo.friends)
                _peer.AddPeerUrl(p);
        }
    }
}
