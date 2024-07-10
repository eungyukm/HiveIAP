namespace NetProtocol.Packet.G2C
{
    public class AccountBlockPlayerAddRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public AccountBlockPlayerInfo BlockPlayer = new AccountBlockPlayerInfo();
    }
}