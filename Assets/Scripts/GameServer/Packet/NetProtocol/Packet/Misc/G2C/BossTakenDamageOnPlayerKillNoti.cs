using NetProtocol.Models.Actor.Features;

namespace NetProtocol.Packet.G2C
{
    public class BossTakenDamageOnPlayerKillNoti
    {
        public uint MonsterDataId = 0;
        public uint ZoneDataId = 0;

        public long TargetActorId = 0;
        public DGuild TargetActorGuild = new DGuild();

        public long TakenDamage = 0;
    }
}