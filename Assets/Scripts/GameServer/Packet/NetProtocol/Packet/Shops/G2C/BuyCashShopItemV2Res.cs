using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class BuyCashShopItemV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public ShopInfo CashShopInfo;
    }
}