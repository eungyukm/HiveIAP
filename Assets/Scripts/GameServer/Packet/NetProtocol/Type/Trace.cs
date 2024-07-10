namespace NetProtocol.Packet
{
    public enum Trace
    {
        None = 0,
        
        Damage = 1,
        Cheat = 2,
        System = 3,
        ItemUse = 4,
        ItemBuy = 5,
        ItemSell = 6,
        ItemCombine = 7,
        ItemDisassemble = 8,
        ItemDownLevel = 9,
        ItemEnchant = 10,
        ItemOptionAdd = 11,
        ItemOptionChange = 12,
        ItemOptionMix = 13,
        ItemProduction = 14,
        ItemUpgrade = 15,
        ItemDelete = 16,            // 아이템 버림
        ItemCollect = 17,           // 아이템 수집
        ItemInherit = 18,           // 아이템 승계

        ItemWarehouse = 20,         // 아이템 창고
        InventoryExpand = 21,       // 가방 확장
        WarehouseExpand = 22,       // 창고 확장

        QuestReward = 25,
        QuestPortal = 26,
        QuestReroll = 27,
        TutorialSkip = 28,
        QuestPortalArrive = 29,

        PetUpgrade = 31,
        PetMix = 32,
        PetFeed = 33,           // 펫 먹이

        RideMix = 36,
        RideAttachDisassemble = 37,
        
        NaturalRecoveryHp = 41,
        NaturalRecoveryMp = 42,
        StatUpdateMaxHp = 43,
        StatUpdateMaxMp = 44,
        
        GuildCreation = 51,
        GuildWarehouse = 52,    // 길드 창고

        MailReceive     = 61,   // 우편 수령
        EventAttainment = 65,   // 달성 이벤트
        EventAttendance = 66,   // 이벤트 출석

        SkillUse = 71,
        SkillUpgrade = 72,
        SkillLevelUp = 73,
        SkillLearn = 74,

        KillMonster = 81,

        Rooting = 90,
        Resurrection = 91,
        DungeonResurrection = 92,
        DungeonEnter = 93,
        DungeonReward = 94,

        TownRecovery = 99,

        CostByUsePortal = 101,
        
        BossSchedule = 111,
        
        BossKill = 121,
        
        ClearExpDungeon = 131,
        
        RecoverExp = 141,
        
        InteractMineral = 151,
        
        BloodFogReward = 152,
        
        PartyDungeonReward = 161,
        
        // Trade
        TradeCronRegister = 201,
        TradeCronBuy = 202,
        TradeCronRecoverForRegisterFailed = 203,
        TradeCronSettled = 204,
        TradeCronCancel = 205,
        TradeCronReclaim = 206,

        TradePersonal = 211,        // 개인 거래소
        TradeItem = 212,            // 아이템 거래소

        DotHealHp = 220,
        DotHealMp = 221,

    }
}