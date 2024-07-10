using System.Collections.Generic;
using NetProtocol.Packet;

namespace NetProtocol.Models.Guild
{
    public class GuildBuff
    {
        public uint BuffIndex = 0;
        public long TimeExpire = 0;

        public static uint GetBuffIndex(uint BuffBase, uint BuffLevel)
        {
            return BuffBase * 100 + BuffLevel;
        }
        public static uint GetBuffGroup(uint BuffIndex)
        {
            return BuffIndex / 100;
        }
        public static uint GetBuffLevel(uint BuffIndex)
        {
            return BuffIndex % 100;
        }
    }
}