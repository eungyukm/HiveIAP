namespace NetProtocol.Packet
{
    public class AccountBlockPlayerInfo
    {
        // 차단한 계정 아이디
        public long BlockAccountId = 0;
        // 차단한 계정 이름
        public string Name = string.Empty;
        // 차단 이유
        public string BlockReason = string.Empty;
        // 차단한 시간
        public long AddedAt = 0;
    }
}