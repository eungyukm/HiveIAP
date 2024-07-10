using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet
{
    public class BindStonePacketMeta : IPacketMeta
    {
        public int StartId => 3000;

        public Type[] Types => new[]
        {
            typeof(DesignateBindStoneReq),
            typeof(PortalByBindStoneReq),
            typeof(DesignateBindStoneRes),
            typeof(PortalByBindStoneRes)
        };
    }
}