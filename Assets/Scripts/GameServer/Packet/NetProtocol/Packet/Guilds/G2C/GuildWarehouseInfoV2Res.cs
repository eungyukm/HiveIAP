using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class GuildWarehouseInfoV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public byte GuildWarehouseExtendCount = 0;       // 확장한 횟수
        public short GuildWarehouseSize = 0;
        public List<ItemV2> GuildWarehouseItems = new();
    }
}