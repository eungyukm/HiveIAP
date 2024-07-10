using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class ItemUpgradeV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public EquipmentItemV2 TargetItem = new();      // 대상 아이템
        public byte Success = 0;
        public EquipmentItemV2 GetItem = new();        // 결과 아이템
    }
}