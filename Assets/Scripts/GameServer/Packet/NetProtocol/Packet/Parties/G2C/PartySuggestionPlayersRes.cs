using System.Collections.Generic;
using NetProtocol.Models.Party;

namespace NetProtocol.Packet.G2C
{
    public class PartySuggestionPlayersRes
    {
        public List<PartySuggestionPlayer> SuggestionPlayers = new List<PartySuggestionPlayer>();
    }
}