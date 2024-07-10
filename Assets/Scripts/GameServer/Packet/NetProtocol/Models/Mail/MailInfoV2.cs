using System;
using NetProtocol.Models.Item.Features;

namespace NetProtocol.Models.Mail
{
    public class MailInfoV2
    {
        public long Id = 0;

        public int Type = 0;
        public int SubType = 0;

        public string Title = string.Empty;
        public string Body = string.Empty;
        public SimpleItem[] Items = Array.Empty<SimpleItem>();

        public long ExpiredAt = 0; // unix timestamp
        public long CreatedAt = 0; // unix timestamp
    }
}