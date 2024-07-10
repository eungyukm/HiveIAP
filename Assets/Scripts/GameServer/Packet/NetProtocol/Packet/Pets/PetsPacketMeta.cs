using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Pets
{
    public class PetsPacketMeta : IPacketMeta
    {
        public int StartId => 19000;

        public Type[] Types => new[]
        {
            typeof(PetCollectInfoV2Req),
            typeof(PetEquipOffV2Req),
            typeof(PetEquipV2Req),
            typeof(PetFeedUseV2Req),
            typeof(PetGachaV2Req),
            typeof(PetInfoV2Req),
            typeof(PetMixV2Req),
            typeof(PetUpgradeV2Req),
            typeof(PetCollectInfoV2Res),
            typeof(PetEquipOffV2Noti),
            typeof(PetEquipOffV2Res),
            typeof(PetEquipV2Noti),
            typeof(PetEquipV2Res),
            typeof(PetFeedUseV2Res),
            typeof(PetGachaV2Res),
            typeof(PetInfoV2Res),
            typeof(PetMixV2Res),
            typeof(PetUpgradeV2Res),
            typeof(PetInActiveBuffReq),
            typeof(PetInActiveBuffRes),
        };
    }
}