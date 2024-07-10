namespace NetProtocol.Packet.G2C
{
    public class SkillHitV2Noti
    {
        public long ActorId;
        public long TargetActorId;
        public long SkillIndex;
        public long SkillLinkId;
        public long Damage;
        public AttackJudgment Judgment;

        // 추후 다른 패킷으로 분리될 가능성 존재
        public long BarrierValue;
        // 추후 다른 패킷으로 분리될 가능성 존재
        public bool BarrierStack;
    }
}
