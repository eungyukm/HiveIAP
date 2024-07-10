namespace NetProtocol.Packet.G2C
{
    public class TradeCronAverageBalanceRes
    {
        public ErrorCode Status = ErrorCode.Success;
        
        public int PreviousDayAverageBalance = 0;
        public int WeeklyAverageBalance = 0;
    }
}