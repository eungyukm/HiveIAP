using NetProtocol.Packet;

namespace NetProtocol.Models.Trade
{
    public class TradeCronTradeInfo
    {
        public long TradeId = 0;
        public long Amount = 0;
        public long Price = 0;
        public long SettledPrice = 0;
        public PacketTradeCronType State = 0;
        public long At = 0;
    }
}