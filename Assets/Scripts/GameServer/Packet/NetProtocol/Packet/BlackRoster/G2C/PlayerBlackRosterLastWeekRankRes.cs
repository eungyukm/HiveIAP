using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class PlayerBlackRosterLastWeekRankRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public List<AccountPvpRankInfo> Ranks = new List<AccountPvpRankInfo>();
    }
}