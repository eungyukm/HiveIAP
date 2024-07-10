using System.Collections.Generic;
using NetProtocol.Packet;

namespace NetProtocol.Models.Guild
{
    public class GuildIntro : GuildBase
    {
        public GuildType Type = GuildType.Open;
        public string Master = string.Empty;
        public uint Level = 0;
        public short Tendency = 0;
        public string Intro = string.Empty;
        public int MemberCount = 0;
    }
}