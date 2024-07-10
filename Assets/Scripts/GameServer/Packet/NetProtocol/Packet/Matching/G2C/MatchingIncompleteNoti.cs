using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class MatchingIncompleteNoti
    {
        public long MatchingId;
        public int ZoneDataId;
        public List<long> ActorIds = new List<long>();
    }
}