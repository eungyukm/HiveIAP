namespace NetProtocol.Packet.C2G
{
    public class ItemChangeOptionV2Req
    {
        public long ItemId = 0;             // 대상 장비 아이템 고유번호
        public long OptionStoneId = 0;      // 옵션석 아이템 고유번호
        public byte SlotIndex = 0;          // 적용할 옵션슬롯번호(0부터시작)
    }
}