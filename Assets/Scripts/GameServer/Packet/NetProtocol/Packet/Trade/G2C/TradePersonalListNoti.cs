using NetProtocol.Models.Trade;
using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class TradePersonalListNoti
    {
        public List<TradePersonalInfo> SellTrades = new();      // 판매 거래 리스트
        public List<TradePersonalInfo> BuyTrades = new();       // 구매 거래 리스트
    }
}
