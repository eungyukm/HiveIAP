using System.Collections.Generic;
using NetProtocol.Models.Guild;

namespace NetProtocol.Packet.G2C
{
    public class GuildHistoryRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public List<GuildHistory> HistoryList = new();
    }
}