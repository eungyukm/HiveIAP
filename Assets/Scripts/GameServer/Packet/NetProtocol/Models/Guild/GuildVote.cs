using System.Collections.Generic;
using NetProtocol.Packet;

namespace NetProtocol.Models.Guild
{
    public class GuildVote
    {
        public long VoteId = 0;
        public GuildVoteType Type = GuildVoteType.None;
        public int VoterCount = 0;
        public long TimeVotingStart = 0;
        public long TimeVotingClose = 0;
    }
}