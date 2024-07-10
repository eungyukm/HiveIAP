namespace NetProtocol.Packet.G2C
{
    public class GuildSignRequestCancelRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public long GuildId;
    }
}