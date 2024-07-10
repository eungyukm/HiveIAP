namespace NetProtocol.Packet.G2C
{
    public class GuildSignRequestRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public GuildType GuildType = GuildType.Close;
        public long GuildId = 0;
    }
}