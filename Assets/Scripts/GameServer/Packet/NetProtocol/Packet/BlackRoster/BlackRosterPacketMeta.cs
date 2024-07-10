using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet
{
    public class BlackRosterPacketMeta : IPacketMeta
    {
        public int StartId => 4000;

        public Type[] Types => new[]
        {
            typeof(PlayerBlackRosterGetPreferenceReq),
            typeof(PlayerBlackRosterObservingReq),
            typeof(PlayerBlackRosterProvocationReq),
            typeof(PlayerBlackRosterRankReq),
            typeof(PlayerBlackRosterRevengeReq),
            typeof(PlayerBlackRosterSetPreferenceReq),
            typeof(PlayerBlackRostersReq),
            typeof(PlayerBlackRosterGetPreferenceRes),
            typeof(PlayerBlackRosterObservingNoti),
            typeof(PlayerBlackRosterObservingRes),
            typeof(PlayerBlackRosterProvocationNoti),
            typeof(PlayerBlackRosterProvocationRes),
            typeof(PlayerBlackRosterRankRes),
            typeof(PlayerBlackRosterRevengeRes),
            typeof(PlayerBlackRosterSetPreferenceRes),
            typeof(PlayerBlackRostersRes),
            typeof(PlayerBlackRosterLastWeekRankReq),
            typeof(PlayerBlackRosterLastWeekRankRes),
            typeof(PlayerBlackRosterMessageNoti),
        };
    }
}