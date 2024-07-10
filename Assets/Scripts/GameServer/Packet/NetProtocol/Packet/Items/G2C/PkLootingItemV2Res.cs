using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class PkLootingItemV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public List<long> PkLootingIds = new();
    }
}