namespace RM2.Login.Structures.Account
{
    public interface IHiveRequestBody
    {
        public string AppId { get; set; }
        public string Did { get; set; }
        public string PlayerId { get; set; }
        public string AuthenticationKey { get; set; }
    }
}