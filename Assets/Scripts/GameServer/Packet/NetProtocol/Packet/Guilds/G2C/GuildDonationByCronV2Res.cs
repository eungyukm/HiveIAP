using System;
using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class GuildDonationByCronV2Res
    {
        public ErrorCode Result = ErrorCode.Success;
        
        public Dictionary<long, int> RewardItemCounts = new(); // 보상
        public ItemV2[] RewardItems = Array.Empty<ItemV2>(); // 보상
        public Dictionary<long, int> UseItemCounts = new(); // 보상
        public ItemV2[] UseItems = Array.Empty<ItemV2>(); // 보상
    }
}