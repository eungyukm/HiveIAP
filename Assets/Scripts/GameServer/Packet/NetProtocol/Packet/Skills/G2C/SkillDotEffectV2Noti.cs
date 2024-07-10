namespace NetProtocol.Packet.G2C
{
    public class SkillDotEffectV2Noti
    {
        public long CasterActorId;
        public long TargetActorId;
        public long SkillLinkId;
        public long Damage;
        public AttackJudgment Judgment = AttackJudgment.Normal;

        // 추후 다른 패킷으로 분리될 가능성 존재
        public long BarrierValue;
        // 추후 다른 패킷으로 분리될 가능성 존재
        public bool BarrierStack;
    }
}