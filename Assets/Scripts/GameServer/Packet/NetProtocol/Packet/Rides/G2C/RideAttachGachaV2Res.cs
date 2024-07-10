using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class RideAttachGachaV2Res
    {
        public ErrorCode Result;
        public List<RideAttachData> RideAttaches = new();
    }
}
