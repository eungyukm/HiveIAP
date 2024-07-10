namespace NetProtocol.Packet.C2G
{
    public class EquipmentVisibleV2Req
    {
        // 착용 아이템 외형 보이기 여부 설정 요청
        public EquipSlot EquipSlot = EquipSlot.None;
        public bool IsVisible = true;
    }
}
