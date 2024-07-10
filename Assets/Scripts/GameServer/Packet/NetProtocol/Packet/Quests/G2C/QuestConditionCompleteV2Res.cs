using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class QuestConditionCompleteV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public QuestInfoV2 Quest = null;

    }
}