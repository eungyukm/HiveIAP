namespace NetProtocol.Packet.C2G
{
    public class ItemEquipV2Req
    {
        public EquipSlot EquipSlot = EquipSlot.None;        // 착용, 착용해제할 슬롯 번호. EquipSlot.None으로 보내면 안됩니다.
        public long ItemId = 0;                             // 대상 아이템 고유 번호. 벗기고 싶을때는 ItemId의 값은 0으로 보내주면 됩니다.
    }
}