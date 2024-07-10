namespace NetProtocol.Packet
{
    public enum MailSubType : byte
    {
        Normal = 1,
        Management, // 운영
        Reward, // 보상
        Event, // 이벤트
        Etc, // 기타
    }
}