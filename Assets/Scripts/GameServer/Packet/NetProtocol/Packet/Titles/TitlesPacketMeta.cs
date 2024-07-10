using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Titles
{
    public class TitlesPacketMeta : IPacketMeta
    {
        public int StartId => 28000;

        public Type[] Types => new[]
        {
            typeof(PlayerTitleChangeV2Req),
            typeof(TitleChangeV2Req),
            typeof(TitleListV2Req),
            typeof(TitleAddV2Noti),
            typeof(TitleChangeV2Noti),
            typeof(TitleChangeV2Res),
            typeof(TitleConditionUpdateV2Noti),
            typeof(TitleListV2Res)
        };
    }
}