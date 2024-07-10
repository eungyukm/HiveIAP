using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class ItemCombineV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public EquipmentItemV2 TargetItem = new();      // 대상 아이템
        public byte Success = 0;            // 조합 성공 여부(0:실패, 1: 성공)
        public uint GetItemIndex = 0;        // 조합 결과
    }
}