using System.Collections.Generic;

namespace NetProtocol.Models.Item
{
    public class ChangeItemInfoV2
    {
        public List<long> Deletes = new List<long>();
        public List<ItemV2> Updates = new List<ItemV2>();
    }
}