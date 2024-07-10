namespace NetProtocol.Packet.C2G
{
    public class GuildFindReq
    {
        public GuildFindCaseType GuildType = GuildFindCaseType.All;
        public GuildFindOptionType FindType = GuildFindOptionType.Random;
        public int FindCount = 100; // Count    : 100개를 넘으면 100개
        public int FindPage = 0;    // Page     : 0(Count 단위 첫번째), 1(Count 단위 두번째) ...
        public string GuildName = string.Empty;
    }
}
