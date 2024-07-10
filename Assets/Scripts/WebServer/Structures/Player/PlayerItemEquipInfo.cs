using System;

namespace RM2.Login.Structures.Player
{
    public class PlayerItemEquipInfo
    {
        public int EquipSlot { get; set; } = 0;
        public uint ItemIndex { get; set; } = 0;
        public bool IsVisible { get; set; } = true;
        public int Enchant { get; set; } = 0;
    }
}
