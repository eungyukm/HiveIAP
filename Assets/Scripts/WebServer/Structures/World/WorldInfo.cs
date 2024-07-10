using System;
using RM2.Server.Common.Features;

namespace RM2.Login.Structures.World
{
    public class WorldInfo
    {
        // 서비스 월드
        public int WorldId { get; set; }
        public string HashedWorldId { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Host { get; set; } = string.Empty;
        public int Port { get; set; }

        public int MaxPlayers { get; set; }
        public int Players { get; set; }

        public WorldServerState State { get; set; }

        public DateTime UpdateTime { get; set; } = DateTime.UtcNow;
        
        public RM2.Server.Common.Features.WorldInfo ToCommonWorldInfo()
        {
            return new RM2.Server.Common.Features.WorldInfo
            {
                WorldId = WorldId,
                Name = Name,
                Host = Host,
                Port = Port,
                MaxPlayers = MaxPlayers,
                Players = Players,
                State = State,
                UpdateTime = UpdateTime
            };
        }
    }
}