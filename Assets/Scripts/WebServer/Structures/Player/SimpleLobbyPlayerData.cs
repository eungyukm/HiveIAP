using System;

namespace RM2.Login.Structures.Player
{
    public class SimpleLobbyPlayerData
    {
        public long PlayerId { get; set; } = 0;
        public string HashedPlayerId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int WorldId { get; set; } = 1;
        public short ClassId { get; set; } = 0;
        public int Level { get; set; } = 0;
        public DateTime LastPlayedAt { get; set; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}