using NetProtocol.Models.Skill.Features;
using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class PlayerClassUpV2Res
    {
        public int ClassType;
        public EquipSlot EquipSlot;
        public long EquipItemId;
        public ErrorCode ErrorCode;
        public List<PlayerSkillInfo> Skills;
    }
}
