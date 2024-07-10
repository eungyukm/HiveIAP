using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class BossDamagedInfoNoti
    {
        public uint BossMonsterIndex = 0;
        public List<BossDamagedInfo> Infos = new List<BossDamagedInfo>();
    }
}