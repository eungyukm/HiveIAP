using System.Collections.Generic;
using NetProtocol.Packet;

namespace NetProtocol.Models.Guild
{
    public class GuildMember
    {
        public long AccountId = 0;
        public GuildMemberType MemberType = GuildMemberType.Normal;
        public uint ClassIndex = 0;
        public string Name = string.Empty;
        public int Level = 0;
        public int BattlePower = 0;
        public uint DonationPoint = 0;
        public uint DonationStack = 0;
        public GuildMemberStateType State = GuildMemberStateType.OffLine;
        public long TimeState = 0;
        public long TimeJoin = 0;
    }
}