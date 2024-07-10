using System.Collections.Generic;
using NetProtocol.Models.Item.Features;

namespace NetProtocol.Packet.G2C
{
    public class ItemProductionV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public byte SuccessCount = 0;       // 성공 횟수
        public byte GreatSuccessCount = 0;  // 대성공 횟수
        public byte FailCount = 0;          // 실패 횟수
        public List<SimpleItem> GainItems = new();
    }
}