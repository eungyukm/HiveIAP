namespace NetProtocol.Models.Stat
{
    public class StatData
    {
        public int StatType = 0;
        public long Value = 0;
        public long Per = 0;

        public StatData(int statType, long value, long per)
        {
            StatType = statType;
            Value = value;
            Per = per;
        }

        public StatData()
        {
            StatType = 0;
            Value = 0;
            Per = 0;
        }
    }
}
