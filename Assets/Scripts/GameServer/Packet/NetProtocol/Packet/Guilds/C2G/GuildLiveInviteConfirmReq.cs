namespace NetProtocol.Packet.C2G
{
    public class GuildLiveInviteConfirmReq
    {
        public string InviterName = string.Empty;
        public long GuildId;
        public bool Confirm; // true 수락, false 거절
    }
}