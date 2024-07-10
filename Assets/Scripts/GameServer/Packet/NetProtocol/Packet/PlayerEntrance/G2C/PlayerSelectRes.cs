using System;
using NetProtocol.Models.Actor;

namespace NetProtocol.Packet.G2C
{
    public class PlayerSelectRes
    {
        public ErrorCode Err;

        public DateTime ServerTime;
    }
}