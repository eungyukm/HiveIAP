using System;
using NetProtocol.Models.Dungeon;

namespace NetProtocol.Packet.G2C
{
    public class DungeonClearHistoryV2Noti
    {
        public DungeonClearInfo[] DungeonClearInfo = Array.Empty<DungeonClearInfo>();
    }
}