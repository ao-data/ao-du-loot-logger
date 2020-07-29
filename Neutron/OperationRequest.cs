using System;
using System.Collections.Generic;
using System.Text;

namespace Neutron
{
    public class OperationRequest
    {
        public byte OperationCode;
        public Dictionary<byte, object> Parameters;
    }
}
