using System;

namespace RM2.Login.Structures.Player
{
    public class LobbyPlayerData
    {
        public long PlayerId { get; set; } = 0;
        public string HashedPlayerId { get; set; } = string.Empty;
        public int WorldId { get; set; } = 1;
        public short ClassId { get; set; } = 0;
        public int Level { get; set; } = 0;
        public short SlotNumber { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string Face { get; set; } = string.Empty;
        public string Customize { get; set; } = string.Empty;
        public string GuildName { get; set; } = string.Empty;
        public long CombatCapability { get; set; } = 0;
        public int MapId { get; set; } = 0;
        public Vector3 Position { get; set; } = Vector3.Zero;
        public PlayerEquipment[] Equipments { get; set; } = Array.Empty<PlayerEquipment>();
        public WeaponAppearanceData Info { get; set; } = new();
        public CostumeAppearanceData Costume { get; set; } = new();
        public DateTime LastPlayedAt { get; set; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}