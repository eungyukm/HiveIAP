using System;
using System.Numerics;

namespace NetProtocol.Packet.C2G
{
    public class PlayerMoveV2Req
    {
        public Vector3 CurrentPos;
        public Vector3 Dir;
        public MoveState MoveState;
        public long PerformTime;
    }

    public class RTTPlayerMoveV2Req
    {
        public Vector3 CurrentPos;
        public Vector3 Dir;
        public MoveState MoveState;
        public long PerformTime;
        public DateTime UtcSendTime;
    }
}