
using NetProtocol.Packet;
using System;

namespace NetProtocol.Models.Trade
{
    public class TradePersonalInfo
    {
        public long TradeId = 0;
        public long SellerId = 0;
        public string SellerName = string.Empty;
        public long BuyerId = 0;
        public string BuyerName = string.Empty;
        public TradePersonalState State = 0;       // 거래 상태
        public long Price = 0;
        public long Tax = 0;
        public TradeItem Item = new();
        public DateTime ResistedAt = DateTime.MinValue;     // State == Request 이면 신청한 일시, State == Accept 이면 거래가 일어난 일시
        public DateTime ExpireTime = DateTime.MinValue;


        public TradePersonalHistoryInfo ToTradePersonalHistoryInfo()
        {
            return new TradePersonalHistoryInfo()
            {
                TradeId = TradeId,
                SellerId = SellerId,
                SellerName= SellerName,
                BuyerId = BuyerId,
                BuyerName = BuyerName,
                Price = Price,
                Tax = Tax,
                Item = Item,
                TradeAt = ResistedAt,
            };
        }

    }
}
