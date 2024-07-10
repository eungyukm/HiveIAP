namespace NetProtocol.Packet.G2C
{
    public class TitleListV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public TitleConditionInfo[] TitleConditionInfoList;
    }
}
