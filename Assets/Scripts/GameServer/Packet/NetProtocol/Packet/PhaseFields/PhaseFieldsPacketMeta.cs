using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.PhaseFields
{
    public class PhaseFieldsPacketMeta : IPacketMeta
    {
        public int StartId => 20000;

        public Type[] Types => new[]
        {
            typeof(PhaseFieldEndV2Req),
            typeof(PhaseFieldStartV2Req),
            typeof(PhaseFieldEndV2Res),
            typeof(PhaseFieldStartV2Res),
        };
    }
}