namespace NetProtocol.Packet.G2C
{
    public class ItemSelectUseV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public long UseItemId = 0;
        public int SelectIndex = 0;     // PackageRewardSelect.INDEX
        public uint DataId = 0;
    }
}
