using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Models.Guild;

namespace NetProtocol.Packet.G2C
{
    public class GuildMemberUpdateNoti
    {
        public GuildMemberUpdateType UpdateType;
        public GuildMember MemberData;
    }
}