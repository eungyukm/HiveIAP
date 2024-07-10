using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Models.Guild;

namespace NetProtocol.Packet.G2C
{
    public class GuildMemberInfoRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public List<GuildMember> Members = new();
    }
}