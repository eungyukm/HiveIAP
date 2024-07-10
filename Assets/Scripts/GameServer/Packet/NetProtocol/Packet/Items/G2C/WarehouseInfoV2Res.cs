using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class WarehouseInfoV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public byte PrivateWarehouseExtendCount = 0;       // 확장한 횟수
        public short PrivateWarehouseSize = 0;
        public byte AccountWarehouseExtendCount = 0;       // 확장한 횟수
        public short AccountWarehouseSize = 0;
        public List<ItemV2> PrivateWarehouseItems = new();
        public List<ItemV2> AccountWarehouseItems = new();
        
    }
}