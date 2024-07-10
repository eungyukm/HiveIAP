namespace NetProtocol.Packet.G2C
{
    public class ItemUseV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public long UseItemId = 0;
        public uint DataId = 0;
    }
}