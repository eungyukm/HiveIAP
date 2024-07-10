namespace NetProtocol.Packet.G2C
{
    public class ItemDeleteV2Noti
    {
        // 나에게만 보냄
        public long ItemId = 0;

        public Trace From = Trace.None;          // 어느 컨텐츠에서 사용 했는지 정보
    }
}