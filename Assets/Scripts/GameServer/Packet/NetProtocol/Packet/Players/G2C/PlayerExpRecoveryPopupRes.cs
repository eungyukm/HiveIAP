using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class PlayerExpRecoveryPopupRes
    {
        public ErrorCode Status = ErrorCode.Success;

        public int DailyRecoveryCount = 0;
        public List<PlayerExpRecoveryInfo> ExpRecoveryHistory = 
            new List<PlayerExpRecoveryInfo>();
    }
}
