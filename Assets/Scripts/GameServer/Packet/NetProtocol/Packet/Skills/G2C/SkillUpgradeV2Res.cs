using NetProtocol.Models.Skill.Features;

namespace NetProtocol.Packet.G2C
{
    public class SkillUpgradeV2Res
    {
        public ErrorCode Status;
        public PlayerSkillInfo Skill;
        public uint PreviousSkillIndex;
    }
}