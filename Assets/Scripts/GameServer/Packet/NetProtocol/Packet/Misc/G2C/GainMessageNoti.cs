using NetProtocol.Models.etc;

namespace NetProtocol.Packet.G2C
{
    public class GainMessageNoti
    {
        public int MessageType = 0;     // 메세지 노출 타입?
        public GainMessageInfo Message = new();
    }
}
