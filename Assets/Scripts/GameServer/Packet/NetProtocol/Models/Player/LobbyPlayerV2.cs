using System;
using System.Collections.Generic;
using System.Numerics;
using NetProtocol.Models.Player.Features;
using NetProtocol.Packet;

namespace NetProtocol.Models.Player
{
    public class LobbyPlayerV2
    {
        public long PlayerId = 0;
        
        public short ClassId = 0;
        public int Level = 0;
        public short SlotNumber = 0;
        public string Name = String.Empty;

        public string Face = String.Empty;
        public string Customize = String.Empty;
        public string GuildName = String.Empty;
        
        public int MapId = 0;
        public Vector3 Position = Vector3.Zero;

        // 착용 정보
        public List<PlayerEquipment> Equipments = new List<PlayerEquipment>();
        public WeaponAppearanceInfo Info = new WeaponAppearanceInfo();
        public CostumeAppearanceInfo Costume = new CostumeAppearanceInfo();
        
        public long CombatCapability = 0;

        public DateTime LastPlayedAt = DateTime.UtcNow;
        public DateTime CreatedAt = DateTime.UtcNow;
    }
}