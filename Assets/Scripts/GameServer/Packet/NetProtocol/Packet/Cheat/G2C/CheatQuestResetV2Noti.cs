using System;

namespace NetProtocol.Packet.G2C
{
    public class CheatQuestResetV2Noti
    {
        public ErrorCode Err = ErrorCode.Success;
        public QuestInfoV2[] Quests = Array.Empty<QuestInfoV2>();
        
    }
}