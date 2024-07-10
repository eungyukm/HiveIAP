using NetProtocol.Models.Trade;
using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class TradeItemSellListNoti
    {
        public List<TradeItemInfo> SellTrades = new();      // 판매 거래 리스트
    }
}
