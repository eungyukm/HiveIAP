namespace NetProtocol.Packet.G2C
{
    public class SkillDotHealEffectV2Noti
    {
        public long CasterActorId;
        public long TargetActorId;
        public long SkillLinkId;
        public long Amount;
        public bool IsHp; // true : Hp, false : Mp
    }
}
