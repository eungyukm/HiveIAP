using System;
using System.Numerics;

namespace NetProtocol.Packet.G2C
{
    public class PlayerMoveV2Res
    {
        public ErrorCode Error;
        public Vector3 CurrentPos;
    }

    public class RTTPlayerMoveV2Res
    {
        public ErrorCode Error;
        public Vector3 CurrentPos;
        public DateTime UtcSendTime;
    }
}