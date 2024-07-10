using NetProtocol.Models.Player;

namespace NetProtocol.Packet.G2C
{
    public class QuickslotSetRes
    {
        public ErrorCode Err = ErrorCode.Success;
        public QuickslotInfo QuickslotInfo = new();
    }
}
