namespace NetProtocol.Packet.G2C
{
    // 스킬 사용 프로토콜
    public class SkillUseV2Noti
    {
        public long ActorId;        // 시전자 ID
        public long TargetActorId;  // 타겟 ID
        public int SkillIndex;         // 스킬 ID
        public long CastingTime;    // 서버 기준 캐스팅 종료 시간
    }
}
