using NetProtocol.Models.Account;

namespace NetProtocol.Packet.C2G
{
    public class TradePersonalRequestReq
    {
        public AccountSummary Target = new();
        public long ItemId = 0;
        public int Count = 0;
        public long Price = 0;
    }
}
