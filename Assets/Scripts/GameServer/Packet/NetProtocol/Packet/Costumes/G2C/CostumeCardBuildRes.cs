using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class CostumeCardBuildRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public CostumeCard Card = new();
        public CostumeData Costume = new();
    }
}