namespace NetProtocol.Packet.G2C
{
    public class ItemEquipV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public EquipSlot EquipSlot = EquipSlot.None;
        public long EquipItemId = 0;        // 이 값이 0이면 해당 EquipSlot은 벗겨졌다는 의미
    }
}