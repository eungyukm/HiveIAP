using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Skills
{
    public class SkillsPacketMeta : IPacketMeta
    {
        public int StartId => 27000;

        public Type[] Types => new[]
        {
            typeof(BuffListInfoV2Req),
            typeof(SkillChangeAutoUseV2Req),
            typeof(SkillChangePresetV2Req),
            typeof(SkillEquipV2Req),
            typeof(SkillHitV2Req),
            typeof(SkillLearnV2Req),
            typeof(SkillLevelUpV2Req),
            typeof(SkillListInfoV2Req),
            typeof(SkillUnEquipV2Req),
            typeof(SkillUpgradeV2Req),
            typeof(SkillUseV2Req),
            typeof(ActorChangeBattleModeV2Noti),
            typeof(BuffListInfoV2Res),
            typeof(SkillChangeAutoUseV2Res),
            typeof(SkillChangePresetV2Res),
            typeof(SkillDotEffectV2Noti),
            typeof(SkillEquipV2Res),
            typeof(SkillHitEffectV2Noti),
            typeof(SkillHitV2Noti),
            typeof(SkillHitV2Res),
            typeof(SkillLearnV2Res),
            typeof(SkillLevelUpV2Res),
            typeof(SkillListInfoV2Res),
            typeof(SkillPreActionEndV2Noti),
            typeof(SkillPresetInfosNoti),
            typeof(SkillUnEquipV2Res),
            typeof(SkillUpgradeV2Res),
            typeof(SkillUseV2Noti),
            typeof(SkillUseV2Res),
            typeof(SkillDotHealEffectV2Noti),

            typeof(RTTSkillUseV2Req),
            typeof(RTTSkillUseV2Res),

            typeof(RTTSkillHitV2Req),
            typeof(RTTSkillHitV2Res),
        };
    }
}