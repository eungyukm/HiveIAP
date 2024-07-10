using NetProtocol.Models.Guild;

namespace NetProtocol.Packet.G2C
{
    public class GuildJoinRequestConfirmRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public long AccountId;
        public bool Confirm;
        public GuildMember Member = new();
    }
}