using System.Collections.Generic;
using NetProtocol.Models.Actor.Features;
using NetProtocol.Packet;

namespace NetProtocol.Models.Actor
{
    public class DMonsterActor : DActor
    {
        public int Level;
        
        public DHp Hp;
        public DMp Mp;

        public ActorState State;

        // 버프 정보
        public List<DActorBuff> Buffs = new();

        // 보스몬스터 전용. 현재 타겟의 ActorId를 보내준다.
        public long TargetActorId;

        public DActorSyncStat SyncStat;
    }
}