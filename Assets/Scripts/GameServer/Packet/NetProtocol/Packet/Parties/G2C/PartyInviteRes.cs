namespace NetProtocol.Packet.G2C
{
    public class PartyInviteRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public long ExpireAt = 0;

        public long InvitedActorId = 0;
        public string InvitedActorName = string.Empty;
        public int InvitedActorLevel = 0;
        public int ClassId = 0;
    }
}