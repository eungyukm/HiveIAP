using NetProtocol.Models.Party;

namespace NetProtocol.Packet.G2C
{
    public class PartyInviteReplyRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public PartyInfo Party = new PartyInfo();
    }
}