using NetProtocol.Models.Guild;

namespace NetProtocol.Packet
{
    public class WorldBossDamagedInfo
    {
        public GuildInfo Guild = new GuildInfo();
        public long Damage = 0;
    }
}