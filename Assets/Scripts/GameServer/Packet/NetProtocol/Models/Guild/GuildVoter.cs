using System.Collections.Generic;
using NetProtocol.Packet;

namespace NetProtocol.Models.Guild
{
    public class GuildVoter
    {
        public long VoteId = 0;
        public long AccountId = 0;
        public long TimeVoted = 0;
        public long TimeVotingClose = 0;
    }
}