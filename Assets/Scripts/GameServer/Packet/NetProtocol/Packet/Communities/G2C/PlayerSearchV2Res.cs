using NetProtocol.Models.Player.Features;

namespace NetProtocol.Packet.G2C
{
    public class PlayerSearchV2Res
    {
        public ErrorCode Error = ErrorCode.Success;
        public PlayerSimpleInfo SimpleInfo;
    }
}