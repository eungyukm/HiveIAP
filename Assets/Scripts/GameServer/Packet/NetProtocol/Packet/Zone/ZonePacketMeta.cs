using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Zone
{
    public class ZonePacketMeta : IPacketMeta
    {
        public int StartId => 41000;

        public Type[] Types => new[]
        {
            typeof(ZoneStatusReq),
            typeof(ZoneStatusRes),
            typeof(ZoneStatusNoti),
        };
    }
}