using NetProtocol.Models.Actor.Features;

namespace NetProtocol.Models.Party
{
    public class PartySuggestionPlayer
    {
        public long ActorId = 0;
        public string Name = string.Empty;
        public int Level = 0;

        public int ClassId;     // Character Index?
            
        // 길드?
        public DGuild GuildInfo = new DGuild();
    }
}