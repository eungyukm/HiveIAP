using System;

namespace NetProtocol.Packet.G2C
{
    public class SkillHitV2Res
    {
        public ErrorCode Status;
        public long TargetActorId;
    }

    public class RTTSkillHitV2Res
    {
        public ErrorCode Status;
        public long TargetActorId;
        public DateTime UtcSendTime;
    }
}