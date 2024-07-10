using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class PlayerBlackRostersRes
    {
        public ErrorCode Status = ErrorCode.Success;
        
        public List<BlackRosterKillInfo> Kills = new List<BlackRosterKillInfo>();
        public List<BlackRosterDeathInfo> Deaths = new List<BlackRosterDeathInfo>();

        public int PVPValue;
    }
}