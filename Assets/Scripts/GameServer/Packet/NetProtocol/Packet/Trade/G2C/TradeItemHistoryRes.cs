using NetProtocol.Models.Trade;
using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class TradeItemHistoryRes
    {
        public ErrorCode Err = ErrorCode.Success;
        public List<TradeItemHistoryInfo> TradeHistorys = new();       // 거래 리스트
    }
}
