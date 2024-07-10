namespace RM2.Login.Structures.Account
{
    public class HiveLoginBody : IHiveRequestBody
    {
        public string AppId { get; set; } = string.Empty;
        public string Did { get; set; } = string.Empty;
        public string PlayerId { get; set; } = string.Empty;
        public string AuthenticationKey { get; set; } = string.Empty;
        public string DeviceId { get; set; } = string.Empty;
        public string PlatformInfo { get; set; } = string.Empty;
        public string DeviceInfo { get; set; } = string.Empty;
    }
}