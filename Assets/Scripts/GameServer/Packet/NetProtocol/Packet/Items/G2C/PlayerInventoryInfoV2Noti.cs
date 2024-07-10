using NetProtocol.Models.Item;
using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class PlayerInventoryInfoV2Noti
    {
        public bool isEnd = false;                  // 전송 완료 여부
        public List<ItemV2> Items = new();          // 100개(임시)로 쪼개서 전송
    }
}
