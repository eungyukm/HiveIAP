using System.Collections.Generic;
using NetProtocol.Models.Guild;

namespace NetProtocol.Packet.G2C
{
    public class GuildFindRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public List<GuildIntro> Guilds = new();
    }
}