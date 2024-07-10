namespace NetProtocol.Packet.C2G
{
    public class GuildCreateReq
    {
        public byte CrestImage = 0;
        public byte CrestFrame = 0;
        public string GuildName = string.Empty;
        public short Tendency = 0;
        public GuildType Type = GuildType.Open;
        public string Intro = string.Empty;
    }
}