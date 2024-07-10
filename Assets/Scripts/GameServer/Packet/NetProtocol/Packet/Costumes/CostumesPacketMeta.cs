using System;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;

namespace NetProtocol.Packet.Custumes
{
    public class CostumesPacketMeta : IPacketMeta
    {
        public int StartId => 8000;

        public Type[] Types => new[]
        {
            typeof(CostumeCardBuildReq),
            typeof(CostumeCardBuildRes),
            
            typeof(CostumeCardGachaReq),
            typeof(CostumeCardGachaRes),
            
            typeof(CostumeCardInfoReq),
            typeof(CostumeCardInfoRes),
            
            typeof(CostumeCardMixReq),
            typeof(CostumeCardMixRes),
            
            typeof(CostumeCollectReq),
            typeof(CostumeCollectNoti),
            typeof(CostumeCollectRes),
            
            typeof(CostumeEquipBodyReq),
            typeof(CostumeEquipBodyRes),
            typeof(CostumeEquipBodyShowReq),
            typeof(CostumeEquipBodyShowRes),
            
            typeof(CostumeEquipHeadReq),
            typeof(CostumeEquipHeadRes),
            typeof(CostumeEquipHeadShowReq),
            typeof(CostumeEquipHeadShowRes),
            
            typeof(CostumeInfoReq),
            typeof(CostumeInfoRes),
            
            typeof(CostumeConfirmAcceptReq),
            typeof(CostumeConfirmChangeReq),
            typeof(CostumeConfirmInfoReq),
            typeof(CostumeConfirmAcceptRes),
            typeof(CostumeConfirmChangeRes),
            typeof(CostumeConfirmInfoRes),
        };
    }
}