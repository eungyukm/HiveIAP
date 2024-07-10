using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class BossScheduleRes
    {
        public ErrorCode Status = ErrorCode.Success;
        
        public List<BossScheduleInfo> Infos = new List<BossScheduleInfo>();
    }
}