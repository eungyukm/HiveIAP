namespace NetProtocol.Packet.G2C
{
    public class CostumeCollectRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public int[] Collects;
        public int[] CollectIndexes;
    }
}
