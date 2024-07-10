using NetProtocol.Models.Trade;
using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class TradeItemSearchCategoryRes
    {
        public ErrorCode Err = ErrorCode.Success;
        public int MainCategory = 0;
        public int SubCategory = 0;
        public List<TradeItemCategoryData> TradeCategorys = new();
    }
}
