using System;

namespace NetProtocol.Packet.G2C
{
    public class PlayerStatV2Res
    {
        public ErrorCode Err;
        public long[] BaseValues = Array.Empty<long>();
        public long[] BaseRates = Array.Empty<long>();
        public long[] ExtendValues = Array.Empty<long>();
        public long[] ExtendRates = Array.Empty<long>();
    }
}
