using NetProtocol.Models.BloodFog;

namespace NetProtocol.Packet.G2C
{
    public class BloodFogUseBuffRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public BloodFogBuff Buff = new BloodFogBuff();
    }
}
