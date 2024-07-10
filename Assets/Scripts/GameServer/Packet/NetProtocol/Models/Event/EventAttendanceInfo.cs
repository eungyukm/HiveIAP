

using System;
using System.Collections.Generic;

namespace NetProtocol.Models.Event
{
    public class EventAttendanceUnit      // 출석 하루에 대한 정보
    {
        public uint EventIndex = 0;
        public uint day = 0;
        public bool IsAttendance = false;
        public bool IsReward = false;
    }

    public class EventAttendanceInfo      // 출석 이벤트 하나에 대한 정보
    {
        public uint EventIndex = 0;
        //public uint TotalAttendanceDay = 0;         // Attendances.Count
        //public long LastAttendanceTime = 0;             // 마지막 출석한 시간
        public List<EventAttendanceUnit> Attendances = new();
    }
}
