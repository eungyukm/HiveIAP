namespace NetProtocol
{
    public partial class StatComponent
    {
        public long[] BaseValue => _baseValue;
        public long[] BaseRate => _baseRate;
        public long[] ExtendValue => _extendValue;
        public long[] ExtendRate => _extendRate;

        public void Initialize(StatInfo statInfo, Correction[] corrections, float[] min, float[] max, bool[] percent,
            long[] baseValues, long[] baseRates, long[] extendValues, long[] extendRates)
        {
            _statInfo = statInfo;
            _corrections = corrections;
            _min = min;
            _max = max;
            _percent = percent;

            for (int idx = 0; idx < _length; ++idx)
            {
                _baseValue[idx] = _statInfo.Values[idx];
                _baseRate[idx] = _statInfo.Rates[idx];
            }

            Set(baseValues, baseRates, extendValues, extendRates);
        }

        public void Set(long[] baseValues, long[] baseRates, long[] extendValues, long[] extendRates)
        {
            _baseValue = baseValues;
            _baseRate = baseRates;
            _extendValue = extendValues;
            _extendRate = extendRates;

            AllChange();
            UpdateAll();
        }
    }
}
