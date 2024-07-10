using NetProtocol.Models.BloodFog;
using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class BloodFogResultNoti
    {
        public List<BloodFogRankInfo> BloodFogRankDatas;
        public List<BloodFogBuff> Buffs = new List<BloodFogBuff>();
    }
}
