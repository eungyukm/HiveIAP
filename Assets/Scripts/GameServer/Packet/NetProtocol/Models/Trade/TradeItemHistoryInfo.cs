using System;

namespace NetProtocol.Models.Trade
{
    public class TradeItemHistoryInfo
    {
        public long TradeId = 0;
        public DateTime TradeAt = DateTime.MinValue;     // 거래가 일어난 일시
        public long SellerId = 0;
        public long BuyerId = 0;
        public long Price = 0;
        public long Tax = 0;
        public TradeItem Item = new();
    }
}
