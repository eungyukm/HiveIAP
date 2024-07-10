using System.Linq;
using NetProtocol.Packet;

namespace NetProtocol.Models.Item
{
    public class RideEquipItemExV2 : ItemV2
    {
        public byte EquipParts = 0;
        public byte Intension = 0;
        public ushort Enchant = 0;
        public byte OptionCount = 0;
        public uint[] Options = Enumerable.Repeat<uint>(0, 7).ToArray();
        public byte SkillCount = 0;
        public ItemSkill[] Skills = new ItemSkill[2];
        public uint RideIndex = 0;

        public RideEquipItemExV2()
        {
            for (int i = 0; i < Skills.Length; ++i)
                Skills[i] = new();
        }
        public RideEquipItemExV2(ItemV2 item) : base(item)
        {
            for (int i = 0; i < Skills.Length; ++i)
                Skills[i] = new();
        }
        
    }
}