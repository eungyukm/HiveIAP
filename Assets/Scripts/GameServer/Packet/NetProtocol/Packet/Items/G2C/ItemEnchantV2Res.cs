using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class ItemEnchantV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public int Result = 0;                 // 변경된 DwonLevel 수치
        public byte ProtectCount = 0;
        public EquipmentItemV2 TargetItem = new();      // 대상 아이템
    }
}