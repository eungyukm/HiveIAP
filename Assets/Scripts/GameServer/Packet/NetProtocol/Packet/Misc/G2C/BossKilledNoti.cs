namespace NetProtocol.Packet.G2C
{
    public class BossKilledNoti
    {
        public BossDamagedInfo KillerInfo = new BossDamagedInfo();
        public uint MonsterDataId = 0;
        public uint ZoneDataId = 0;
    }
}