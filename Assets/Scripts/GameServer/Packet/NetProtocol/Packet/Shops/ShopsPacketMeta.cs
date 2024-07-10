using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Shops
{
    public class ShopsPacketMeta : IPacketMeta
    {
        public int StartId => 25000;

        public Type[] Types => new[]
        {
            typeof(BuyCashShopItemV2Req),
            typeof(BuyGameShopItemV2Req),
            typeof(GameShopSellItemV2Req),
            typeof(BuyCashShopItemV2Res),
            typeof(BuyGameShopItemV2Res),
            typeof(GameShopSellItemV2Res),
            typeof(ShopBuyCountListNoti)
        };
    }
}