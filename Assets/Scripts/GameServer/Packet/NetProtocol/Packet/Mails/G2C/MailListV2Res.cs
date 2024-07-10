using System;
using NetProtocol.Models.Mail;

namespace NetProtocol.Packet.G2C
{
    public class MailListV2Res
    {
        public ErrorCode Err = ErrorCode.Success;

        public int Type = 0;
        public int Page = 0;
        public int TotalCount = 0;

        public MailInfoV2[] Mails = Array.Empty<MailInfoV2>();
    }
}