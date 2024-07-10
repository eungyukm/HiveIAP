using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class AccountBlockPlayersRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public List<AccountBlockPlayerInfo> BlockPlayers = new List<AccountBlockPlayerInfo>();
    }
}