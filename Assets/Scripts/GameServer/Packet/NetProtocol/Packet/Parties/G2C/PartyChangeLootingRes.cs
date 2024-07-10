namespace NetProtocol.Packet.G2C
{
    public class PartyChangeLootingRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public PartyLootingEnum LootingType = PartyLootingEnum.Random;
    }
}