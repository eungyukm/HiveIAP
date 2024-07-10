using System;
using Newtonsoft.Json;

namespace RM2.Login.Structures.HivePlatform
{
    public class HiveGetIdpResponse : IHiveResponse
    {
        [JsonProperty("result_code")]
        public HiveResultCode ResultCode { get; set; } = HiveResultCode.Success;

        [JsonProperty("result_message")]
        public string ResultMessage { get; set; } = "";

        [JsonProperty("data")]
        public HiveGetIdpData[] Data { get; set; } = Array.Empty<HiveGetIdpData>();
    }
}