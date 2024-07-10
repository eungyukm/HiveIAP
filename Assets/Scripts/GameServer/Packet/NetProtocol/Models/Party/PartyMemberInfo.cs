using NetProtocol.Models.Actor;

namespace NetProtocol.Models.Party
{
    public class PartyMemberInfo
    {
        public long PartyEnterAt = 0;

        public DPlayerActorForGroup Member = new DPlayerActorForGroup();
    }
}