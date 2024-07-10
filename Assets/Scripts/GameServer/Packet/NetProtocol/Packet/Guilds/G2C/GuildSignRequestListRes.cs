using System.Collections.Generic;
using NetProtocol.Models.Guild;

namespace NetProtocol.Packet.G2C
{
    public class GuildSignRequestListRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public List<GuildSign> Guilds = new();
    }
}