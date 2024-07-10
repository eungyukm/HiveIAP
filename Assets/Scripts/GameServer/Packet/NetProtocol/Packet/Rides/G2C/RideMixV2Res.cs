using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class RideMixV2Res
    {
        public ErrorCode Result;
        public List<RideMixData> Mixes = new();
        public List<uint> Rides = new();
    }
}
