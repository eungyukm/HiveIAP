using NetProtocol.Models.Actor;
using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class PlayerActorsAppearV2Noti
    {
        public List<DPlayerActorForBroadCast> PlayerActors = new();
    }
}