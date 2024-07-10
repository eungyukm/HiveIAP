
using NetProtocol.Models.Event;
using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class EventAttendanceListV2Noti
    {
        public List<EventAttendanceInfo> Events = new();
    }
}
