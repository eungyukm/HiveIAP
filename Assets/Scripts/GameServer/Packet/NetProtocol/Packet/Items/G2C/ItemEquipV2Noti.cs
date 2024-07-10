using NetProtocol.Models.Item.Features;

namespace NetProtocol.Packet.G2C
{
    public class ItemEquipV2Noti
    {
        public long PlayerId = 0;
        public ItemEquipInfo EquipInfo = new();
        //public EquipSlot EquipSlot = 0;
        //public uint ItemIndex = 0;
        //public bool IsVisible = true;
        //public int Enchant = 0;

    }
}