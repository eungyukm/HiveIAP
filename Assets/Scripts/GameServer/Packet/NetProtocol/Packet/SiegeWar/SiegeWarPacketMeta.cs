using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.SiegeWar
{
    public class SiegeWarPacketMeta : IPacketMeta
    {
        public int StartId => 26000;

        public Type[] Types => new[]
        {
            typeof(ChangeSiegeModeV2Req),
            typeof(ChoiceSiegeWarFactionV2Req),
            typeof(GetSiegeWarInfoV2Req),
            typeof(GetSiegeWarMatchInfoV2Req),
            typeof(ChangedSiegeWarMatchInfoV2Noti),
            typeof(ChangeSiegeModeV2Res),
            typeof(ChangeSiegeWarInfoV2Noti),
            typeof(ChangeSiegeWarObjectInfoV2Noti),
            typeof(ChoiceSiegeWarFactionV2Res),
            typeof(CreatedDungeonSiegeWarV2Noti),
            typeof(DungeonSiegeWarClearV2Noti),
            typeof(GetSiegeWarInfoV2Res),
            typeof(GetSiegeWarMatchInfoV2Res),
            typeof(ShowLocalizationV2Noti)
        };
    }
}