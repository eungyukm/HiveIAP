using System;

namespace NetProtocol.Models.Trade
{
    public class TradePersonalHistoryInfo
    {
        public long TradeId = 0;
        public DateTime TradeAt = DateTime.MinValue;     // 거래가 일어난 일시
        public long SellerId = 0;
        public string SellerName = string.Empty;
        public long BuyerId = 0;
        public string BuyerName = string.Empty;
        public long Price = 0;
        public long Tax = 0;
        public TradeItem Item = new();
    }
}
