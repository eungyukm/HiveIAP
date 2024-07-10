using System.Collections.Generic;
using NetProtocol.Models.Trade;

namespace NetProtocol.Packet.G2C
{
    public class TradeCronListRes
    {
        public ErrorCode Status = ErrorCode.Success;

        public List<TradeCronInfo> Infos = new List<TradeCronInfo>();
    }
}