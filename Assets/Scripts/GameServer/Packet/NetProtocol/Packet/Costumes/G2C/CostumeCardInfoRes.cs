using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class CostumeCardInfoRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public List<CostumeCard> Cards = new();
    }
}
