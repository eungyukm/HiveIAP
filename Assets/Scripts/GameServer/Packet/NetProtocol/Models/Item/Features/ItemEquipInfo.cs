using NetProtocol.Packet;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetProtocol.Models.Item.Features
{
    public class ItemEquipInfo
    {
        public EquipSlot EquipSlot = 0;
        public uint ItemIndex = 0;
        public bool IsVisible = true;
        public int Enchant = 0;
    }
}
