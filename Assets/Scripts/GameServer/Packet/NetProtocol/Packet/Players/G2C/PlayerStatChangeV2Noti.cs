using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class PlayerStatChangeV2Noti
    {
        public List<(int statType, double stat)> Stats;
    }
}
