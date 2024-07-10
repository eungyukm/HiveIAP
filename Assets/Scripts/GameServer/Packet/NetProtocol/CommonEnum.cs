namespace NetProtocol.Packet
{

    public enum EventCode
    {
        None = 0,
        PkLootingTimeOver = 1
    }

    #region >>> Server

    public enum ServerOperateType
    {
        Local,
        Dev,
        Stage,
        Alpha,
        Live
    }

    public enum ServerStatus : byte
    {
        Stopped = 0,
        Waiting,
        Running,
        Running_BlockingEntry,
    }

    public enum ServerTraffic
    {
        ServerMaintenance = 0,
        Normal,         //원활
        High,           //혼잡
        BlockingEntry,  //불가
        BlockingCreate, //생성제한
    }
    #endregion

    #region >>> User
    public enum UserType
    {
        Blocked = 0,
        Normal,
        Super,
        Admin
    }
    #endregion
    #region >>> Character
    public enum ObjectType
    {
        Unknown = 0,
        Player,
        Npc,
    }

    public enum MoveState
    {
        None = 0,
        Walk,
        Run,
    }

    public enum MountType : short
    {
        Unequip = 0,
        Equip = 1,
    }
    #endregion
    #region >>> PlayerActors
    public enum SlotType
    {
        Unknown = 0,
        Item_Equipment,
        Item_Consume,
        Player_Skill = 10,
    }
    #endregion
    #region >>> Item

    #endregion
    #region >>> Inventory/Warehouse/GuildWarehouse/GuildMasterWarehouse
    public enum WarehouseType
    {
        none = 0,
        Private,
        Account,
        Guild,
        GuildMaster,
        Ride,
        RideEquip,
    }
    #endregion
    #region >>> Battle
    public enum AttackJudgment
    {
        None = 0,
        Normal,
        Miss,
        Dodge,
        Block,
        Resist,
        Critical,
        Reflect,
    }
    public enum BattleResult
    {
        Lose,
        Win,
        Draw
    }
    #endregion
    #region >>> Community
    public enum AcceptType
    {
        Accept = 0,
        Reject,
        Reject_Timeout,
        Reject_Logout
    }
    public enum BanType
    {
        Normal,
        Timeout,
        Logout,
    }

    #endregion

    public enum LeaveType : int
    {
        TriggerMapMove = 0,
        Logout = 1,
        IndunEnter,
        IndunLogout,
        LobbyBack,
    }
    public enum QuestState : int
    {
        CompleteWait = 0,       // 완료는 되었으나 보상받기 전
        Progressing = 1,           // 진행 중
        Ready = 2,                   // 가지고만 있는 단계
        Impossible = 3,            // 수락 불가능한 퀘스트 (패킷 처리용)
        Complete = 4,              // 보상까지 다 받음
    }

    public enum PortalType
    {
        BindStone,
        Monster,
        OneWayPortal,
        Quest,
    }

    public enum LootingType
    {
        Success,
        Failure_TimeOver
    }

    public enum TicketType
    {
        Dungeon,
    }

    public enum DungeonType
    {
        None,
        SingleEquip,
        SingleCron,
        SingleExp,
        SingleIntension,
        Party,
        SiegeWar,
        Max,
    }

    public enum ClearCondition
    {
        None,
        MonsterAllKill,
        ProtectCastleGate,
    }

    public enum MapType
    {
        Instance,
        Static,
    }

    public enum EntranceCostType
    {
        None,
        Free,
        Currency,
        Item
    }

    #region >>> Guild
    public enum GuildType
    {
        Close = 0,
        Open = 1,
        Confirm = 2,
    }
    public enum GuildStateType
    {
        Normal = 0,
        Locked = 1,
    }
    public enum GuildTendencyType
    {
        None = 0,
        Hunt,
        PK,
        Peace, 
        Cooperation, 
        Competition, 
    }
    public enum GuildFindCaseType
    {
        All,
        Open,
        Confirm,
        OpenConfirm,
        Close,
    }
    public enum GuildFindOptionType
    {
        Random,
        Level,
    }
    public enum GuildMemberType
    {
        Master = 0,
        MasterImpeach = 1,
        ViceMaster = 10,
        Elite = 100, 
        Normal = 1000,
    }
    public enum GuildMemberStateType
    {
        OnLine,
        OffLine,
    }
    public enum GuildMemberUpdateType
    {
        Join,
        Out,
        Update,
    }
    public enum GuildVoteType
    {
        None = 0,
        Impeach = 1,
    }
    public enum GuildDonateType
    {
        CRON = 1,
        RUBY = 2,
    }

    // public enum GuildHistoryType
    // {
    //     None = 0,
    //     Create,                     // 길드 생성
    //     Enter,                      // 길드 가입
    //     Leave,                      // 길드 탈퇴
    //     Notice,                     // 공지
    //     Banish,                     // 길드원 추방
    //     MasterNew,                  // 길드장 위임
    //     MemberEliete,               // 길드원 등급 설정
    //     MemberNormal,               // 길드원 등급 설정
    //     
    //     ViceMasterRise,             // 부길드장 위임
    //     ViceMasterFall,             // 부길드장 해임
    //     
    //     ImpeachStart,               // 길드장 해임 투표 시작
    //     ImpeachClose,               // 길드장 해임 투표 종료
    //     ImpeachSuccess,             // 길드장 해임 성공
    //     ImpeachFailure,             // 길드장 해임 실패
    //     
    //     WarehouseExtend,            // 길드 창고 확장
    //     WarehousePush,              // 길드 창고 넣기
    //     WarehousePick,              // 길드 창고 빼기
    //     WarehouseRubyPush,          // 길드 창고 루비 빼기
    //     WarehouseRubyPick,          // 길드 창고 루비 빼기
    //     WarehouseCronPush,          // 길드 창고 크론 빼기
    //     WarehouseCronPick,          // 길드 창고 크론 빼기
    //     
    //     LevelUp,                    // 길드 레벨 상승
    //     
    //     RelationHostileAdd,         // 적대 길드 설정
    //     RelationHostileDel,         // 적대 길드 해제
    //     RelationFriendlyAdd,        // 우호 길드 설정
    //     RelationFriendlyDel,        // 우호 길드 해제
    //     
    //     GuildBuffPassive,           // 길드 버프 습득
    //     GuildBuffActive,            // 길드 버프 사용
    //     
    //     Donate,                     // 길드 기부
    // }
    
    public enum GuildSolodarityStep
    {
        GSS_SOLDIER = 1,        // 병사
        GSS_KNIGHT,             // 기사
        GSS_BARON,              // 남작
        GSS_COUNT,              // 백작
        GSS_GRAND_DUKE,         // 대공
    }
    #endregion
    
    
    
    #region >>> Tendency
    public enum TendencyType
    {
        None = 0,
        Moral = 1,
        Criminal = 2,
        Slayer = 3,
        Max,
    }
    public enum TendencyKarmaType
    {
        None = 0,
        Moral_1 = 101,
        Moral_2 = 102,
        Moral_3 = 103,
        
        Criminal_1 = 201,
        Criminal_2 = 202,
        Criminal_3 = 203,
        
        Slayer_3 = 301,
        Slayer_2 = 302,
        Slayer_1 = 303,
        
        Max,
    }
    #endregion
    


    #region >>> SiegeWar
    public enum ChangedSiegeWarMatchInfoNotiType
    {
        None = 0,
        Activated_ApplyStartTime,
        Activated_ApplyEndTime,
        Activated_WarStartTime,
        AttackerInfo,
        DefenderInfo,
        Max,
    }

    public enum SiegeWarFaction : byte
    {
        None = 0,
        Attacker = 1,
        Defender = 2,
        Max,
    }

    public enum SiegeModeState : byte
    {
        None = 0,
        SiegeMode = 1,
    }
    #endregion

    public enum PhaseFieldState
    {
        Success = 0,
        Fail = 1,
        Dead = 2
    }

    public enum BloodFogWaveType
    {
        None = 0,
        Wave_1 = 1,
        Wave_2 = 2,
        Wave_Boss = 3,
        Wave_BossKilled = 4,
    }

    public enum BloodFogMessageType
    {
        None = 0,
        Notice = 1,
        Start = 2, 
        End = 3,
    }
}
