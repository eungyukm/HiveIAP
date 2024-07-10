namespace NetProtocol.Packet
{
    public class PlayerDeathInfo
    {
        public int AttackerActorType = 0;
        public long AttackerActorId = 0;
        public long AttackerPlayerId = 0;
        public uint AttackerMonsterIndex = 0;
        public string AttackerName = string.Empty;
        
        public uint ZoneIndex = 0;
        public long DeathAt = 0;
        public long LossExp = 0;

        public int ExceptedCostType = 0; 
        public long ExceptedCost = 0;
    }
}