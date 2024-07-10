namespace NetProtocol.Packet.G2C
{
    public class TradeCronReclaimExpiredRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public long TradeId = 0;
    }
}