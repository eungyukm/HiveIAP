using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Packet;

namespace NetProtocol.Packet.C2G
{
    public class PetMixV2Req
    {
        public List<PetMixData> Mixes = new();
    }
}
