using NetProtocol.Models.Actor.Features;

namespace NetProtocol.Packet.G2C
{
    public class ActorStatSyncNoti
    {
        public long ActorId;
        public DActorSyncStat SyncStat;
    }
}
