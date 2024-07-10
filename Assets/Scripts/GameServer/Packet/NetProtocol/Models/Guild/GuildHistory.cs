using System.Collections.Generic;
using NetProtocol.Packet;

namespace NetProtocol.Models.Guild
{
    public class GuildHistory
    {
        public byte Type = 0;
        public string Param0 = string.Empty;
        public string Param1 = string.Empty;
        public string Param2 = string.Empty;
        public long TimeHistory = 0;
    }
}