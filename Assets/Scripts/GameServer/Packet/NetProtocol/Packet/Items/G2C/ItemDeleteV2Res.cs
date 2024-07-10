using System.Collections.Generic;
using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class ItemDeleteV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public List<long> ItemIds = new();
    }
}