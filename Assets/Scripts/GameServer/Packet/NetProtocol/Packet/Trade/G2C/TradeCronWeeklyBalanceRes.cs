using System.Collections.Generic;
using NetProtocol.Models.Trade;

namespace NetProtocol.Packet.G2C
{
    public class TradeCronWeeklyBalanceRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public List<CronBalanceInfo> Infos = new List<CronBalanceInfo>();
    }
}