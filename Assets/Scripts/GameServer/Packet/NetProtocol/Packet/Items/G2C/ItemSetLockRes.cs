namespace NetProtocol.Packet.G2C
{
    public class ItemSetLockRes
    {
        public ErrorCode Err = ErrorCode.Success;
        public long ItemId = 0;
        public bool IsLocked = false;   // 잠금 여부(true면 잠김)
    }
}
