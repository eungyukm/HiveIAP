namespace NetProtocol.Packet.G2C
{
    public class TradeCronTimeToNextChangeBalanceRes
    {
        public ErrorCode Status = ErrorCode.Success;
        // 환율 변경까지 남은 시간
        public long TimeSpanTicks = 0;
    }
}