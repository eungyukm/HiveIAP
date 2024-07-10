using NetProtocol.Models.Actor;

namespace NetProtocol.Packet.G2C
{
    public class PlayerGameEnterRes
    {
        public ErrorCode Status;
        public DPlayerActor Actor;
        public PlayerAlarmInfo AlarmInfo;
    }
}