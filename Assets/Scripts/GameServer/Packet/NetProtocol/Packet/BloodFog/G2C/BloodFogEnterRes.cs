using System.Collections.Generic;
using System.Numerics;

namespace NetProtocol.Packet.G2C
{
    public class BloodFogEnterRes
    {
        public ErrorCode Status = ErrorCode.Success;

        public uint BloodFogIndex = 0;

        public int UnstableSerum = 0;
        public int StableSerum = 0;

        public int BloodFogGrade = 0;

        public int ChainKill = 0;
        public int ChainDeath = 0;

        public long EndTimeAt = 0;

        public List<Vector3> BloodFogAlters = new List<Vector3>();
    }
}