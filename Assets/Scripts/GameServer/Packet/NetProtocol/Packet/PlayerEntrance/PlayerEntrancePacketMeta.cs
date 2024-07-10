using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetProtocol.Packet.PlayerEntrance
{
    public class PlayerEntrancePacketMeta : IPacketMeta
    {
        public int StartId => 1000;

        public Type[] Types => new[]
        {
            typeof(PlayerSelectReq),
            
            typeof(PlayerEnterStageFirstReq),
            typeof(PlayerEnterStageSecondReq),
            typeof(PlayerEnterStageThirdReq),
            typeof(PlayerEnterStageFourthReq),
            typeof(PlayerEnterStageFifthReq),
            
            typeof(PlayerGameEnterReq),
            
            typeof(PlayerSelectRes),
          
            typeof(PlayerEnterStageFirstRes),
            typeof(PlayerEnterStageSecondRes),
            typeof(PlayerEnterStageThirdRes),
            typeof(PlayerEnterStageFourthRes),
            typeof(PlayerEnterStageFifthRes),

            typeof(PlayerGameEnterRes),

            typeof(AuthenticateBotCredentialReq),
            typeof(AuthenticateBotCredentialRes),
        };
    }
}
