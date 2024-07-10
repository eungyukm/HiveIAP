using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet
{
    public class AccountPacketMeta : IPacketMeta
    {
        public int StartId => 40000;

        public Type[] Types => new[]
        {
            typeof(AccountCreateNameReq),
            typeof(AccountCreateNameRes),
        };

    }
}