using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class WeaponAppearanceExtractFromItemV2Res
    {
        public ErrorCode Err;
        public uint[] ItemCollects; // 전체 무기 외형 컬렉션
        public List<WeaponAppearanceInfo> WeaponAppearances;    // 전체 외형 추출 성공 목록
        public List<ItemV2> InvenSetItems;    // 이번 추출 시도로 인한 인벤토리 갱신 내용
        public uint[] ExtractItems;         // 이번 추출 시도로 인한 신규 추출 목록
        
    }
}