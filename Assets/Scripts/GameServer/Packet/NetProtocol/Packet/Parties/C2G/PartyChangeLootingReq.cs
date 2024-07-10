namespace NetProtocol.Packet.C2G
{
    public class PartyChangeLootingReq
    {
        public PartyLootingEnum LootingType = PartyLootingEnum.Random;
        public int LootingItemGrade = 0; // 아이템 등급 설정?, 필요시 패킷 분리?
    }
}