using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Remoting
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Testing for 
            PeerOptions po = new PeerOptions();
            XmlLoader xl = new XmlLoader(Environment.CurrentDirectory + "\\appConf.xml");
            xl.XmlSave(po);

            po = xl.XmlLoad();
            Console.WriteLine("Port Number: " + po.port + "\nPort Name:" + po.portname + "\nMusic Collection");
            po.musics.ForEach((m) => Console.WriteLine(m.Title));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PeerRegistration());
        }
    }
}
