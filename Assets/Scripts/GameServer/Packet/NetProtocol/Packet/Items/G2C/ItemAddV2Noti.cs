using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class ItemAddV2Noti
    {
        public ErrorCode Err = ErrorCode.Success;
        
        public List<ItemV2> Items = new();

        public Trace From = Trace.None;          // 어느 컨텐츠에서 사용 했는지 정보
    }
}