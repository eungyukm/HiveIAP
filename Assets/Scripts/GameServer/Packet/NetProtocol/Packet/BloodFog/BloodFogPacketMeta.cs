using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Guilds
{
    public class BloodFogPacketMeta : IPacketMeta
    {
        public int StartId => 42000;

        public Type[] Types => new[]
        {
            typeof(BloodFogEnterReq),
            typeof(BloodFogEnterRes),
            typeof(BloodFogLeaveReq),
            typeof(BloodFogLeaveRes),
            typeof(BloodFogUseBuffReq),
            typeof(BloodFogUseBuffRes),
            typeof(BloodFogChangeWaveNoti),
            typeof(BloodFogEventNoti),
            typeof(BloodFogKickoutNoti),
            typeof(BloodFogPlayerDeathNoti),
            typeof(BloodFogPlayerPointUpdateNoti),
            typeof(BloodFogPlayerRankUpdateNoti),
            typeof(BloodFogResultNoti),
        };
    }
}