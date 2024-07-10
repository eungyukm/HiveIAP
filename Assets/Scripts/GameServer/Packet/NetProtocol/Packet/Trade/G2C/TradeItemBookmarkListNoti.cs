using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class TradeItemBookmarkListNoti
    {
        public List<uint/*ItemIndex*/> BookmarkList = new();
    }
}
