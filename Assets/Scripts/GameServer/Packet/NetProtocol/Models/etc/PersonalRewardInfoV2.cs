using System;
using NetProtocol.Packet;

namespace NetProtocol.Models.Item
{
    public class PersonalRewardInfoV2
    {
        public long player_id = 0;
        public ItemUpdate[] ItemUpdates = Array.Empty<ItemUpdate>();
        public ItemV2[] Items = Array.Empty<ItemV2>();
        
    }
}