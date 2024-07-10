namespace NetProtocol.Packet.G2C
{
    public class TradeItemBookmarkDeleteRes
    {
        public ErrorCode Err = ErrorCode.Success;
        public uint ItemIndex = 0;      // 요청한 아이템인덱스
    }
}
