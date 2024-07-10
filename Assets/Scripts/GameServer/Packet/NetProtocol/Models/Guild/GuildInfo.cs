using System.Collections.Generic;
using NetProtocol.Packet;

namespace NetProtocol.Models.Guild
{
    public class GuildInfo : GuildBase
    {
        public GuildType Type = GuildType.Open;
        public GuildStateType State = GuildStateType.Normal;
        public uint Level = 0;
        public uint EXP = 0;
        public uint Point = 0;
        public short Tendency = 0;
        public long Ruby = 0;
        public long Cron = 0;
        public string Notice = string.Empty;
    }
}