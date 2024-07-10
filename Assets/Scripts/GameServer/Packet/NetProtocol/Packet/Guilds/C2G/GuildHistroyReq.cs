namespace NetProtocol.Packet.C2G
{
    public class GuildHistroyReq
    {
        public int FindCount = 20;  // Count    : 20개를 넘으면 20개
        public int FindPage = 0;    // Page     : 0(Count 단위 첫번째), 1(Count 단위 두번째) ...
    }
}