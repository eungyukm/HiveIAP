using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class PkLootingV2Noti
    {
        public List<PkLootingItemV2> Items = new();
    }
}