using System.Collections.Generic;
using NetProtocol.Models.Stat;
using NetProtocol.Packet;

namespace NetProtocol.Models.Item
{
    // 장비 아이템 정의
    public class EquipmentItemV2 : ItemV2
    {
        public EquipSlot EquipSlot = 0;
        public int DownLevel = 0;
        public int Enchant = 0;
        public byte SocketCount = 0;
        public List<int> OptionList = new();
        public byte SkillCount = 0;
        public List<ItemSkillV2> SkillList = new();
        public List<StatData> SubStatList = new();
    }


}