using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class CostumeConfirmChangeRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public CostumeConfirm Confirm = new();
    }
}
