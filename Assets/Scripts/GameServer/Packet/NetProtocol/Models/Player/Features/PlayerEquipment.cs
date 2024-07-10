using NetProtocol.Models.Item.Features;
using NetProtocol.Packet;

namespace NetProtocol.Models.Player.Features
{
    public class PlayerEquipment
    {
        //public EquipSlot SlotNumber = EquipSlot.None;
        //public uint ItemDataId = 0;
        //public bool IsVisible = false;
        //public int Enchant = 0;
        public ItemEquipInfo EquipInfo = new();
        public long ItemId = 0;
    }
}
