
using NetProtocol.Packet;

namespace NetProtocol.Models.etc
{
    public class GainMessageInfo
    {
        public WhereType WhereType = WhereType.None;           // 어디서 타입 (맵, 아이템)
        public int Where = 0;               // 어디서
        public string Who = string.Empty;   // 누가
        public WhatType WhatType = WhatType.None;            // 무엇을 타입 아이템, 펫, 탈것
        public int What = 0;                // 무엇을
    }
}
