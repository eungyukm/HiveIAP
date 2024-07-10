
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class ItemInheritRes
    {
        public ErrorCode Err = ErrorCode.Success;
        public bool IsSuccess = false;
        public EquipmentItemV2 ResultItem = new();
    }
}
