using System.Numerics;

namespace NetProtocol.Packet.G2C
{
    public class SkillHitEffectV2Noti
    {
        public long AttackerActorId;
        public long TargetActorId;
        
        public int SkillLinkId;

        public Vector3 PreviousPosition;
        public Vector3 ResultPosition;

        public long BuffId;
    }
}