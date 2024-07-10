
namespace NetProtocol.Packet.G2C
{
    public class BloodFogPlayerDeathNoti
    {
        public bool IsPlayerKill = false;
        public long MonsterActorId = 0;

        public int LossUnstableSerum = 0;
        public int LossStableSerum = 0;

        public int Rank = 0;
        public int ResurractionIntervalSecond = 0;
    }
}
