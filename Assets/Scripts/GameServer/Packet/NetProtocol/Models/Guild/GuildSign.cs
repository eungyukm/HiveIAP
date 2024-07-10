using System.Collections.Generic;
using NetProtocol.Packet;

namespace NetProtocol.Models.Guild
{
    public class GuildSign
    {
        // Crest / GuildName / GuildMasterName / Level / MemberCount / Tendency / Intro
        public long GuildId = 0;
        public long TimeRequest = 0;
        public long TimeRefusal = 0;
        public GuildIntro Intro = new();
    }
}