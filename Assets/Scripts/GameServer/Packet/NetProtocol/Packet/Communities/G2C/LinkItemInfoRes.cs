using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class LinkItemInfoRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public ItemV2 ItemInfo = new ItemV2();
    }
}