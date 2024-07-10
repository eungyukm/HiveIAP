namespace NetProtocol.Packet
{
    public enum TradePersonalState
    {
        NONE = 0,
        Request = 1,                // 개인거래 요청중
        Accept = 2,                 // 개인거래 수락함.(요청자는 거래 대금 수령 가능)
        Refuse = 3,                 // 기간만료, 거절됨.(요청자는 거래 물품 수령 가능)
        Finish = 4,                 // 개인거래 완료.
    }
}
