using NetProtocol.Packet;

namespace NetProtocol.Packet.C2G
{
    public class SkillUnEquipV2Req
    {
        public byte PresetNumber;  
        public byte SlotNumber;

        public bool IsAll;
    }
}