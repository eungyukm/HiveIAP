using System;

namespace NetProtocol.Packet.C2G
{
    public class SkillHitV2Req
    {
        public int SkillSerial;
        public int HitId;
        public long TargetActorId;
    }

    public class RTTSkillHitV2Req
    {
        public int SkillSerial;
        public int HitId;
        public long TargetActorId;
        public DateTime UtcSendTime;
    }
}