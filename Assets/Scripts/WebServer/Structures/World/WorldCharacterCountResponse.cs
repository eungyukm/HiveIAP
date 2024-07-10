using System;

namespace RM2.Login.Structures.World
{
    public class WorldCharacterCountResponse
    {
        public WorldCharacterCount[] Counts { get; set; } = Array.Empty<WorldCharacterCount>();
    }
}