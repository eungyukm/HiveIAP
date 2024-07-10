namespace NetProtocol.Packet.G2C
{
    public class InteractCancelRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public long TargetActorId = 0;
    }
}