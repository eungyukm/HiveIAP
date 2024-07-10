using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.WeaponAppearances
{
    public class WeaponAppearancesPacketMeta : IPacketMeta
    {
        public int StartId => 30000;

        public Type[] Types => new[]
        {
            typeof(WeaponAppearanceCollectListV2Req),
            typeof(WeaponAppearanceEquipV2Req),
            typeof(WeaponAppearanceExtractFromItemV2Req),
            typeof(WeaponAppearanceHiddenV2Req),
            typeof(WeaponAppearanceListV2Req),
            typeof(WeaponAppearanceUnequipV2Req),
            typeof(WeaponAppearanceCollectListV2Noti),
            typeof(WeaponAppearanceCollectListV2Res),
            typeof(WeaponAppearanceEquipV2Noti),
            typeof(WeaponAppearanceEquipV2Res),
            typeof(WeaponAppearanceExtractFromItemV2Res),
            typeof(WeaponAppearanceGachaV2Res),
            typeof(WeaponAppearanceHiddenV2Noti),
            typeof(WeaponAppearanceHiddenV2Res),
            typeof(WeaponAppearanceListV2Noti),
            typeof(WeaponAppearanceListV2Res),
            typeof(WeaponAppearanceUnequipV2Noti),
            typeof(WeaponAppearanceUnequipV2Res)
        };
    }
}