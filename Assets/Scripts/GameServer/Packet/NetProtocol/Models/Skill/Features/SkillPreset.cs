using System.Collections.Generic;

namespace NetProtocol.Models.Skill.Features
{
    public class SkillPreset
    {
        public byte PresetNum;
        public bool IsSelected;
        public List<SkillInfo> EquipSkills = new();
    }
}