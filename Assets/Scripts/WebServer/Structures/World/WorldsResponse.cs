using System;

namespace RM2.Login.Structures.World
{
    public class WorldsResponse
    {
        public WorldInfo[] Worlds { get; set; } = Array.Empty<WorldInfo>();
    }
}