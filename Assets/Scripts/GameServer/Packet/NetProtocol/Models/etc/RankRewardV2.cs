using System.Collections.Generic;

namespace NetProtocol.Models.Item
{
    public class RankRewardV2
    {
        public uint Rank = 0;
        public List<ItemV2> Items = new();
    }
}