namespace NetProtocol.Packet.G2C
{
    public class InteractStartRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public long TargetActorId = 0;
        public long EndTimeAt = 0;
    }
}