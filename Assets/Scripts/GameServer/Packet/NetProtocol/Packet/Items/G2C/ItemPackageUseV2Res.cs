namespace NetProtocol.Packet.G2C
{
    public class ItemPackageUseV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public long UseItemId = 0;
        public uint UseItemIndex = 0;
        public int ResultIndex = 0;
    }
}
