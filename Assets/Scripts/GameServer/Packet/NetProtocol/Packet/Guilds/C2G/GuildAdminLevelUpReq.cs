namespace NetProtocol.Packet.C2G
{
    public class GuildAdminLevelUpReq
    {
        public long ActorId;
        public GuildMemberType MemberType = GuildMemberType.Normal;
    }
}