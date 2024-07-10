using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class AttainmentDailyRewardV2Res
    {
        public ErrorCode Err;
        public uint EventIndex;
        public uint Day;
        public uint AchieveConditionIndex;

    }
}