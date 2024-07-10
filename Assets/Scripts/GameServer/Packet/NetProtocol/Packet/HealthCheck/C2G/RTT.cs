using System;

namespace NetProtocol.Packet.C2G
{
    public class C2SRttReq
    {
        public DateTime UtcSendTime;
    }

    public class C2SRttRes
    {
        public DateTime UtcSendTime;
        public DateTime UtcRecvTime;
    }
}
