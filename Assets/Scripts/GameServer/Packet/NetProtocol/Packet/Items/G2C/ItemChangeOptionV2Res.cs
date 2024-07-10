using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class ItemChangeOptionV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public EquipmentItemV2 Item = new();     //성공시 아이템 변경 사항 정보 전송
    }
}