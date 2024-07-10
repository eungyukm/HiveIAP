using System.Numerics;

namespace NetProtocol.Packet.G2C
{
    public class DebugPlayerStateV2Noti
    {
        public long PlayerId;
        public ActorState PlayerState;
        public Vector3 CurrentPos;
        public Vector3 CurrentDir;
        public long TimeStamp = 0;
    }
}