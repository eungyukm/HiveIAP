using NetProtocol.Models.Player;
using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class QuickslotListNoti
    {
        public List<QuickslotInfo> Infos = new();
    }
}
