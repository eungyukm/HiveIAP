using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Misc
{
    public class MicsPacketMeta : IPacketMeta
    {
        public int StartId => 17000;

        public Type[] Types => new[]
        {
            typeof(AuthenticatePlayerCredentialReq),
            typeof(BroadCastContextReq),
            typeof(CutSceneEndV2Req),
            typeof(CutSceneStartV2Req),
            typeof(LogOutReq),
            typeof(PortalV2Req),
            typeof(ReturnToLobbyReq),
            typeof(ServerTimeV2Req),
            typeof(TestPacketV2Req),
            typeof(TriggerActivateV2Req),
            typeof(UnionV2Req),
            typeof(ZoneLoadingCompletedReq),
            typeof(AuthenticatePlayerCredentialRes),
            typeof(BindStonesNoti),
            typeof(BroadCastContextNoti),
            typeof(BroadCastContextRes),
            typeof(CutSceneEndV2Res),
            typeof(CutSceneStartV2Res),
            typeof(CutSceneStateV2Noti),
            typeof(DebugPlayerStateV2Noti),
            typeof(LogOutRes),
            null,
            typeof(PortalV2Res),
            typeof(ReturnToLobbyRes),
            typeof(ServerTimeV2Res),
            typeof(SystemMessageV2Noti),
            typeof(TemporalFluxZoneEnterNoti),
            typeof(TemporalFluxZoneExitNoti),
            typeof(TestPacketV2Noti),
            typeof(TestPacketV2Res),
            typeof(TicketInfoV2Noti),
            typeof(TriggerActivateMapMoveV2Noti),
            typeof(TriggerActivateV2Res),
            typeof(UnionV2Res),
            typeof(ZoneLoadingCompletedRes),
            typeof(BossDamagedInfoNoti),
            typeof(BossFirstDamagedNoti),
            typeof(BossKilledNoti),
            typeof(BossKilledRewardNoti),
            typeof(GainMessageNoti),
            typeof(TicketUpdateNoti),
            typeof(BossDamagedInfoReq),
            typeof(BossDamagedInfoRes),
            typeof(WorldBossDamagedInfoNoti),
            typeof(BossTakenDamageOnPlayerKillNoti),
        };
    }
}