namespace NetProtocol
{
    public readonly ref struct AttackInfo
    {
        public readonly AttackObject Attacker;
        public readonly AttackObject Defender;
        internal readonly int Stat;
        internal readonly bool IsPhysical;
        internal readonly float SkillRate;
        internal readonly float CriticalRate;
        internal readonly bool AddPenetration;
        public readonly bool IsPvp;
        internal readonly int ShieldStack;
        internal readonly int Shield;
        internal readonly float HpDrainRate;
        internal readonly float MpDrainRate;
        internal readonly bool PassDefense;
        internal readonly bool PassSheild;

        public AttackInfo(in AttackObject attacker, in AttackObject defender, int stat, bool isPhysical, float skillRate, float criticalRate, bool addPenetration, bool isPvp, int shieldStack, int shield, float hpDrainRate, float mpDrainRate, bool passDefense, bool passSheild)
        {
            Attacker = attacker;
            Defender = defender;
            Stat = stat;
            IsPhysical = isPhysical;
            SkillRate = skillRate;
            CriticalRate = criticalRate;
            AddPenetration = addPenetration;
            IsPvp = isPvp;
            ShieldStack = shieldStack;
            Shield = shield;
            HpDrainRate = hpDrainRate;
            MpDrainRate = mpDrainRate;
            PassDefense = passDefense;
            PassSheild = passSheild;
        }

        internal static AttackInfo Create(in AttackObject attacker, in AttackObject defender, int stat, bool isPhysical, float skillRate, float criticalRate, bool addPenetration, bool isPvp, int shieldStack, int shield, float hpDrainRate, float mpDrainRate, bool passDefense, bool passSheild)
            => new(attacker, defender, stat, isPhysical, skillRate, criticalRate, addPenetration, isPvp, shieldStack, shield, hpDrainRate, mpDrainRate, passDefense, passSheild);
    }
    public readonly struct AttackObject
    {
        internal readonly long Id;
        internal readonly string Name;
        internal readonly int Lv;
        internal readonly bool IsPlayer;
        internal readonly bool IsNormalMonster;
        public readonly bool IsBoss;
        internal readonly bool IsImmune;

        private AttackObject(long id, string name, int lv, bool isPlayer, bool isNormalMonster, bool isBoss)
        {
            Id = id;
            Name = name;
            Lv = lv;
            IsPlayer = isPlayer;
            IsNormalMonster = isNormalMonster;
            IsBoss = isBoss;
            IsImmune = false;
        }

        public static AttackObject Create(long id, string name, int lv, bool isPlayer, bool isNormalMonster, bool isBoss)
            => new(id, name, lv, isPlayer, isNormalMonster, isBoss);
    }

    public readonly struct Abnormal
    {
        internal readonly uint SkillIndex;
        internal readonly int AbnormalIndex;
        internal readonly int ResistIndex;
    }
}
