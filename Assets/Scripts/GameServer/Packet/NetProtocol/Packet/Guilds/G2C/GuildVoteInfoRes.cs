using System.Collections.Generic;
using NetProtocol.Models.Guild;

namespace NetProtocol.Packet.G2C
{
    public class GuildVoteInfoRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public List<GuildVote> Votes = new();
        public List<GuildVoter> Voters = new();
    }
}