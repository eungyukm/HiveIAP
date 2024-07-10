using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class PetEquipV2Res
    {
        public ErrorCode Result = ErrorCode.Success;
        public uint PetIndex;
    }
}