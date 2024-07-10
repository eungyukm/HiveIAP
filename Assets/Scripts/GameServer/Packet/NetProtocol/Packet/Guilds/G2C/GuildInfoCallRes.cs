using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Models.Guild;

namespace NetProtocol.Packet.G2C
{
    public class GuildInfoCallRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public List<GuildView> GuildViews = new();
    }
}