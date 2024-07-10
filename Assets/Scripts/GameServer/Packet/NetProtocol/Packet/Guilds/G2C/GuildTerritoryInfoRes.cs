using System.Collections.Generic;
using NetProtocol.Models.Guild;

namespace NetProtocol.Packet.G2C
{
    public class GuildTerritoryInfoRes
    {
        public ErrorCode Status = ErrorCode.Success;

        public bool HasTerritory = false;

        public List<TerritoryInfo> Infos = new List<TerritoryInfo>();
    }
}