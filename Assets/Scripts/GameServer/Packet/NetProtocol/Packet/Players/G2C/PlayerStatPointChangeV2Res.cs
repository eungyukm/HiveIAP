namespace NetProtocol.Packet.G2C
{
    public class PlayerStatPointChangeV2Res
    {
        public ErrorCode Err;
        public int StatPoint;
        public long Hp;
        public long Mp;
        public long MaxHp;
        public long MaxMp;
    }
}