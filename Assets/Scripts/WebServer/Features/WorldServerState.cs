namespace RM2.Server.Common.Features
{
    public class WorldServerState
    {
        // 신규 서버
        public bool IsNew { get; set; }
        // 추천 서버
        public bool IsPreferred { get; set; }
        // 생성 제한
        public bool IsRestricted { get; set; }
    
        public WorldStatus Status { get; set; } = WorldStatus.Maintenance;
        public WorldTraffic Traffic { get; set; } = WorldTraffic.Empty;
        public WorldOperate Operate { get; set; } = WorldOperate.Local;
    
        public enum WorldStatus
        {
            Closed = 0,         // 닫힘
            Open = 1,           // 열림
            Pending = 2,        // 보류 중
            Maintenance = 3,    // 점검 중
        }
    
        public enum WorldTraffic
        {
            Empty = 0,
            Smooth = 1,         // 원활
            Moderate = 2,       // 보통
            Congested = 3,      // 혼잡
        }
    
        public enum WorldOperate
        {
            Local,
            Dev,
        }
    
        public static WorldServerState ToWorldServerState(
            bool isNew,
            bool isPreferred,
            bool isRestricted,
            WorldStatus status,
            WorldTraffic traffic,
            WorldOperate operate)
        {
            return new WorldServerState()
            {
                IsNew = isNew,
                IsPreferred = isPreferred,
                IsRestricted = isRestricted,
                Status = status,
                Traffic = traffic,
                Operate = operate,
            };
        }
    }
}
