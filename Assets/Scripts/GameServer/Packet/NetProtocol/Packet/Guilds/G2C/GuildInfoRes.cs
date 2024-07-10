using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Models.Guild;

namespace NetProtocol.Packet.G2C
{
    public class GuildInfoRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public GuildInfo Info = new();
        public List<GuildMember> Members = new();
        public List<GuildBuff> Buffs = new();
        public long TimeLogin = 0;
        public uint DonateCount = 0;
        public int Ranking = 0;
    }
}