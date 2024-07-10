using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Rides
{
    public class RidePacketMeta : IPacketMeta
    {
        public int StartId => 24000;

        public Type[] Types => new[]
        {
            typeof(RideAttachDeleteV2Req),
            typeof(RideAttachDisassembleV2Req),
            typeof(RideAttachEquipOffV2Req),
            typeof(RideAttachEquipV2Req),
            typeof(RideAttachGachaV2Req),
            typeof(RideAttachInvenExtendV2Req),
            typeof(RideEquipOffV2Req),
            typeof(RideEquipV2Req),
            typeof(RideGachaV2Req),
            typeof(RideMixV2Req),
            typeof(RideSitOffV2Req),
            typeof(RideSitV2Req),
            typeof(RideAttachDeleteV2Res),
            typeof(RideAttachDisassembleV2Res),
            typeof(RideAttachEquipOffV2Noti),
            typeof(RideAttachEquipOffV2Res),
            typeof(RideAttachEquipV2Noti),
            typeof(RideAttachEquipV2Res),
            typeof(RideAttachGachaV2Res),
            typeof(RideAttachInvenExtendV2Res),
            typeof(RideCollectInfosNoti),
            typeof(RideEquipOffV2Res),
            typeof(RideEquipV2Res),
            typeof(RideGachaV2Res),
            typeof(RideInfosNoti),
            typeof(RideMixV2Res),
            typeof(RideSitOffV2Noti),
            typeof(RideSitOffV2Res),
            typeof(RideSitV2Noti),
            typeof(RideSitV2Res),
        };
    }
}