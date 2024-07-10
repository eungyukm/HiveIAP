using System.Collections.Generic;
using NetProtocol.Packet;

namespace NetProtocol.Models.Guild
{
    public class GuildJoin
    {
        public long AccountId = 0;
        public uint ClassIndex = 0;
        public string PlayerName = string.Empty;
        public long TimeRequest = 0;
        public long TimeLogined = 0;
    }
}