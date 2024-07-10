using Newtonsoft.Json;

namespace RM2.Login.Structures.HivePlatform
{
    public interface IHiveResponse
    {
        [JsonProperty("result_code")]
        public HiveResultCode ResultCode { get; set; }

        [JsonProperty("result_message")]
        public string ResultMessage { get; set; }
    }
}