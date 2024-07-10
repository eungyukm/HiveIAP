using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class RideAttachDisassembleV2Res
    {
        public ErrorCode Result;
        public List<long> AttachIDs = new();
        public List<ItemV2> Items = new();
    }
}
