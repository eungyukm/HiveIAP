using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class SkillEquipV2Res
    {
        public ErrorCode Status;

        public byte PresetNumber;
        public byte SlotNumber;
        public uint SkillSerial;
    }
}