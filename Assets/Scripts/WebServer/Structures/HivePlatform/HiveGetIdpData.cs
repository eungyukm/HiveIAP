using Newtonsoft.Json;

namespace RM2.Login.Structures.HivePlatform
{
    public class HiveGetIdpData
    {
        [JsonProperty("seq")]
        public long Seq { get; set; } = 0;

        [JsonProperty("player_id")]
        public long PlayerId { get; set; } = 0;

        [JsonProperty("idp_user_id")]
        public string IdpUserId { get; set; } = "";

        [JsonProperty("idp_index")]
        public int IdpIndex { get; set; } = 0;

        [JsonProperty("idp_id")]
        public string IdpId { get; set; } = "";
    }
}
