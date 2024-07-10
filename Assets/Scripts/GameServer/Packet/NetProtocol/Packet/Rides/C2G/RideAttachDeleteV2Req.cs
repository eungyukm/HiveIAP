using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Packet;

namespace NetProtocol.Packet.C2G
{
    public class RideAttachDeleteV2Req
    {
        public List<long> AttachIDs = new();
    }
}
