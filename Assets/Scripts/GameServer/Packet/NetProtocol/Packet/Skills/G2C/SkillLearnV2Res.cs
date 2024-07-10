using NetProtocol.Models.Skill.Features;

namespace NetProtocol.Packet.G2C
{
    public class SkillLearnV2Res
    {
        public ErrorCode Error;
        public PlayerSkillInfo Skill;
    }
}