namespace NetProtocol.Packet.G2C
{
    public class ActorGuildV2Noti
    {
        public long ActorId;
        public long GuildId;
        public byte CrestImage = 0;
        public byte CrestFrame = 0;
        public string Name = string.Empty;
    }
}