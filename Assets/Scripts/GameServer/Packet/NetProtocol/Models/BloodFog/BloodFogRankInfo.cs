namespace NetProtocol.Models.BloodFog
{
    public class BloodFogRankInfo
    {
        public long ActorId = 0;
        public string Name = string.Empty;

        public int Kill = 0;
        public int Death = 0;
        public int ChainKill = 0;

        public int BloodFogGrade = 0;

        public int TotalAcquireStableSerum = 0;
        public int UseUnstableSerum = 0;

        public int AcquireStableSerum = 0;
    }
}