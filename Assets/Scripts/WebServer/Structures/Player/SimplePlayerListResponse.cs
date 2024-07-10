using System;

namespace RM2.Login.Structures.Player
{
    public class SimplePlayerListResponse
    {
        public SimpleLobbyPlayerData[] Players { get; set; } = Array.Empty<SimpleLobbyPlayerData>();
    }
}