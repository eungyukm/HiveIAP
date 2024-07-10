namespace NetProtocol.Packet.G2C
{
    public class GuildAdminUpdateBaseRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public byte CrestImage = 0;
        public byte CrestFrame = 0;
        public short Tendency = 0;
        public GuildType Type = GuildType.Open;
    }
}