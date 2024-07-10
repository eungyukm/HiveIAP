using System;

namespace RM2.Login.Structures.Player
{
    public class WorldPlayerData
    {
        public int WorldId { get; set; } = 0;
        public long PlayerId { get; set; } = 0;
        public string Name { get; set; } = "";
        public int Level { get; set; } = 0;
        public short ClassId { get; set; } = 0;
        public DateTime LastPlayedAt { get; set; } = DateTime.UtcNow;
    }
}