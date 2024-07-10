using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class WeaponAppearanceGachaV2Res
    {
        public ErrorCode Err;
        public uint[] ItemCollects;
        public List<WeaponAppearanceInfo> WeaponAppearances;
        public List<ItemV2> InvenSetItems;
        
    }
}