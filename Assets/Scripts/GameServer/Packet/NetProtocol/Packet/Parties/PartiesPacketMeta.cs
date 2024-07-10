using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Parties
{
    public class PartiesPacketMeta : IPacketMeta
    {
        public int StartId => 18000;

        public Type[] Types => new[]
        {
            typeof(PartyChangeLootingReq),
            typeof(PartyCreateReq),
            typeof(PartyDisbandReq),
            typeof(PartyDungeonEntranceInquiryReq),
            typeof(PartyEnterDungeonReplyReq),
            typeof(PartyEnterDungeonReq),
            typeof(PartyInfoReq),
            typeof(PartyInviteReplyReq),
            typeof(PartyInviteReq),
            typeof(PartyLeaderChangeReq),
            typeof(PartyLeaveReq),
            typeof(PartyMemberKickReq),
            typeof(PartySuggestionPlayersReq),
            typeof(PartyChangeLootingNoti),
            typeof(PartyChangeLootingRes),
            typeof(PartyCreateRes),
            typeof(PartyDisbandNoti),
            typeof(PartyDisbandRes),
            typeof(PartyDungeonEntranceInquiryRes),
            typeof(PartyEnterDungeonCanceledNoti),
            typeof(PartyEnterDungeonNoti),
            typeof(PartyEnterDungeonReplyNoti),
            typeof(PartyEnterDungeonReplyRes),
            typeof(PartyEnterDungeonRes),
            typeof(PartyEnterNoti),
            typeof(PartyInfoNoti),
            typeof(PartyInfoRes),
            typeof(PartyInviteNoti),
            typeof(PartyInviteReplyNoti),
            typeof(PartyInviteReplyRes),
            typeof(PartyInviteRes),
            typeof(PartyKickedNoti),
            typeof(PartyLeaderChangeNoti),
            typeof(PartyLeaderChangeRes),
            typeof(PartyLeaveNoti),
            typeof(PartyLeaveRes),
            typeof(PartyMemberKickNoti),
            typeof(PartyMemberKickRes),
            typeof(PartyMemberUpdateNoti),
            typeof(PartySuggestionPlayersRes),
            typeof(PartyEnterDungeonCanceledReq),
            typeof(PartyEnterDungeonCanceledRes),
        };
    }
}