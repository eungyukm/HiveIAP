using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.C2G
{
    public class CostumeCardMixReq
    {
        public List<CostumeMixData> Mixes = new();
    }
}