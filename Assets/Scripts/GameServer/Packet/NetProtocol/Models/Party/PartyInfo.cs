using System.Collections.Generic;
using NetProtocol.Packet;

namespace NetProtocol.Models.Party
{
    public class PartyInfo
    {
        public long PartyId = 0;
        public long PartyLeaderId = 0;
        public PartyLootingEnum LootingType = PartyLootingEnum.Random;
        public int LootingItemGrade = 0; // 아이템 등급 설정
        public List<PartyMemberInfo> Members = new List<PartyMemberInfo>();
    }
}