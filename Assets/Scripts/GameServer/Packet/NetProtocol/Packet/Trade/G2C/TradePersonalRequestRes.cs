using NetProtocol.Models.Trade;


namespace NetProtocol.Packet.G2C
{
    public class TradePersonalRequestRes
    {
        public ErrorCode Err = ErrorCode.Success;
        public TradePersonalInfo Trade = new();
    }
}
