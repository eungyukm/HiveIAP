namespace NetProtocol.Packet.G2C
{
    public class TradeCronRemainingCanceledPenaltyTimeRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public long RemainingCanceledPenaltyTimeSpanTicks = 0;
    }
}