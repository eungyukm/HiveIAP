namespace NetProtocol.Packet.C2G
{
    public class GuildAdminUpdateBaseReq
    {
        public byte CrestImage = 0;
        public byte CrestFrame = 0;
        public short Tendency = 0;
        public GuildType Type = GuildType.Open;
    }
}