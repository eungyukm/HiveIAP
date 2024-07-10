using System.Collections.Generic;
using NetProtocol.Models.Item.Features;

namespace NetProtocol.Packet.G2C
{
    public class ItemDisassembleV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public List<SimpleItem> resultItems = new();
    }
}