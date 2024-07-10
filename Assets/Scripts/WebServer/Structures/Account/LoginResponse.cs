namespace RM2.Login.Structures.Account
{
    public class LoginResponse
    {
        public long AccountId { get; set; } = 0;
        public string Token { get; set; } = string.Empty;
        public int LastSelectWorldId { get; set; } = 0;
    }
}