using System.Collections.Generic;
using NetProtocol.Models.Player;

namespace NetProtocol.Packet.G2C
{
    public class PlayerGetMacroRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public List<PlayerMacroInfo> Macros = new List<PlayerMacroInfo>();
    }
}