using System;

namespace NetProtocol.Packet.C2G
{
    public class SkillUseV2Req
    {
        public int SkillSerial;
        public long TargetActorId;
    }

    public class RTTSkillUseV2Req
    {
        public int SkillSerial;
        public long TargetActorId;
        public DateTime UtcSendTime;
    }
}
