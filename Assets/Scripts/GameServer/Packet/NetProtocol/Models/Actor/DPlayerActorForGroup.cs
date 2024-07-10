using NetProtocol.Models.Actor.Features;

namespace NetProtocol.Models.Actor
{
    public class DPlayerActorForGroup
    {
        public long PlayerId;
        public string Name;
        
        public int Level;

        public string Face;
        public string Customize;
        
        public DActorProperty Property; 
        public DHp Hp;
        public DMp Mp;
        public DTransform Transform;
        
        // 길드
        public DGuild Guild = new();

        public long ZoneId = 0;
        public int ZoneDataId = 0;
    }
}