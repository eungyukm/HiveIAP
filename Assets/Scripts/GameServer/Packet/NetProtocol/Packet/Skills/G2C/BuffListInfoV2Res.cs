using System.Collections.Generic;
using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class BuffListInfoV2Res
    {
        public ErrorCode Err;
        public List<BuffInfo> Buffs;
    }
}