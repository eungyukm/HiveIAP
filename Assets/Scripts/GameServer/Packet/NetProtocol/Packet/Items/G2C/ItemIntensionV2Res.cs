using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class ItemIntensionV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public int Result = 0;                // 강화 변동 수치( 0보다 크면 성공)  
        public EquipmentItemV2 TargetItem = new();      // 대상 아이템
    }
}