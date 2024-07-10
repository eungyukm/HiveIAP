using System;

namespace NetProtocol.Models.Item
{
    public class ItemMarketPriceInfo
    {
        public DateTime Day = DateTime.MinValue;       // 년월일 값만 사용
        public uint ItemIndex = 0;
        public long PriceSum = 0;                   // 하루 누적 거래 금액
        public long CountSum = 0;                   // 하루 누적 거래 아이템 갯수. 거래량이 많을 수도 있어서 long
        public long LowestPrice = 0;                // 하루중 최저 가격 
        public long HighestPrice = 0;               // 하루중 최고 가격
    }
}
