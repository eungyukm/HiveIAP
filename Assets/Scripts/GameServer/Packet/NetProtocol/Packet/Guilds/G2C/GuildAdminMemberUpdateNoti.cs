namespace NetProtocol.Packet.G2C
{
    public class GuildAdminMemberUpdateNoti
    {
        public long AccountId;
        public GuildMemberType MemberType = GuildMemberType.Normal;
    }
}