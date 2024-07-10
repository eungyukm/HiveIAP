namespace NetProtocol
{
    public ref struct AttackInfoBuilder
    {
        private AttackObject _attacker;
        private AttackObject _defender;
        private int _stat;
        private bool _isPhysical;
        private float _skillRate;
        private float _criticalRate;
        private bool _addPenetation;
        private int _shieldStack;
        private int _shield;
        private float _hpDrainRate;
        private float _mpDrainRate;
        private bool _passDefense;
        private bool _passShield;

        public readonly AttackInfo Build()
        {
            var isPvp = _attacker.IsPlayer & _defender.IsPlayer;
            return AttackInfo.Create(
                _attacker,
                _defender,
                _stat,
                _isPhysical,
                _skillRate,
                _criticalRate,
                _addPenetation,
                isPvp,
                _shieldStack,
                _shield,
                _hpDrainRate,
                _mpDrainRate,
                _passDefense,
                _passShield
                );
        }

        public AttackInfoBuilder SetAttacker(in AttackObject attacker)
        {
            _attacker = attacker;
            return this;
        }

        public AttackInfoBuilder SetDefender(in AttackObject defender)
        {
            _defender = defender;
            return this;
        }

        public AttackInfoBuilder SetStat(int statIndex)
        {
            _stat = statIndex;
            return this;
        }

        public AttackInfoBuilder SetPhysical(bool isPhysical)
        {
            _isPhysical = isPhysical;
            return this;
        }

        public AttackInfoBuilder SetSkillRate(float skillRate)
        {
            _skillRate = skillRate;
            return this;
        }

        public AttackInfoBuilder SetCriticalRate(float criticalRate)
        {
            _criticalRate = criticalRate;
            return this;
        }

        public AttackInfoBuilder SetAddPenetration(bool addPenetration)
        {
            _addPenetation = addPenetration;
            return this;
        }

        public AttackInfoBuilder SetShieldStack(int shieldStack)
        {
            _shieldStack = shieldStack;
            return this;
        }

        public AttackInfoBuilder SetShield(int shield)
        {
            _shield = shield;
            return this;
        }

        public AttackInfoBuilder SetHpDrainRate(float hpDrainRate)
        {
            _hpDrainRate = hpDrainRate;
            return this;
        }

        public AttackInfoBuilder SetMpDrainRate(float mpDrainRate)
        {
            _mpDrainRate = mpDrainRate;
            return this;
        }

        public AttackInfoBuilder SetPassDefense(bool passDefense)
        {
            _passDefense = passDefense;
            return this;
        }

        public AttackInfoBuilder SetPassShield(bool passShield)
        {
            _passShield = passShield;
            return this;
        }
    }
}
