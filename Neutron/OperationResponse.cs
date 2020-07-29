using System;
using System.Collections.Generic;
using System.Text;

namespace Neutron
{
    public class OperationResponse
    {
        public string DebugMessage;
        public byte OperationCode;
        public Dictionary<byte, object> Paramaters;
        public short ReturnCode;

        // this has an indexer on it also
    }
}
