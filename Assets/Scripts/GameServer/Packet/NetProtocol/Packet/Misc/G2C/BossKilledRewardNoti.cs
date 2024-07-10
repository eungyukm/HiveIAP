using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class BossKilledRewardNoti
    {
        public List<BossDamagedInfo> Infos = new List<BossDamagedInfo>();

        public BossDamagedInfo LastDamagedActorInfo = new BossDamagedInfo();
        public uint MonsterDataId = 0;
        
        // Reward
        public uint TopPlayerRewardItemIndex = 0;
    }
}