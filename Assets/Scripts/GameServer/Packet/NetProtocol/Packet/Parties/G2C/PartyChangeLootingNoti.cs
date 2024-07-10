namespace NetProtocol.Packet.G2C
{
    public class PartyChangeLootingNoti
    {
        public PartyLootingEnum PreviousLootingType = PartyLootingEnum.Random;
        public PartyLootingEnum ChangedLootingType = PartyLootingEnum.Random;
    }
}