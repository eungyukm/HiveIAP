using System.Collections.Generic;
using NetProtocol.Packet;

namespace NetProtocol.Models.Guild
{
    // 길드 관계 필요 정보
    public class GuildView
    {
        public long Id = 0;
        public string Name = string.Empty;
        public byte CrestImage = 0;
        public byte CrestFrame = 0;
        public uint Level = 0;
        public string Master = string.Empty;
    }
}