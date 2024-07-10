namespace NetProtocol.Packet
{
    public class BlackRosterDeathInfo
    {
        public long UniqueId = 0;

        public long ActorId = 0;
        public string PlayerName = string.Empty;

        public long GuildId = 0;
        public string GuildName = string.Empty;
        public int GuildCrest = 0;
        public int GuildFrame = 0;

        public uint ZoneIndex = 0;

        public bool IsObserved = false;
        public int Revenged_Time = 0;

        public int LossPoint = 0;

        public long At = 0;
    }
}