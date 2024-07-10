using NetProtocol.Packet;

namespace NetProtocol.Models.Skill.Features
{
    public class UsedSkillInfo
    {
        public long ActorId;
        public int SkillDataId;
        public int SkillLinkDataId;

        public int Damage;

        public AttackJudgment AttackJudgment = AttackJudgment.Normal;
    }
}