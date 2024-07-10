using System;

namespace NetProtocol.Models.Guild
{
    public class TerritoryInfo
    {
        public uint ZoneIndex = 0;
        
        public float TaxRate = 0f;
        public float ShopRate= 0f;
        public float ItemDropRate= 0f;
        public float CronDropRate= 0f;
        public int MonsterLevel = 0;
        public bool CanPvp = false;
        
        public bool CanEnterPlayers = false;
        public bool CanEnterEnemyGuild = true;
        public bool CanEnterCriminalPlayer = true;
        public bool CanEnterMurdererPlayer = true;

        public long LeftTimeSpanTicks = 0;

        public DateTime ExpiredAt = DateTime.UtcNow.AddDays(1);
        
        public TerritoryInfo()
        {
            
        }
        
        public TerritoryInfo(TerritoryInfo other)
        {
            ZoneIndex = other.ZoneIndex;
            
            TaxRate = other.TaxRate;
            ShopRate = other.ShopRate;
            ItemDropRate = other.ItemDropRate;
            CronDropRate = other.CronDropRate;
            MonsterLevel = other.MonsterLevel;
            CanPvp = other.CanPvp;
            CanEnterPlayers = other.CanEnterPlayers;
            CanEnterEnemyGuild = other.CanEnterEnemyGuild;
            CanEnterCriminalPlayer = other.CanEnterCriminalPlayer;
            CanEnterMurdererPlayer = other.CanEnterMurdererPlayer;

            LeftTimeSpanTicks = other.LeftTimeSpanTicks;
        }

        public void SetInfoFrom(TerritoryInfo other)
        {
            if (other == null)
            {
                return;
            }
        
            TaxRate = other.TaxRate;
            ShopRate = other.ShopRate;
            ItemDropRate = other.ItemDropRate;
            CronDropRate = other.CronDropRate;
            MonsterLevel = other.MonsterLevel;
            
            CanPvp = other.CanPvp;
            
            CanEnterPlayers = other.CanEnterPlayers;
            CanEnterEnemyGuild = other.CanEnterEnemyGuild;
            CanEnterCriminalPlayer = other.CanEnterCriminalPlayer;
            CanEnterMurdererPlayer = other.CanEnterMurdererPlayer;
        }
        
        public void CopyFrom(TerritoryInfo other)
        {
            if (other == null)
            {
                return;
            }
        
            ZoneIndex = other.ZoneIndex;
            TaxRate = other.TaxRate;
            ShopRate = other.ShopRate;
            ItemDropRate = other.ItemDropRate;
            CronDropRate = other.CronDropRate;
            MonsterLevel = other.MonsterLevel;
            CanPvp = other.CanPvp;
            CanEnterPlayers = other.CanEnterPlayers;
            CanEnterEnemyGuild = other.CanEnterEnemyGuild;
            CanEnterCriminalPlayer = other.CanEnterCriminalPlayer;
            CanEnterMurdererPlayer = other.CanEnterMurdererPlayer;
            
            LeftTimeSpanTicks = other.LeftTimeSpanTicks;
        }
    }
}