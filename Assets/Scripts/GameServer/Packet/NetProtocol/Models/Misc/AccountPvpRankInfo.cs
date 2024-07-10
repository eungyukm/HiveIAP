using NetProtocol.Models.Actor.Features;

namespace NetProtocol.Packet
{
    public class AccountPvpRankInfo
    {
        public int Rank = 0;
        public long AccountId = 0;
        public string Name = string.Empty;
        
        public int PvpPoint = 0;
        public int AssistPoint = 0;
        public int KillPoint = 0;
        public int DeathPoint = 0;

        public DGuild GuildInfo = new DGuild();
    }
}