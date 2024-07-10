using System.Numerics;

namespace NetProtocol.Packet.G2C
{
    public class ActorMoveV2Noti
    {
        public long ActorId;
        public Vector3 Position;
        public MoveState MoveState;
    }
}