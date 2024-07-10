namespace NetProtocol.Packet.G2C
{
    public class MatchingReplyNoti
    {
        public long ActorId;
        public long MatchingId;
        public MatchingReply Reply = MatchingReply.None;
    }
}