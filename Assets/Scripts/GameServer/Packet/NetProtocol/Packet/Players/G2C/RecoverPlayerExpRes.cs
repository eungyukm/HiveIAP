namespace NetProtocol.Packet.G2C
{
    public class RecoverPlayerExpRes
    {
        public ErrorCode Status = ErrorCode.Success;

        public long UniqueId;

        public long RecoverExp = 0;
        public long CurrentExp = 0;

        public int DailyRecoverCount;
    }
}