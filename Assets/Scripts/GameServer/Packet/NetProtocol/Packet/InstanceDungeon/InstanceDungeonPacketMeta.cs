using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.InstanceDungeon
{
    public class InstanceDungeonPacketMeta : IPacketMeta
    {
        public int StartId => 12000;

        public Type[] Types => new[]
        {
            typeof(DungeonEnterV2Req),
            typeof(DungeonGiveUpV2Req),
            typeof(DungeonLeaveV2Req),
            typeof(DungeonLoadingCompleteV2Req),
            typeof(DungeonClearHistoryV2Noti),
            typeof(DungeonClearV2Noti),
            typeof(DungeonCronUpdateV2Noti),
            typeof(DungeonEnterV2Res),
            typeof(DungeonExpUpdateV2Noti),
            typeof(DungeonGiveUpV2Res),
            typeof(DungeonLeaveV2Res),
            typeof(DungeonLoadingCompleteAllV2Noti),
            typeof(DungeonLoadingCompleteV2Res),
            typeof(ExpDungeonClearNoti),
            typeof(EquipDungeonClearNoti),
            typeof(MineralDungeonClearNoti),
            typeof(PartyDungeonClearNoti),
        };
    }
}