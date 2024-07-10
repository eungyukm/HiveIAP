using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class PlayerBlackRosterRankRes
    {
        public ErrorCode Status = ErrorCode.Success;

        public List<AccountPvpRankInfo> Ranks = new List<AccountPvpRankInfo>();
        public AccountPvpRankInfo MyRank = new AccountPvpRankInfo();
    }
}