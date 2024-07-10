namespace NetProtocol.Packet
{
    public class RelationInfo
    {
        public FactionType Type = FactionType.Player;
        public FactionType TargetType = FactionType.Player;
        public long TargetId = 0;
        public RelationshipType Relation = RelationshipType.Hostile;
    }
}