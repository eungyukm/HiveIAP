using System;
using Newtonsoft.Json;

namespace RM2.Server.Common.Features
{
    public class GameServerEnvironment
    {
        public int WorldId { get; set; }
        public int ServerId { get; set; }
    
        public int MaxPlayers { get; set; }
        public int Players { get; set; }
    
        public string Host { get; set; }
        public int Port { get; set; }
    
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow.AddMinutes(-10);
    
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    
        public static GameServerEnvironment FromJson(string json)
        {
            return string.IsNullOrEmpty(json)
                ? null
                : JsonConvert.DeserializeObject<GameServerEnvironment>(json);
        }
    }
}

