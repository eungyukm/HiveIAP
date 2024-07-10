using System.Collections.Generic;
using NetProtocol.Models.Trade;

namespace NetProtocol.Packet.G2C
{
    public class TradeCronTradesRes
    {
        public ErrorCode Status = ErrorCode.Success;

        public List<TradeCronTradeInfo> Infos = new List<TradeCronTradeInfo>();
    }
}