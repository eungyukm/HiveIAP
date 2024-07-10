using NetProtocol.Models.Trade;


namespace NetProtocol.Packet.G2C
{
    public class TradeItemRegistRes
    {
        public ErrorCode Err = ErrorCode.Success;
        public TradeItemInfo Trade = new();
    }
}
