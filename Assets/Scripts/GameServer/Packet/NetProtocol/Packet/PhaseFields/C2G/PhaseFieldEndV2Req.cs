using System.Numerics;

namespace NetProtocol.Packet.C2G
{
    public class PhaseFieldEndV2Req
    {
        public uint Index;
        public uint ConditionQuestIndex;
        public PhaseFieldState State;
        public Vector3 EndPos;
        
    }
}