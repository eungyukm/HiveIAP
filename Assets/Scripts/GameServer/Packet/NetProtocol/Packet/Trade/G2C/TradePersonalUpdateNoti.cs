using NetProtocol.Models.Trade;

namespace NetProtocol.Packet.G2C
{
    public class TradePersonalUpdateNoti
    {
        public TradePersonalInfo Trade = new();     // 거래 상태값 갱신
    }
}
