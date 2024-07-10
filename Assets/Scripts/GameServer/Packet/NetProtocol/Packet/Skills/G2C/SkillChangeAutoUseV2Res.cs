using System.Collections.Generic;
using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class SkillChangeAutoUseV2Res
    {
        public ErrorCode Err;
        public List<OwnSkill> Skills;
        
    }
}