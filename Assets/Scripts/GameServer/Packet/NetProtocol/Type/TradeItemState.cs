namespace NetProtocol.Packet
{
    // 아이템 거래소 상태값
    public enum TradeItemState
    {
        NONE = 0,
        TradeWait = 1,              // 거래 등록 대기중 (취소 가능)
        Trade = 2,                  // 판매중 (구매 가능, 취소 불가)
        Accept = 3,                 // 개인거래 수락함.(정산 가능)
        TimeOut = 4,                // 기간만료, (회수 가능)
    }
}
