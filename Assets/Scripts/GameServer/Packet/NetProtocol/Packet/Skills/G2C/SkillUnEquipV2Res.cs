namespace NetProtocol.Packet.G2C
{
    public class SkillUnEquipV2Res
    {
        public ErrorCode Status;

        public byte PresetNumber;  
        public byte SlotNumber;

        public bool IsAll;
    }
}