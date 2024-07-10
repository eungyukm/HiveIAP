using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Mails
{
    public class MailsPacketMeta : IPacketMeta
    {
        public int StartId => 15000;

        public Type[] Types => new[]
        {
            typeof(MailListV2Req),
            typeof(MailReadAllV2Req),
            typeof(MailReadV2Req),
            typeof(MailListV2Res),
            typeof(MailReadAllV2Res),
            typeof(MailReadV2Res)
        };
    }
}