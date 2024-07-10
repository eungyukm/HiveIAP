using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.InteractProp
{
    public class InteractPropPacketMeta : IPacketMeta
    {
        public int StartId => 13000;

        public Type[] Types => new[]
        {
            typeof(InteractStartReq),
            typeof(InteractStartRes),

            typeof(InteractEndReq),
            typeof(InteractEndRes),
            
            typeof(InteractCancelReq),
            typeof(InteractCancelRes),
            
            typeof(InteractNoti),
        };
    }
}