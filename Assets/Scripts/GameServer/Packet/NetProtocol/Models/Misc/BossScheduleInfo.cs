using System;
using System.Numerics;

namespace NetProtocol.Packet
{
    public class BossScheduleInfo
    {
        public uint BossScheduleIndex = 0;
        public int ServerIndex = 1;

        public uint BossIndex = 0;
        
        public uint MapIndex = 0;
        public Vector3 Position = Vector3.Zero;

        // 로컬 타임 기준
        public long NoticeAt = 0;
        public long SpawnAt = 0;
        public long DeSpawnAt = 0;

        // TimeSpan 스폰 까지 남은 시간
        public long SpawnTimeSpanMilliseconds;
        public long NoticeTimeSpanMilliseconds;
        public long DeSpawnTimeSpanMilliseconds;
    }
}