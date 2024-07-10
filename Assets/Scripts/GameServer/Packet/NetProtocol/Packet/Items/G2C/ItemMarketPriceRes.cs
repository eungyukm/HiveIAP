using NetProtocol.Models.Item;
using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class ItemMarketPriceRes
    {
        public ErrorCode Err = ErrorCode.Success;
        public List<ItemMarketPriceInfo> Infos = new();     // 요청 시간 기준 30일치
    }
}
