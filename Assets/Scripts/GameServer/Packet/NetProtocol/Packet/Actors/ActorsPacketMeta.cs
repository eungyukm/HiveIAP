using NetProtocol.Packet.G2C;
using System;

namespace NetProtocol.Packet
{
    public class ActorsPacketMeta : IPacketMeta
    {
        public int StartId => 2000;

        public Type[] Types => new[]
        {
            typeof(ActorAddBuffV2Noti),
            typeof(ActorChangedLevelToMeV2Noti),
            typeof(ActorChangedLevelV2Noti),
            typeof(ActorChangeStateV2Noti),
            typeof(ActorCostumeNoti),
            typeof(ActorDeathV2Noti),
            typeof(ActorDisAppearV2Noti),
            typeof(ActorGuildV2Noti),
            typeof(ActorHpMpUpdateV2Noti),
            typeof(ActorHpUpdateV2Noti),
            typeof(ActorMoveV2Noti),
            typeof(ActorMpUpdateV2Noti),
            typeof(ActorPetV2Noti),
            typeof(ActorRemoveBuffV2Noti),
            typeof(ActorRideV2Noti),
            typeof(ActorsDisAppearV2Noti),
            typeof(MonsterActorAppearV2Noti),
            typeof(MonsterActorsAppearV2Noti),
            typeof(MonsterActorTargetNoti),
            typeof(PlayerActorAppearV2Noti),
            typeof(PlayerActorsAppearV2Noti),

            typeof(PlayerActorZoneStateNoti),
            typeof(ActorStatSyncNoti),
            typeof(PropActorAppearNoti),

            typeof(ActorPendingDisAppearNoti),
            
            typeof(PropActorsAppearNoti),
        };
    }
}