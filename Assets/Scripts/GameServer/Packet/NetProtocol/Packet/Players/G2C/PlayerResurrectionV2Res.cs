using System.Collections.Generic;
using System.Numerics;

namespace NetProtocol.Packet.G2C
{
    public class PlayerResurrectionV2Res
    {
        public ErrorCode Err;
        public uint MapIndex;
        public long Hp;
        public long Mp;
        public Dictionary<uint, uint> Currencies = new();
        public Vector3 CurruntPos;
        public Vector3 Dir;
    }
}