using System.Collections.Generic;

namespace NetProtocol.Packet.C2G
{
    public class WarehouseItemMoveV2Req
    {
        public WarehouseType Type = WarehouseType.none;
        public byte Flag = 0;   // flag 0 : warehouseToInventory / 1 : InventoryToWarehouse
        public Dictionary<long/*ItemId*/, int/*Count*/> Items = new();
    }
}