namespace NetProtocol.Packet
{
    public enum MailType : byte
    {
        Character = 1, // 일반
        Account, // 계정
        Shop // 상품
    }
}