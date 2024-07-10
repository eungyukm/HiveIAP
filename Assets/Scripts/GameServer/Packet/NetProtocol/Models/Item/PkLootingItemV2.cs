using System.Collections.Generic;

namespace NetProtocol.Models.Item
{
    public class PkLootingItemV2
    {
        public long Id = 0;
        public long PlayerId = 0;
        public string PlayerName = string.Empty;
        public uint PlayerIndex = 0;
        public ushort PlayerLv = 0;
        public uint MapIndex = 0;
        public long GainEndTime = 0;
        public List<ItemV2> Items = new();
    }
}