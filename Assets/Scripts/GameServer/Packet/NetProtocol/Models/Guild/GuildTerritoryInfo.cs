using NetProtocol.Models.Actor.Features;

namespace NetProtocol.Models.Guild
{
    public class GuildTerritoryInfo
    {
        public DGuild GuildInfo = new DGuild();

        public TerritoryInfo Territory = new TerritoryInfo();
    }
}