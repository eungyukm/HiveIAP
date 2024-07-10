using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Relation
{
    public class RelationPacketMeta : IPacketMeta
    {
        public int StartId => 23000;

        public Type[] Types => new[]
        {
            typeof(GuildRelationReq),
            typeof(PlayerRelationReq),
            typeof(GuildRelationRes),
            typeof(PlayerRelationRes),
            typeof(RelationsNoti),
        };
    }
}