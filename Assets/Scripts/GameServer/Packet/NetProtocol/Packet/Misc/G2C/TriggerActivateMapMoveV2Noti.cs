using System.Numerics;

namespace NetProtocol.Packet.G2C
{
    public class TriggerActivateMapMoveV2Noti
    {
        public ErrorCode Err;
        public uint Index;
        public Vector3 Pos;
        public Vector3 Dir;
    }
}