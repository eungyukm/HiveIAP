namespace NetProtocol.Packet.G2C
{
    public class MatchingReplyRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public MatchingReply Reply = MatchingReply.None;
    }
}