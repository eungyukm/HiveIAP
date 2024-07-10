using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class BindStonesNoti
    {
        public int DesignatedBindStoneIndex;
        public List<BindStone> BindStones = new List<BindStone>();
    }
}