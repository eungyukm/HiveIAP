using NetProtocol.Models.etc;

namespace NetProtocol.Packet.G2C
{
    public class AttendanceRewardV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public uint EventIndex = 0;
        public uint Day = 0;
        public RewardData Reward = new();       // 보상 받은 정보

    }
}