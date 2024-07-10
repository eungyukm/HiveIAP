using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Packet;

namespace NetProtocol.Packet.C2G
{
    // TODO : renaming >> RideMix(Req/Res) - by howon
    public class RideMixV2Req
    {
        public List<RideMixData> Mixes = new();
    }
}
