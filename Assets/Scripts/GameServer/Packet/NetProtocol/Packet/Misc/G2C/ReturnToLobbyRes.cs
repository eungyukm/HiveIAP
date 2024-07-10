using System.Collections.Generic;
using NetProtocol.Models.Player;

namespace NetProtocol.Packet.G2C
{
    public class ReturnToLobbyRes
    {
        public ErrorCode Status;
        public List<LobbyPlayerV2> Players = new();
        
    }
}