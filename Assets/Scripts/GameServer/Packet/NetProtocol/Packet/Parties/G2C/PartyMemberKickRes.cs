namespace NetProtocol.Packet.G2C
{
    public class PartyMemberKickRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public long KickedActorId = 0;
    }
}