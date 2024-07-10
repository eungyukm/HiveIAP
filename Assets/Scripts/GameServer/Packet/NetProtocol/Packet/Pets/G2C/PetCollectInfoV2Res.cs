using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class PetCollectInfoV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public PetCollect[] PetCollects;
    }
}