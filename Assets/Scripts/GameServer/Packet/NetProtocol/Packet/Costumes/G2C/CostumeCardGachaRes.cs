using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class CostumeCardGachaRes
    {
        public ErrorCode Result;
        public List<uint> Cards = new();
    }
}
