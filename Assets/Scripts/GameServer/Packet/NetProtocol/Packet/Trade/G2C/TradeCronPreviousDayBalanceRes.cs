using System.Collections.Generic;
using NetProtocol.Models.Trade;

namespace NetProtocol.Packet.G2C
{
    public class TradeCronPreviousDayBalanceRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public List<CronBalanceInfo> Infos = new List<CronBalanceInfo>();
    }
}