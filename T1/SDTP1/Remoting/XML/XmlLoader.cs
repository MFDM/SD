using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Remoting
{
    public class XmlLoader
    {
        private readonly string _path;
        private readonly XmlSerializer _serializer;

        public XmlLoader(string path)
        {
            if(path == null) 
                throw new ArgumentNullException();
            _path = path;
            _serializer = new XmlSerializer(typeof(PeerInfo));
        }

        public PeerInfo XmlLoad()
        {   
            StreamReader _streamR = new StreamReader(_path);
            PeerInfo po = new PeerInfo();
            po = (PeerInfo) _serializer.Deserialize(_streamR);
            _streamR.Close();
            return po;
        }

        public void XmlSave(PeerInfo po)
        {   
            StreamWriter _streamW = new StreamWriter(_path);
            StringWriter sww = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sww);
            _serializer.Serialize(writer, po);
            _streamW.WriteLine(sww.ToString());
            _streamW.Close();
            
        }
    }
}
