using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class PlayerLootingV2Noti
    {
        public long PlayerId;
        public long NpcId;
        public List<byte> ItemTypes = new();
    }
}