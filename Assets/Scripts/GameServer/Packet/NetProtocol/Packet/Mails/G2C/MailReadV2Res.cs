using System;
using NetProtocol.Models.Item.Features;

namespace NetProtocol.Packet.G2C
{
    public class MailReadV2Res
    {
        public ErrorCode Err = ErrorCode.Success;

        public int Type = 0;

        public long MailId = 0;
        public SimpleItem[] Items = Array.Empty<SimpleItem>();
    }
}