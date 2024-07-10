using Newtonsoft.Json;

namespace RM2.Login.Structures.HivePlatform
{
    public class HiveGetIdpBody
    {
        [JsonProperty("appid")]
        public string AppId { get; set; } = string.Empty;

        [JsonProperty("player_id")]
        public long PlayerId { get; set; } = 0;
        
        [JsonProperty("hive_certification_key")]
        public string HiveCertificationKey { get; set; } = string.Empty;
    }
}