using System;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class QuestRewardV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public uint QuestId = 0;
    }
}