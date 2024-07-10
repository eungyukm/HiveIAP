using NetProtocol.Models.Item;
using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class ItemUpdateV2Noti
    {
        public List<ItemV2> Items = new();
        public Trace From = Trace.None;          // 어느 컨텐츠에서 사용 했는지 정보
    }
}