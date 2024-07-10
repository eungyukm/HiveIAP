using System;

namespace NetProtocol.Packet.G2C
{
    public class SkillUseV2Res
    {
        public ErrorCode Status;
        public long TargetActorId;
    }

    public class RTTSkillUseV2Res
    {
        public ErrorCode Status;
        public long TargetActorId;
        public DateTime UtcSendTime;
    }
}
