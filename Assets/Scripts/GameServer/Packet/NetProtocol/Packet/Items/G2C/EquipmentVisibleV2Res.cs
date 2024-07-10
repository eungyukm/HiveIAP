namespace NetProtocol.Packet.G2C
{
    public class EquipmentVisibleV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public EquipSlot EquipSlot = EquipSlot.None;
        public bool IsVisible = true;
    }
}
