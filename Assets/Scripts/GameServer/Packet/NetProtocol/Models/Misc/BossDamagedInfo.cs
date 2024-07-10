using NetProtocol.Models.Actor.Features;

namespace NetProtocol.Packet
{
    public class BossDamagedInfo
    {
        public long ActorId = 0;
        public string Name = string.Empty;
        public int Level = 0;
        
        public DActorProperty Property = new DActorProperty();
        
        public DGuild GuildInfo = new DGuild();

        public long Damage = 0;
    }
}