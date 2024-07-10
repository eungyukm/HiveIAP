namespace NetProtocol.Packet.G2C
{
    public class ActorHpUpdateV2Noti
    {
        public long ActorId;

        public long Amount;
        public long Hp;
        public long MaxHp;

        public Trace From;
    }
}