using System;
using NetProtocol.Packet;
using NetProtocol.Models.Item;
using System.Collections.Generic;
using NetProtocol.Models.Guild;

namespace NetProtocol.Packet.G2C
{
    public class GuildMemberNoti
    {
        public List<GuildMember> Members = new();
    }
}