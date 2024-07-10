using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class PetInfoV2Res
    {
        public ErrorCode Result = ErrorCode.Success;
        public uint EquipPetIndex;
        public List<PetData> Pets = new();
    }
}