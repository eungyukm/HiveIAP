using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class WorldBossDamagedInfoNoti
    {
        public uint WorldBossMonsterIndex = 0;
        public List<WorldBossDamagedInfo> Infos = new List<WorldBossDamagedInfo>();
    }
}