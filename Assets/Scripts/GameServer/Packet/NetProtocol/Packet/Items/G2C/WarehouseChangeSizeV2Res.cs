using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class WarehouseChangeSizeV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public WarehouseType Type = WarehouseType.none;
        public short Size = 0;
        public byte ExtendCount = 0;
    }
}