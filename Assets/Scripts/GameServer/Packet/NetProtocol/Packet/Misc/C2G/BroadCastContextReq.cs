using System.Collections.Generic;

namespace NetProtocol.Packet.C2G
{
    public class BroadCastContextReq
    {
        public bool IncludeMe = true;
        public List<byte> Contexts = new List<byte>();
    }
}