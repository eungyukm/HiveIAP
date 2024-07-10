using System.Collections.Generic;
using NetProtocol.Models.Dungeon;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class PartyDungeonClearNoti
    {
        public DungeonClearType ClearType = DungeonClearType.None;
        
        public int ClearLevel = 0; //0 : 실패, 1 성공 ( 1보다 높은건 클리어 등급이 높은것)
        
        public long ClearTime = 0;
        public long ExpiredTime = 0;
        
        public DungeonClearInfo ClearInfo;

        public List<ItemV2> Rewards = new List<ItemV2>();
        public Dictionary<long, ItemV2> PersonalRewards = new Dictionary<long, ItemV2>();
    }
}