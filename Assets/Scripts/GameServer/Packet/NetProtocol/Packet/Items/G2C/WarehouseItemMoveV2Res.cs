using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class WarehouseItemMoveV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public WarehouseType Type = WarehouseType.none;
        public byte Flag = 0;       // flag 0 : warehouseToInventory / 1 : InventoryToWarehouse
        public List<ItemV2> WarehouseAddItems = new();
        public List<ItemV2> WarehouseSetItems = new();
        public List<long> WarehouseDelItemIds = new();
    }
}