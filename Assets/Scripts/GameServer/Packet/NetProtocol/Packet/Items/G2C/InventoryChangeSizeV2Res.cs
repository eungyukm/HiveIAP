namespace NetProtocol.Packet.G2C
{
    public class InventoryChangeSizeV2Res
    {
        public ErrorCode Err;

        public byte InventoryExtendCount = 0;
        public short InventorySize = 0;
    }
}