using System;
using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class GuildDonateRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public uint DonateCount = 0;
    }
}