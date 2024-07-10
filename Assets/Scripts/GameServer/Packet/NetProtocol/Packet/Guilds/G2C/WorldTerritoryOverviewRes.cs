using System.Collections.Generic;
using NetProtocol.Models.Guild;

namespace NetProtocol.Packet.G2C
{
    public class WorldTerritoryOverviewRes
    {
        public ErrorCode Status = ErrorCode.Success;

        public Dictionary<uint, GuildTerritoryInfo> Infos = new Dictionary<uint, GuildTerritoryInfo>();
    }
}