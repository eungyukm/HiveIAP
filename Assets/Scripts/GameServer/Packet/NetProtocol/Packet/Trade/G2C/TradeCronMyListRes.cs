using System.Collections.Generic;
using NetProtocol.Models.Trade;

namespace NetProtocol.Packet.G2C
{
    public class TradeCronMyListRes
    {
        public ErrorCode Status = ErrorCode.Success;

        public List<TradeCronMyInfo> Infos = new List<TradeCronMyInfo>();
    }
}