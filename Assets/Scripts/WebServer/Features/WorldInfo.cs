using System;

namespace RM2.Server.Common.Features
{
    public class WorldInfo
    {
        // 서비스 월드
        public int WorldId { get; set; }
    
        public string Name { get; set; } = string.Empty;

        public string Host { get; set; } = string.Empty;
        public int Port { get; set; }
    
        public int MaxPlayers { get; set; }
        public int Players { get; set; }
    
        public WorldServerState State { get; set; }

        public DateTime UpdateTime { get; set; } = DateTime.UtcNow;
    }
}

