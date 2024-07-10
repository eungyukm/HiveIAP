namespace NetProtocol.Packet.G2C
{
    public class AccountBlockPlayerReasonEditRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public AccountBlockPlayerInfo BlockPlayer = new AccountBlockPlayerInfo();
    }
}