using NetProtocol.Models.Trade;
using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class TradeItemSearchListNoti
    {
        public bool IsEnd = false;      // 리스트 끝인지 여부
        public List<TradeItemInfo> TradeItemInfos = new();
    }
}
