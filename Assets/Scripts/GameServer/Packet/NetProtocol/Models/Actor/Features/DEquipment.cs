using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Models.Item.Features;
using NetProtocol.Packet;

namespace NetProtocol.Models.Actor.Features
{
    public class DEquipment
    {
        public Dictionary<EquipSlot, ItemEquipInfo> Equipments = new Dictionary<EquipSlot, ItemEquipInfo>();
    }
}