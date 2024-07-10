using System.Collections.Generic;
using NetProtocol.Models.Item.Features;

namespace NetProtocol.Packet.C2G
{
    public class ChatMessageV2Req
    {
        public byte Type = 2;
        public long TargetId = 0;
        public string TargetName = string.Empty;
        public string Message = string.Empty;

        public List<ChatLinkItemInfo> LinkItems = new List<ChatLinkItemInfo>();
    }
}
