using System.Collections.Generic;
using NetProtocol.Models.Player;

namespace NetProtocol.Packet.C2G
{
    public class PlayerSetMacroReq
    {
        public List<PlayerMacroInfo> Macros = new List<PlayerMacroInfo>();
    }
}