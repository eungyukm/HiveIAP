using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class PkLootingListV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public List<PkLootingItemV2> GainItems = new();
        public List<PkLootingItemV2> LostItems = new();
    }
}