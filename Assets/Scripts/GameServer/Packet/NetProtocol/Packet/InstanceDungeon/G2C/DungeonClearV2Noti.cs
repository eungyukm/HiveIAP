using System;
using NetProtocol.Models.Dungeon;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class DungeonClearV2Noti
    {
        public DungeonClearType ClearType = DungeonClearType.None;
        public ErrorCode Error = ErrorCode.Success;
        public int ClearLevel = 0; //0 : 실패, 1 성공 ( 1보다 높은건 클리어 등급이 높은것)
        public long ClearTime = 0;
        public long ExpiredTime = 0;
        public DungeonClearInfo ClearInfo;
        public DungeonRewardInfoV2 RewardInfo;
        public PersonalRewardInfoV2[] PersonalRewards = Array.Empty<PersonalRewardInfoV2>();
    }
}