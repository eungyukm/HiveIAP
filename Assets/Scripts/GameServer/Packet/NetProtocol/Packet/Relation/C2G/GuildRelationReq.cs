using System;

namespace NetProtocol.Packet.C2G
{
    public class GuildRelationReq
    {
        public string GuildName = string.Empty;
        public RelationInfo Info = new RelationInfo();
    }
}