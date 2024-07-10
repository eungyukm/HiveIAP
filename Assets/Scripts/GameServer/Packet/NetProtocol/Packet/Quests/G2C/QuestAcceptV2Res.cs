using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class QuestAcceptV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public QuestInfoV2 QuestInfo = null;
        public int AcceptedDailyQuestCount = 0;
    }
}