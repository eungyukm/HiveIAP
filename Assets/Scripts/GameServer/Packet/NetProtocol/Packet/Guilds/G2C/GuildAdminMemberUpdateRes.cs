namespace NetProtocol.Packet.G2C
{
    public class GuildAdminMemberUpdateRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public long AccountId;
        public GuildMemberType MemberType = GuildMemberType.Normal;
    }
}