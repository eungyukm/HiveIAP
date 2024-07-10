using NetProtocol.Models.Trade;
using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class TradePersonalHistoryRes
    {
        public ErrorCode Err = ErrorCode.Success;
        public List<TradePersonalHistoryInfo> TradeHistorys = new();       // 거래 리스트
    }
}
