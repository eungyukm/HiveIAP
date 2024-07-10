using System.Collections.Generic;
using NetProtocol.Models.Actor.Features;

namespace NetProtocol.Models.Zone
{
    public class DZoneOverview
    {
        // 차후 점령에 대한 세부 내용들이 있으면 추가 예정. 세율 등등
        public DGuild OccupyingGuild = new DGuild();
        
        // 블러드 포그가 활성화 되어 있다면 활성화 되어 있는 블러드 포그 아이디
        public List<uint> BloodFogIndexes = new List<uint>();
        
        // 암흑 도약이 활성화 되어 있다면 활성화 되어 있는 암흑 도약 아이디
        // TODO : 네이밍 확인 필요
        public List<uint> DarkPortalIndexes = new List<uint>();
    }
}