using NetProtocol.Packet;

namespace NetProtocol.Models.Actor.Features
{
    public class DActorBuff
    {
        public long ActorId;
       
        public long BuffId;

        // 추후 다른 패킷으로 분리될 가능성 존재
        public long BarrierValue;
        // 추후 다른 패킷으로 분리될 가능성 존재
        public long BarrierStack;
        
        public ActorStateEffect Effect;
        
        public int SkillLinkDataId;
        public long ExpiredAt;
    }
}