using System;

namespace RM2.Login.Structures.Player
{
    public class PlayerListResponse
    {
        public long PrimaryPlayerId { get; set; } = 0;
        public LobbyPlayerData[] Players { get; set; } = Array.Empty<LobbyPlayerData>();
    }
}