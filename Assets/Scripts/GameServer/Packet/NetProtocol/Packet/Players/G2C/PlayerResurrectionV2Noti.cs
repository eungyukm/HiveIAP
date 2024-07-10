using System.Numerics;

namespace NetProtocol.Packet.G2C
{
    public class PlayerResurrectionV2Noti
    {
        public ErrorCode Err;
        public long PlayerId;
        public long Hp;
        public long Mp;
        public Vector3 CurruntPos;
        public Vector3 Dir;
    }
}