namespace NetProtocol.Packet.C2G
{
    public class GuildAdminMemberUpdateReq
    {
        public long AccountId;
        public GuildMemberType MemberType = GuildMemberType.Normal;
    }
}