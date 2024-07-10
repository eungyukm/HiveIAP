using System.Collections.Generic;
using NetProtocol.Models.Trade;

namespace NetProtocol.Packet.G2C
{
    public class TradeCronInfoRes
    {
        public ErrorCode Status = ErrorCode.Success;
        
        // 크론 시세
        public int Balance = 0;
        
        // 남은 시간
        public long TimeSpanTicks = 0;

        // 등록된 목록
        public List<TradeCronInfo> Infos = new List<TradeCronInfo>();
        
        // 전날 시세
        public List<CronBalanceInfo> PreviousDayBalanceInfos = new List<CronBalanceInfo>();
        
        // 일주일 시세
        public List<CronBalanceInfo> WeeklyBalanceInfos = new List<CronBalanceInfo>();
    }
}