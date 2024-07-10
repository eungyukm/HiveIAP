namespace NetProtocol.Packet.C2G
{
    public class MatchingReplyReq
    {
        public long MatchingId;
        public MatchingReply Reply = MatchingReply.None;
    }
}