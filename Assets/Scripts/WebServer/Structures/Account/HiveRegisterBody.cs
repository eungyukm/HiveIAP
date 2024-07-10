namespace RM2.Login.Structures.Account
{
    public class HiveRegisterBody : IHiveRequestBody
    {
        public string AppId { get; set; } = string.Empty;
        public string Did { get; set; } = string.Empty;
        public string PlayerId { get; set; } = string.Empty;
        public string AuthenticationKey { get; set; } = string.Empty;
    }
}