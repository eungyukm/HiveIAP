using System;
using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class GuildUpdateCurrencyV2Noti
    {
        public ItemV2[] CurrencyItems = Array.Empty<ItemV2>();
        public Dictionary<long, int> UseCurrencyItemCounts = new();
    }
}