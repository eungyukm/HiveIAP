using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace NetProtocol
{
    public partial class StatComponent
    {
        private const int MIN = 1;

        public const double DIVISION = 10e-5;

        private long[] _baseValue;     // 1,2차 값 증가값
        private long[] _baseRate;      // 1,2차 비율 증가값

        private long[] _extendValue;   // 2차 추가 증가값
        private long[] _extendRate;    // 2차 추가 비율값

        private StatInfo _statInfo;             // 초기스텟 정보
        private Correction[] _corrections;      // 직업별 보정스텟 테이블 데이터

        private readonly double[] _stat;        // 최종값

        private float[] _min;
        private float[] _max;
        private bool[] _percent;

        private bool _baseChange;

        private readonly int _length;

        private readonly ConcurrentBag<int> _updates;

        private readonly int _second;

        public StatComponent(int length, int secondStartIndex)
        {
            _length = length;
            _second = secondStartIndex;
            
            _baseValue = new long[_length];
            _baseRate = new long[_length];
            _extendValue = new long[_length];
            _extendRate = new long[_length];
            
            _stat = new double[_length];

            _updates = new ConcurrentBag<int>();
        }

        public double GetStat(int index)
        {
            UpdateAll();
            return _stat[index];
        }

        public double[] GetStats()
        {
            UpdateAll();
            return _stat;
        }

        public void Initialize(StatInfo statInfo, Correction[] corrections, float[] min, float[] max, bool[] percent)
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

            AllChange();
            UpdateAll();
        }

        public bool UpdateOne(int index, long value, long rate, bool subtraction = false)
        {
            // 0번 안 씁니다. - by antique
            if (_length < index || MIN > index || (MIN > value && MIN > rate))
                return false;
            
            _updates.Add(index);
            return Update(index, value, rate, subtraction);
        }

        public void UpdateAll()
        {
            if (0 == _updates.Count)
                return;

            if (_baseChange)
            {
                ApplyCorrection();
            }

            foreach (var index in _updates)
            {
                Update(index);
            }

            _updates.Clear();
        }

        private void ApplyCorrection()
        {
            _baseChange = false;

            for (int index = 0, length = _corrections?.Length ?? 0; index < length; ++index)
            {
                var correction = _corrections[index];
                InternalApplyCorrection(correction);
            }
        }

        private void InternalApplyCorrection(Correction correction)
        {
            var stat = correction.Index;

            _baseValue[stat] = _statInfo.Values[stat];
            _baseRate[stat] = _statInfo.Rates[stat];

            for (int index = 0, length = correction.Values.Length; index < length; ++index)
            {
                var baseStat = correction.Values[index].Index;
                var value = _baseValue[baseStat] + _extendValue[baseStat];
                var correct = value + (value * ((_baseRate[baseStat] + _extendRate[baseStat]) * DIVISION));

                _baseValue[stat] += (long)(correct * (correction.Values[index].Value * DIVISION));
            }

            for (int index = 0, length = correction.Rates.Length; index < length; ++index)
            {
                var baseStat = correction.Rates[index].Index;
                var value = _baseValue[baseStat] + _extendValue[baseStat];
                var correct = value + (value * ((_baseRate[baseStat] + _extendRate[baseStat]) * DIVISION));

                _baseRate[stat] += (long)(correct * (correction.Rates[index].Value * DIVISION));
            }

            _updates.Add(stat);
        }

        private bool Update(int index, long value, long rate, bool subtraction = false)
        {
            if (_second > index)
                _baseChange = true;

            if (value > 0)
            {
                if (_second > index)
                {
                    _baseValue[index] = subtraction ? _baseValue[index] - value : _baseValue[index] + value;
                }
                else
                {
                    _extendValue[index] = subtraction ? _extendValue[index] - value : _extendValue[index] + value;
                }
            }

            if (rate > 0)
            {
                _extendRate[index] = subtraction ? _extendRate[index] - rate : _extendRate[index] + rate;
            }

            return true;
        }

        // https://playwith.sharepoint.com/:x:/s/RohanM2Studio/EcSauPpi1LJEjKIi5dZC-_IBbDGQrYtavod5bTne7rnsXg?e=Tkcygy
        private void Update(int index)
        {
             var stat = _percent[index] ?
                CalculateRate(_baseValue[index], _extendValue[index], _baseRate[index], _extendRate[index]) :
                (long)CalculateValue(_baseValue[index], _extendValue[index], _baseRate[index], _extendRate[index]);

            _stat[index] = Math.Clamp(stat, _min[index], _max[index]);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static double CalculateRate(long baseValue, long extendValue, long baseRate, long extendRate)
            => (baseValue + extendValue + baseRate + extendRate) * DIVISION;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static double CalculateValue(long baseValue, long extendValue, long baseRate, long extendRate)
        {
            var sum = baseValue + extendValue;
            return (sum + (sum * ((baseRate + extendRate) * DIVISION))) * DIVISION;
        }

        internal void AllChange()
        {
            for (var index = MIN; index < _length; ++index)
                _updates.Add(index);

            _baseChange = true;
        }
    }
}
