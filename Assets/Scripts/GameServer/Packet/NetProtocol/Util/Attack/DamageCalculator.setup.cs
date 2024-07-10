namespace NetProtocol
{
    public partial class DamageCalculator
    {
        public class Parameter
        {
            internal readonly float ParameterA;
            internal readonly float ParameterB;
            internal readonly float Min;
            internal readonly float Max;

            public Parameter(float parameterA, float parameterB, float min, float max)
            {
                ParameterA = parameterA;
                ParameterB = parameterB;
                Min = min;
                Max = max;
            }
        }

        internal static Parameter Hit = null;
        internal static Parameter Evasion = null;
        internal static Parameter Block = null;
        internal static Parameter Critical = null;
        internal static Parameter CriticalDamage = null;
        internal static Parameter Penetrate = null;
        internal static Parameter Abnormal = null;
        internal static Parameter Reflex = null;
        internal static Parameter HpDrain = null;
        internal static Parameter MpDrain = null;

        private static float _damageMin;
        private static float _damageMax;

        public static void ParameterSet(
            Parameter hit,
            Parameter dodge,
            Parameter block,
            Parameter critical,
            Parameter criticalDamage,
            Parameter penetrate,
            Parameter abnormal,
            Parameter reflex,
            Parameter hpDrain,
            Parameter mpDrain)
        {
            Hit = hit;
            Evasion = dodge;
            Block = block;
            Critical = critical;
            CriticalDamage = criticalDamage;
            Penetrate = penetrate;
            Abnormal = abnormal;
            Reflex = reflex;
            HpDrain = hpDrain;
            MpDrain = mpDrain;
        }

        public static void DamageRangeSet(float min, float max)
        {
            _damageMin = min;
            _damageMax = max;
        }
    }
}
