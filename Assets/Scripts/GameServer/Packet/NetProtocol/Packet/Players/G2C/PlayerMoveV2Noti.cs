using System.Numerics;

namespace NetProtocol.Packet.G2C
{
    public class PlayerMoveV2Noti
    {
        public long PlayerId;
        public Vector3 CurrentPos;
        public Vector3 Dir;
        public long PerformTime;
        public long ServerSendTick;
        public MoveState MoveState;
    }
}