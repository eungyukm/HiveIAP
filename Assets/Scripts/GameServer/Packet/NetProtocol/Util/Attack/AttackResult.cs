using NetProtocol.Packet;
using NetProtocol.Packet.C2G;

#nullable enable
namespace NetProtocol
{
    public readonly ref struct AttackResult
    {
        public readonly AttackJudgment Judgment;
        public readonly bool AttackSuccess;             // 공격 성공여부 판단
        public readonly int Damage;                   // 피해량
        public readonly int ShieldDamage;             // 보호막 피해량
        public readonly bool ShieldStack;               // 실드 파괴여부
        public readonly long HpDrain;                  // 체력 흡수량
        public readonly long MpDrain;                  // 마나 흡수량
        public readonly int Reflex;                   // 반사 피해량
        internal readonly AttackLog? Log;

        public static AttackResult Empty => new AttackResult();

        private AttackResult(AttackJudgment judgment, int damage, long hpDrain, long mpDrain, int reflex, int shieldDamage, bool shieldBreak, AttackLog? log)
        {
            Judgment = judgment;
            AttackSuccess = judgment is AttackJudgment.Normal or AttackJudgment.Critical;
            Damage = damage;
            HpDrain = hpDrain;
            MpDrain = mpDrain;
            Reflex = reflex;
            Log = log;
            ShieldDamage = shieldDamage;
            ShieldStack = shieldBreak;
        }

        private AttackResult(AttackJudgment judgment, AttackLog? log)
            : this(judgment, 0, 0, 0, 0, 0, false, log) { }

        private AttackResult(AttackJudgment judgment, bool shieldBreak, AttackLog? log)
            : this(judgment, 0, 0, 0, 0, 0, shieldBreak, log) { }

        internal static AttackResult Create(AttackJudgment judgment, AttackLog? log)
            => new AttackResult(judgment, log);

        internal static AttackResult Create(AttackJudgment judgment, bool shieldStack, AttackLog? log)
            => new AttackResult(judgment, shieldStack, log);

        internal static AttackResult Create(AttackJudgment judgment, int damage, long hpDrain, long mpDrain, int reflex, int shieldDamage, AttackLog? log)
            => new AttackResult(judgment, damage, hpDrain, mpDrain, reflex, shieldDamage, false, log);

        public string GetLog() => Log?.GetLog() ?? string.Empty;

        public string GetDetailLog() => Log?.GetDetailLog() ?? string.Empty;

    }
}