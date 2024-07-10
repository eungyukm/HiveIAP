using System.Collections.Generic;

namespace NetProtocol.Packet.C2G
{
    public class GuildWarehouseWalletMoveV2Req
    {
        public byte Flag = 0;   // flag 0 : warehouseToInventory / 1 : InventoryToWarehouse
        public WalletType WalletType = WalletType.NONE;
        public long WalletCount = 0;
    }
}