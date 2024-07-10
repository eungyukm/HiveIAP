using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Cheat
{
    public class CheatPacketMeta : IPacketMeta
    {
        public int StartId => 6000;

        public Type[] Types => new[]
        {
            typeof(CheatMessageV2Req),
            typeof(CheatGetMainQuestV2Noti),
            typeof(CheatMessageV2Res),
            typeof(CheatQuestResetV2Noti)
        };
    }
}