namespace NetProtocol.Models.Skill.Features
{
    public class PlayerSkillInfo
    {
        // Db 에 저장되는 값
        public int SkillCharacterId;
        
        public uint Index;
        public uint SkillSerial;
        public byte SkillGrade;
        public byte SkillLevel;
        
        public bool IsAuto;
    }
}