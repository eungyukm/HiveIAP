namespace NetProtocol.Packet.G2C
{
    public class WeaponAppearanceEquipV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public WeaponAppearanceInfo WeaponAppearance;
        public uint ItemIndex;
        public uint UnequipItemIndex;

    }
}