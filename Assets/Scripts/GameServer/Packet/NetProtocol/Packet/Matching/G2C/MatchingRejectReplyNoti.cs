namespace NetProtocol.Packet.G2C
{
    public class MatchingRejectReplyNoti
    {
        public long MatchingId;
        public long RejectActorId;
        public MatchingReply Reply = MatchingReply.Reject;
    }
}