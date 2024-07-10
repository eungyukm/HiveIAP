namespace NetProtocol.Packet.G2C
{
    public class TemporalFluxZoneExitNoti
    {
        // 단순히 나오는 것만 처리, 위상의 이벤트 결과등은 다른 Notify로 처리 예정

        // 테이블 인덱스 값
        public uint Index = 0;
        
        public uint ZoneIndex = 0;
        public uint TemporalFluxZoneIndex = 0;
    }
}
