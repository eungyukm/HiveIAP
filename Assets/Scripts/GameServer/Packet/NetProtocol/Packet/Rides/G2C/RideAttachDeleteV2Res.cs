using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class RideAttachDeleteV2Res
    {
        public ErrorCode Result;
        public List<long> AttachIDs = new();
    }
}
