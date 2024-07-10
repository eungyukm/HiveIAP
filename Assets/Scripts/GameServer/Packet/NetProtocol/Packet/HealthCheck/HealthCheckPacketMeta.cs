using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.HealthCheck
{
    public class HealthCheckPacketMeta : IPacketMeta
    {
        public int StartId => 50000;

        public Type[] Types => new[]
        {
            typeof(C2SRttReq),
            typeof(S2CRttRes),

            typeof(S2CRttReq),
            typeof(C2SRttRes),
        };
    }
}
