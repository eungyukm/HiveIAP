
using Newtonsoft.Json;

namespace RM2.Login.Structures.HivePlatform
{
    public class HiveValidateTokenBody
    {
        [JsonProperty("appid")]
        public string AppId { get; set; } = "";

        [JsonProperty("did")]
        public string Did { get; set; } = "";

        [JsonProperty("player_id")]
        public string PlayerId { get; set; } = "";

        [JsonProperty("hive_certification_key")]
        public string HiveCertificationKey { get; set; } = "";
    }
}