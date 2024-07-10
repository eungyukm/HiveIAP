namespace NetProtocol.Packet.G2C
{
    public class InteractEndRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public long TargetActorId = 0;
    }
}