using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Effect
{
    public class EffectPacketMeta : IPacketMeta
    {
        public int StartId => 9000;

        public Type[] Types => new[]
        {
            typeof(PortalEffectReq),
            typeof(PortalEffectNoti),
            typeof(PortalEffectRes)
        };
    }
}