using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class QuestRerollV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public int RerollCount = 0;
        public List<QuestInfoV2> AddedDailyQuests = new();
        public List<QuestInfoV2> DeletedDailyQuests = new();
    }
}