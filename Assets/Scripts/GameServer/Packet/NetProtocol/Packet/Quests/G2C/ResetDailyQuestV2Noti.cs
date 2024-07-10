using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class ResetDailyQuestV2Noti
    {
        public ErrorCode Err = ErrorCode.Success;
        public List<uint> DeletedQuestIds = new();
        public List<QuestInfoV2> AddedQuests = new();
        public int AcceptedCount = 0;
    }
}