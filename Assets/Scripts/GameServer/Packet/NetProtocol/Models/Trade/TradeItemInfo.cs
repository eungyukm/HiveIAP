
using NetProtocol.Packet;
using System;

namespace NetProtocol.Models.Trade
{
    public class TradeItemInfo     // 아이템 거래소 거래 정보
    {
        public long TradeId = 0;
        public long SellerId = 0;
        public long BuyerId = 0;
        public TradeItemState State = 0;       // 거래 상태
        public long Price = 0;
        public long Tax = 0;
        public int MainCategory = 0;        // ITEM_MID_TYPE
        public int SubCategory = 0;         // ITEM_SUB_TYPE
        public TradeItem Item = new();
        public DateTime ResistedAt = DateTime.MinValue; // State == Trade 이면 등록한 일시, State == Accept 이면 거래가 일어난 일시
        public DateTime ExpireTime = DateTime.MinValue;


        public TradeItemHistoryInfo ToTradeItemHistoryInfo()
        {
            return new TradeItemHistoryInfo()
            {
                TradeId = TradeId,
                SellerId = SellerId,
                BuyerId = BuyerId,
                Price = Price,
                Tax = Tax,
                Item = Item,
                TradeAt = ResistedAt,
            };
        }
    }
}
