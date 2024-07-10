namespace NetProtocol
{
    // 1차스텟 기반 2차스텟 추가값에 대한 보정값
    public class Correction
    {
        internal readonly int Index; // 영향을 받는 스텟 인덱스(2차)
        internal readonly CorrectionStat[] Values;  // STR, DEX, VIT, INT, WIS, AGI 고정 보정값
        internal readonly CorrectionStat[] Rates;   // STR, DEX, VIT, INT, WIS, AGI 비율 보정값

        public Correction(int index, CorrectionStat[] values, CorrectionStat[] rates)
        {
            Index = index;
            Values = values;
            Rates = rates;
        }

        public class CorrectionStat
        {
            public readonly int Index;
            public readonly long Value;

            public CorrectionStat(int index, long value)
            {
                Index = index;
                Value = value;
            }
        }
    }

    public class StatInfo
    {
        public readonly long[] Values;
        public readonly long[] Rates;

        public StatInfo() { }

        public StatInfo(long[] values, long[] rates)
        {
            Values = values;
            Rates = rates;
        }
    }
}
