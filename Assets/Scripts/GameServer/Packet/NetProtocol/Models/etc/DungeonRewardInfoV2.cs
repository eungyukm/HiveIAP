using System;
using NetProtocol.Packet;

namespace NetProtocol.Models.Item
{
    public class DungeonRewardInfoV2
    {
        // 아이템, 경험치, 크론은 각자 패킷들로 업데이트 됩니다.
        // 여기 값들은 표현 용도입니다.
        public ulong Exp = 0;
        public ulong Cron = 0;
        
        public ItemUpdate[] ItemUpdates = Array.Empty<ItemUpdate>();
        public ItemV2[] Items = Array.Empty<ItemV2>();
    }
}