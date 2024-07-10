using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Quests
{
    public class QuestsPacketMeta : IPacketMeta
    {
        public int StartId => 22000;

        public Type[] Types => new[]
        {
            typeof(QuestAbandonV2Req),
            typeof(QuestAcceptV2Req),
            typeof(QuestCompleteV2Req),
            typeof(QuestConditionCompleteV2Req),
            typeof(QuestListV2Req),
            typeof(QuestPortalV2Req),
            typeof(QuestRegisterV2Req),
            typeof(QuestRerollV2Req),
            typeof(QuestRewardV2Req),
            typeof(QuestTalkCompleteV2Req),
            typeof(TutorialSkipV2Req),
            typeof(CheatGetQuestV2Noti),
            typeof(DailyQuestOpenV2Noti),
            typeof(PlayerQuestProgressV2Noti),
            typeof(QuestAbandonV2Res),
            typeof(QuestAcceptV2Res),
            typeof(QuestCompleteV2Res),
            typeof(QuestConditionCompleteV2Res),
            typeof(QuestListV2Res),
            typeof(QuestPortalV2Res),
            typeof(QuestRegisterV2Res),
            typeof(QuestRerollV2Res),
            typeof(QuestResetCheatV2Noti),
            typeof(QuestRewardV2Res),
            typeof(QuestTalkCompleteV2Res),
            typeof(ResetDailyQuestV2Noti),
            typeof(TutorialSkipV2Res),
        };
    }
}