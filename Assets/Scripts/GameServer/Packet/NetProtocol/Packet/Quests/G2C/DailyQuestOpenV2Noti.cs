using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class DailyQuestOpenV2Noti
    {
        public ErrorCode Err = ErrorCode.Success;
        public List<QuestInfoV2> AddedQuests = new();
    }
}