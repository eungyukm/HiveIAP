using System;
using NetProtocol.Models.Item.Features;

namespace NetProtocol.Packet.G2C
{
    public class MailReadAllV2Res
    {
        public ErrorCode Err = ErrorCode.Success;

        public int Type = 0;

        public long[] MailIds = Array.Empty<long>();
        public SimpleItem[] Items = Array.Empty<SimpleItem>();
    }
}