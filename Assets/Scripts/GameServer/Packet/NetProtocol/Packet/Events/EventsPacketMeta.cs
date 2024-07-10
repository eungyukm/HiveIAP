using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Events
{
    public class EventsPacketMeta : IPacketMeta
    {
        public int StartId => 10000;

        public Type[] Types => new[]
        {
            typeof(AttainmentDailyRewardV2Req),
            typeof(AttainmentNormalRewardV2Req),
            typeof(AttendanceRewardV2Req),
            typeof(BossScheduleReq),
            typeof(EventExchangeRewardV2Req),
            typeof(AttainmentDailyRewardV2Res),
            typeof(AttainmentNormalRewardV2Res),
            typeof(AttainmentProgressV2Noti),
            typeof(AttainmentsNoti),
            typeof(AttendanceRewardV2Res),
            typeof(BossScheduleNoti),
            typeof(BossScheduleRes),
            typeof(EventAttendanceListV2Noti),
            typeof(EventExchangeRewardV2Res)
        };
    }
}