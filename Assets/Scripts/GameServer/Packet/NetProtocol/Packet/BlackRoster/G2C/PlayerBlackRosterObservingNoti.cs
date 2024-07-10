using NetProtocol.Models.Actor.Features;
using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class PlayerBlackRosterObservingNoti
    {
        public long TargetActorId = 0;

        public uint ZoneIndex = 0;

        public DTransform TargetTransform = new DTransform();
        public List<DTransform> TargetPartyTransform = new List<DTransform>();
    }
}