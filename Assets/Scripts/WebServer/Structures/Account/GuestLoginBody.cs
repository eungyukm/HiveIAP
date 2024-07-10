namespace RM2.Login.Structures.Account
{
    public class GuestLoginBody
    {
        public string Username { get; set; } = string.Empty;
        public string DeviceId { get; set; } = string.Empty;
        public string PlatformInfo { get; set; } = string.Empty;
        public string DeviceInfo { get; set; } = string.Empty;
    }
}