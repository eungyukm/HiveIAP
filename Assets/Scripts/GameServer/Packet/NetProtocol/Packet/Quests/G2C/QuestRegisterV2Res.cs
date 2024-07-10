using System;
using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    //서브 퀘스트 등록/해제
    public class QuestRegisterV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public QuestInfoV2[] Quest = Array.Empty<QuestInfoV2>();
        
    }
}