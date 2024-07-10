using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Items
{
    public class ItemsPacketMeta : IPacketMeta
    {
        public int StartId => 14000;

        public Type[] Types => new[]
        {
            typeof(EquipmentVisibleV2Req),
            typeof(InventoryChangeSizeV2Req),
            typeof(ItemAddOptionV2Req),
            typeof(ItemChangeOptionV2Req),
            typeof(ItemCollectionBookmarksRegisterV2Req),
            typeof(ItemCollectionBookmarksUnregisterV2Req),
            typeof(ItemCollectionRegisterV2Req),
            typeof(ItemCombineV2Req),
            typeof(ItemDeleteV2Req),
            typeof(ItemDisassembleV2Req),
            typeof(ItemEnchantV2Req),
            typeof(ItemEquipV2Req),
            typeof(ItemIntensionV2Req),
            typeof(ItemMixOptionV2Req),
            typeof(ItemPackageUseV2Req),
            typeof(ItemProductionV2Req),
            typeof(ItemSelectUseV2Req),
            typeof(ItemUpgradeV2Req),
            typeof(ItemUseV2Req),
            typeof(PkLootingItemV2Req),
            typeof(PkLootingListV2Req),
            typeof(WarehouseChangeSizeV2Req),
            typeof(WarehouseInfoV2Req),
            typeof(WarehouseItemMoveV2Req),
            typeof(EquipmentVisibleV2Res),
            typeof(InventoryChangeSizeV2Res),
            typeof(ItemAddOptionV2Res),
            typeof(ItemAddV2Noti),
            typeof(ItemChangeOptionV2Res),
            typeof(ItemCollectionBookmarksRegisterV2Res),
            typeof(ItemCollectionBookmarksUnregisterV2Res),
            typeof(ItemCollectionListV2Noti),
            typeof(ItemCollectionRegisterV2Res),
            typeof(ItemCombineV2Res),
            typeof(ItemDeleteV2Noti),
            typeof(ItemDeleteV2Res),
            typeof(ItemDisassembleV2Res),
            typeof(ItemEnchantV2Res),
            typeof(ItemEquipV2Noti),
            typeof(ItemEquipV2Res),
            typeof(ItemIntensionV2Res),
            typeof(ItemMixOptionV2Res),
            typeof(ItemPackageUseV2Res),
            typeof(ItemProductionV2Res),
            typeof(ItemSelectUseV2Res),
            typeof(ItemUpdateV2Noti),
            typeof(ItemUpgradeV2Res),
            typeof(ItemUseV2Res),
            typeof(PkLootingAddV2Noti),
            typeof(PkLootingItemV2Res),
            typeof(PkLootingListV2Res),
            typeof(PkLootingV2Noti),
            typeof(PlayerInventoryExtendInfoNoti),
            typeof(PlayerInventoryInfoV2Noti),
            typeof(WarehouseChangeSizeV2Res),
            typeof(WarehouseInfoV2Res),
            typeof(WarehouseItemMoveV2Res),
            typeof(ItemIntentionSucceedNoti),
            typeof(ItemSetLockReq),
            typeof(ItemSetLockRes),
            typeof(ItemMarketPriceReq),
            typeof(ItemMarketPriceRes),
            typeof(ItemInheritReq),
            typeof(ItemInheritRes),
        };
    }
}