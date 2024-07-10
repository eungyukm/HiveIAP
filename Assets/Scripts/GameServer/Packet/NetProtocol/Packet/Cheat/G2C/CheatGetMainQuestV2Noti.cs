using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class CheatGetMainQuestV2Noti
    {
        public ErrorCode Err = ErrorCode.Success;
        public List<QuestInfoV2> QuestList = new();
        public QuestInfoV2 AcceptQuest;
    }
}