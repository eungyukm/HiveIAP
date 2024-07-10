namespace NetProtocol.Packet
{
    public class TicketInfo
    {
        public TicketType Type = 0;     // 티켓 타입. 현재 구성 없음.
        public uint TableIndex = 0;     // 던전 그룹 번호
        public int Count = 0;           // 입장 가능 횟수
        public int FreeCount = 0;       // 무료 입장 가능 횟수
        public long ExpirationTime = 0; // 다음 리셋할 시간
    }
}