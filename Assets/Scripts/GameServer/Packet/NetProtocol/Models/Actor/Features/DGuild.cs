using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Models.Item.Features;
using NetProtocol.Packet;

namespace NetProtocol.Models.Actor.Features
{
    public class DGuild
    {
        public long GuildId = 0;
        public byte CrestImage = 0;
        public byte CrestFrame = 0;
        public string GuildName = string.Empty;
    }
}