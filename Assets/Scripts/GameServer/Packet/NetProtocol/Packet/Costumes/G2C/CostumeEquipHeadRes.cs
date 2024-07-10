using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class CostumeEquipHeadRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public uint CostumeIndex;
    }
}