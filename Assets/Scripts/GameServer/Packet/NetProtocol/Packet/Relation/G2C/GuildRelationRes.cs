namespace NetProtocol.Packet.G2C
{
    public class GuildRelationRes
    {
        public ErrorCode Status = ErrorCode.Success;
        
        public RelationInfo Info = new RelationInfo();
    }
}