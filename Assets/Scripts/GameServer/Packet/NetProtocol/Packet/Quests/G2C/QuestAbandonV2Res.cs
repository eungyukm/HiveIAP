namespace NetProtocol.Packet.G2C
{
    public class QuestAbandonV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public uint QuestId;
        public int AcceptedDailyQuestCount = 0;
    }
}