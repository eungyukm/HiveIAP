using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Matching
{
    public class MatchingPacketMeta : IPacketMeta
    {
        public int StartId => 16000;

        public Type[] Types => new[]
        {
            typeof(MatchingApplyReq),
            typeof(MatchingCancelReq),
            typeof(MatchingReplyReq),
            typeof(MatchingApplyRes),
            typeof(MatchingCancelRes),
            typeof(MatchingCompleteNoti),
            typeof(MatchingIncompleteNoti),
            typeof(MatchingMatchedNoti),
            typeof(MatchingRejectReplyNoti),
            typeof(MatchingReplyNoti),
            typeof(MatchingReplyRes)
        };
    }
}