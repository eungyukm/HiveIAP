using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class PlayerBlackRosterObservingRes
    {
        public ErrorCode Status = ErrorCode.Success;

        public string TargetPlayerName = string.Empty;
        public long TargetActorId = 0;
        public long ExpiredAt = 0;
    }
}