namespace NetProtocol.Packet.G2C
{
    public class TradeCronCancelRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public long TradeId = 0;
    }
}