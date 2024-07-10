using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class GuildWarehouseWalletMoveV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public byte Flag = 0;   // flag 0 : warehouseToInventory / 1 : InventoryToWarehouse
        public WalletType GuildWalletType = WalletType.NONE;
        public long GuildWalletCountNow = 0;
    }
}