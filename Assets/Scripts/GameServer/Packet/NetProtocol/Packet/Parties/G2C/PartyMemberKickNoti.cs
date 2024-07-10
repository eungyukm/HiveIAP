using NetProtocol.Models.Party;

namespace NetProtocol.Packet.G2C
{
    public class PartyMemberKickNoti
    {
        public long KickedActorId = 0;
        public string KickedActorName = string.Empty;
        public PartyInfo Party = new PartyInfo();
    }
}