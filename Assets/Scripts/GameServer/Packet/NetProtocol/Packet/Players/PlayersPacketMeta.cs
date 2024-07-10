using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Players
{
    public class PlayersPacketMeta : IPacketMeta
    {
        public int StartId => 21000;

        public Type[] Types => new[]
        {
            null,
            typeof(PlayerDeleteReq),
            typeof(PlayerGetMacroReq),
            typeof(PlayerMapMoveV2Req),
            typeof(PlayerMoveV2Req),
            typeof(PlayerMoveZoneV2Req),
            typeof(PlayerResurrectionV2Req),

            typeof(PlayerSetMacroReq),
            typeof(PlayerSlotChangeV2Req),
            typeof(PlayerStatPointChangeV2Req),
            typeof(PlayerStatPointInitV2Req),
            typeof(PlayerStatV2Req),
            typeof(PlayerCrimeV2Noti),
            typeof(PlayerDeleteRes),
            typeof(PlayerEventV2Noti),
            typeof(PlayerExpChangeV2Noti),
            typeof(PlayerGetMacroRes),
            typeof(PlayerLootingV2Noti),
            typeof(PlayerMapMoveV2Res),
            typeof(PlayerMoveV2Noti),
            typeof(PlayerMoveV2Res),
            typeof(PlayerTendencyNoti),
            typeof(PlayerPvpValueNoti),
            typeof(PlayerResurrectionV2Noti),
            typeof(PlayerResurrectionV2Res),

            typeof(PlayerSetMacroRes),
            typeof(PlayerStatChangeV2Noti),
            typeof(PlayerStatPointChangeV2Noti),
            typeof(PlayerStatPointChangeV2Res),
            typeof(PlayerStatPointInitV2Res),
            typeof(PlayerStatV2Res),
            typeof(PlayerWalletUpdateV2Noti),
            typeof(PlayerWalletV2Noti),
            typeof(PlayerWantedV2Noti),
            typeof(PlayerDeathInfoReq),
            typeof(PlayerDeathInfoRes),
            
            typeof(RecoverPlayerExpReq),
            typeof(RecoverPlayerExpRes),
            
            typeof(PlayerCombatCapabilityNoti),

            typeof(PlayerClassUpV2Req),
            typeof(PlayerClassUpV2Res),

            typeof(QuickslotSetReq),
            typeof(QuickslotSetRes),
            typeof(QuickslotListNoti),

            typeof(MembershipAddNoti),
            typeof(MembershipUpdateNoti),
            typeof(MembershipListNoti),

            typeof(PlayerExpRecoveryPopupReq),
            typeof(PlayerExpRecoveryPopupRes),

            typeof(RTTPlayerMoveV2Req),
            typeof(RTTPlayerMoveV2Res),
        };
    }
}