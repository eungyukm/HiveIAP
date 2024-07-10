using System.Collections.Generic;
using NetProtocol.Models.Item.Features;

namespace NetProtocol.Packet.G2C
{
    public class ChatMessageV2Noti
    {
        public byte Type = 2;    //CHAT_TYPE.CT_LOCAL;
        public long AccountId = 0;
        public long ActorId = 0;
        public string SourceName = string.Empty;
        public string Message = string.Empty;
        
        public List<ChatLinkItemInfo> LinkItems = new List<ChatLinkItemInfo>();
    }
}