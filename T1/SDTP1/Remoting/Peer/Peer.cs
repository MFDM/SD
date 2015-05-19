using System;
using System.Collections.Generic;

namespace Remoting
{
    public class Peer : MarshalByRefObject, IPeer
    {
        public PeerOptions peerOptions { get; set; }
        public IPeer ipeer;

        public Peer(PeerOptions po)
        {
            this.peerOptions = po;
        }

        public string Url { get; set; }

    }
}
