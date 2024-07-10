using System.Collections.Generic;

namespace NetProtocol.Packet.C2G
{
    public class ItemCombineV2Req
    {
        public long ItemId = 0;
        public List<long> ResourceItemIds = new();
        public long CombineItemId = 0;
        public long PercentItemId = 0;
    }
}