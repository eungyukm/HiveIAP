namespace NetProtocol.Packet.G2C
{
    public class TestPacketV2Res
    {
        public byte IsEcho;
        public byte[] SendMessage;

        public long ElapsedTimeMs;
        public long F2GStartTimeMs;
        public long GameLogicTimeMs;

        public long FrontCpu;
        public long FrontMem;
        public long FrontGcCount1;
        public long FrontGcCount0;
        public long FrontGcCount2;
        public long FrontHandleCount;
        public long FrontThreadCount;

        public long GameCpu;
        public long GameMem;
        public long GameGcCount0;
        public long GameGcCount1;
        public long GameGcCount2;
        public long GameHandleCount;
        public long GameThreadCount;
        
    }
}