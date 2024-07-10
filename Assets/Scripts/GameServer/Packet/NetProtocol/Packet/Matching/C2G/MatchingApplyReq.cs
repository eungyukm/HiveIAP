using System.Collections.Generic;

namespace NetProtocol.Packet.C2G
{
    public class MatchingApplyReq
    {
        public List<uint> DungeonIndices = new List<uint>();
        public bool IsQuick;
    }
}