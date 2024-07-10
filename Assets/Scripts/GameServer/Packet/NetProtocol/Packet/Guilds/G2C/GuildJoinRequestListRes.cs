using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Models.Guild;

namespace NetProtocol.Packet.G2C
{
    public class GuildJoinRequestListRes
    {
        public ErrorCode Result;
        public List<GuildJoin> Players = new();
    }
}
