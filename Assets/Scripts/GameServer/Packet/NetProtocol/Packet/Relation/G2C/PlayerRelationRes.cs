namespace NetProtocol.Packet.G2C
{
    public class PlayerRelationRes
    {
        public ErrorCode Status = ErrorCode.Success;
        
        public RelationInfo Info = new RelationInfo();
    }
}