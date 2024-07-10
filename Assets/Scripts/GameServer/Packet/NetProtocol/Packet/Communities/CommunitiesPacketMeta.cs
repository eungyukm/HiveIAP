using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetProtocol.Packet.Communities
{
    public class CommunitiesPacketMeta : IPacketMeta
    {
        public int StartId => 7000;

        public Type[] Types => new[]
        {
            typeof(AccountBlockPlayerAddReq),
            typeof(AccountBlockPlayerDeleteReq),
            typeof(AccountBlockPlayerReasonEditReq),
            typeof(AccountBlockPlayersReq),
            typeof(ChatMessageV2Req),
            typeof(PlayerSearchV2Req),
            typeof(AccountBlockPlayerAddRes),
            typeof(AccountBlockPlayerDeleteRes),
            typeof(AccountBlockPlayerReasonEditRes),
            typeof(AccountBlockPlayersRes),
            typeof(ChatMessageV2Noti),
            typeof(ChatMessageV2Res),
            typeof(PlayerSearchV2Res),
            typeof(LinkItemInfoReq),
            typeof(LinkItemInfoRes),
        };
    }
}
