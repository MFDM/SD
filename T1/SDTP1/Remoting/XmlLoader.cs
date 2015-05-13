using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Remoting
{
    public class XmlLoader
    {
        private readonly StreamReader _streamR;
        private readonly StreamWriter _streamW;
        private readonly XmlSerializer _serializer;

        public XmlLoader(string path, StreamReader streamR)
        {
            if(path == null) 
                throw new ArgumentNullException();
            _streamR = new StreamReader(path);
            _streamW = new StreamWriter(path);
            _serializer = new XmlSerializer(typeof(PeerOptions));
        }

        public PeerOptions XmlLoad()
        {
            PeerOptions po = new PeerOptions();
            po = (PeerOptions) _serializer.Deserialize(_streamR);
            return po;
        }

        public void XmlSave(PeerOptions po)
        {
            StringWriter sww = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sww);
            _serializer.Serialize(writer, po);
            _streamW.WriteLine(sww.ToString());
            _streamW.Close();
            
        }
    }
}
