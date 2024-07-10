using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class EventExchangeRewardV2Res
    {
        public ErrorCode Err;
        public uint EventIndex;
        public uint Priority;
        public ItemV2[] RewardItems;

    }
}