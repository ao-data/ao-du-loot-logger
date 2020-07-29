using System;
using System.Collections.Generic;
using System.Text;

namespace Neutron
{
    public class EventData
    {
        public byte Code;
        public Dictionary<byte, object> Paramaters;
        // This has an indexer in it too but I'm not going to use it quite yet
    }
}
