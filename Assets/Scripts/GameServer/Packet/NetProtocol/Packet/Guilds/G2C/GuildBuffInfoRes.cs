using NetProtocol.Packet;
using NetProtocol.Models.Guild;
using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class GuildBuffInfoRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public List<GuildBuff> GuildBuffs = new();
    }
}