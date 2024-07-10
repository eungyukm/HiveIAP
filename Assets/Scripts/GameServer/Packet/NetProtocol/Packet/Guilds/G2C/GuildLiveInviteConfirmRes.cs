namespace NetProtocol.Packet.G2C
{
    public class GuildLiveInviteConfirmRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public bool Confirm; // true 수락, false 거절
    }
}