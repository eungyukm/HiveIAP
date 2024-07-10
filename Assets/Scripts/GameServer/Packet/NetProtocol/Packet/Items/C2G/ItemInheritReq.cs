using System.Collections.Generic;

namespace NetProtocol.Packet.C2G
{
    public class ItemInheritReq
    {
        public long TargetItemId = 0;       // 계승 시킬 아이템 고유번호
        public List<int> TargetStatList = new();   // 메인 장비의 선택한 스텟타입
        public long SubItemId = 0;          // 재료가 되는 아이템 고유번호
        public List<int> SubStatList = new();   // 재료 장비의 선택한 스텟타입
        public long StoneItemId = 0;        // 계승석 아이템 고유번호
        
    }
}
