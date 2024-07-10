using System.Collections.Generic;
using NetProtocol.Models.Skill.Features;

namespace NetProtocol.Models.Skill
{
    public class DSkillPreset
    {
        public byte PresetNumber;
        public List<List<PresetSkillElement>> Presets = new();
    }
}