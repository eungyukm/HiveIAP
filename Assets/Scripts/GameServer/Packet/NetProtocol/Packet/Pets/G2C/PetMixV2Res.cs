using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class PetMixV2Res
    {
        public ErrorCode Result = ErrorCode.Success;
        public List<PetMixData> Mixes = new();
        public List<uint> Pets = new();
    }
}