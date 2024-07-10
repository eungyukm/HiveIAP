namespace NetProtocol.Packet.C2G
{
    public class ItemSetLockReq
    {
        public long ItemId = 0;
        public bool IsLocked = false;   // 잠금 여부(true면 잠김)
    }
}
