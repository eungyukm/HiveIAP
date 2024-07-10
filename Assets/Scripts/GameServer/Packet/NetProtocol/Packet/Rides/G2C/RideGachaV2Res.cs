using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class RideGachaV2Res
    {
        public ErrorCode Result;
        public List<uint> Rides = new();
    }
}
