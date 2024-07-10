namespace NetProtocol.Packet.G2C
{
    public class PlayerDeathInfoRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public PlayerDeathInfo DeathInfo = new PlayerDeathInfo();
    }
}