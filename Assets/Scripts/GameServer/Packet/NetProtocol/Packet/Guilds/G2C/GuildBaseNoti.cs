using System;
using NetProtocol.Packet;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class GuildBaseNoti
    {
        public long GuildId = 0;
        public string GuildName = string.Empty;
        public byte CrestImage = 0;
        public byte CrestFrame = 0;
        public long TimeLeave = 0;
    }
}