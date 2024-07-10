using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Models.Guild;

namespace NetProtocol.Packet.G2C
{
    public class GuildLiveInviteNoti
    {
        public string InviterName = string.Empty;
        public GuildIntro Guild = new();
    }
}