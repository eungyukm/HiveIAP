using System.Collections.Generic;
using NetProtocol.Packet;

namespace NetProtocol.Models.Item
{
    public class PartyV2
    {
        public long Id = 0;
        public List<PartyPlayer> Members = new();
        public List<ItemV2> Items = new();
        
    }
}