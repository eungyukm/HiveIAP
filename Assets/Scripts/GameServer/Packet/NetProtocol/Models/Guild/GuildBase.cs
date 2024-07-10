using System.Collections.Generic;
using NetProtocol.Packet;

namespace NetProtocol.Models.Guild
{
    public class GuildBase
    {
        public long Id = 0;
        public string Name = string.Empty;
        public byte CrestImage = 0;
        public byte CrestFrame = 0;
    }
}