using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class CostumeCardMixRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public List<CostumeMixData> Mixes = new();
        public List<uint> Cards = new();
    }
}