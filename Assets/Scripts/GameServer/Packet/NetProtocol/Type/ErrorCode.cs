namespace NetProtocol.Packet
{
    public enum ErrorCode
    {
        Success = 0,

        /////////////////////////////////////////////////////////////
        /// GracefulShutdown
        StartGracefulShutdown = 800,
        ServerShutdown = 801,
        EndGracefulShutdown = 899,
        /////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////
        /// World Queue
        StartWorldQueue = 900,
        WorldQueueInvalidWorldId = 901,         // 잘못된 월드 아이디
        WorldQueueInvalidAccountId = 902,       // 잘못된 어카운트 아이디
        WorldQueueEnqueueFailed = 903,          // 월드 대기열에 등록 실패
        WorldQueueIssueTicketFailed = 904,      // 대기열 티켓 발급 실패
        WorldQueueInvalidTicket = 905,          // 잘못된 대기열 티켓
        WorldQueueTicketTouchFailed = 906,      // 키 만료 시간 갱신 실패
        WorldQueueCriticalError = 907,          // 대기열 오류
        
        WorldQueuePending = 998,                // 월드 대기열 대기 중
        
        EndWorldQueue = 999,
        /////////////////////////////////////////////////////////////
        
        /////////////////////////////////////////////////////////////
        /// Common
        StartCommon = 1000,
        UserNotFound = 1001,               // 사용자를 찾을 수 없음.
        Unknown     = 1002,
        Error       = 1003,
        TargetPlayerNotInZone = 1004,

        InvalidArgument = 1005,
        DbInsertFailed = 1006,
        DbUpdateFailed = 1007,
        DbDeleteFailed = 1008,
        
        InvalidCommand = 1010,              // 알 수 없는 명령어
        
        PrivilegeAlready = 1901,            // 이미 사용중인 특권입니다.

        AccountNameNotHas = 1998,           // 계정 이름이 없습니다.
        
        EndCommon = 1999,
        /////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////
        /// Collect
        StartCollect = 2000,
        ItemCollectBookmarkAlreadyRegistered,
        ItemCollectBookmarkRegisterFailed,
        ItemCollectBookmarkNotRegistered,
        ItemCollectBookmarkUnregisterFailed,
        ItemCollectNotEquipment,
        ItemCollectItemEquipped,
        ItemCollectConditionNotMatched,
        ItemCollectAlreadyRegistered,
        ItemCollectRegisterFailed,
        ItemCollectItemRemoveFailed,
        EndCollect = 2999,
        /////////////////////////////////////////////////////////////
        
        /////////////////////////////////////////////////////////////
        /// Skill & Buff
        StartSkillBuff = 3000,
        SkillNotFoundFromResource,
        SkillAlreadyHas,
        SkillNotHas,
        SkillSetAutoUseSame, // 현재값과 세팅 할려고 하는 값이 같다.
        SkillSetAutoUseFailed,
        SkillAddFailed,
        SkillCoolTimeNotOver,
        SkillGlobalCoolTimeNotOver,
        SkillCastringTimeNotOver,
        SkillHitCountError,
        SkillCasting,

        SkillEnchantNotFoundItemFromResource,
        SkillEnchantHasNoItems,
        SkillEnchantHasNoCurrency,
        SkillUpgradeNotFoundItemFromResource,
        SkillUpgradeHasNoItems,
        SkillUpgradeHasNoCurrency,

        SkillUsing,
        SkillImmune,

        SkillLevelUpFail,
        SkillUpgradeFail,

        NotFoundAoeTarget,
        NotFoundSkillLinksByHitAssign,
        SkillLinkEmpty, // 스킬 링크 데이터 없음
        SkillEffectEmpty, // 스킬 효과 데이터 없음
        InvalidHitTime,

        CannotAttackActor,
        CannotPvp,

        BuffAddFailed,
        BuffIsNotBuffType,
        DeBuffOverlapTypeError,
        DeBuffOverlapExceededMaximumLimit,
        DeBuffAlreadyHasStronger,

        BuffInvalid,
        BuffDotEmpty,

        MoveDisabled,
        AttackDisabled,

        RunningMoveEffect, // 이동 상태이상 적용중

        BuffResourceNotFound,

        BlockedByBarrier,

        SkillCanNotUseWithInteract, // 상호작용 중 스킬 사용 불가능

        EndSkillBuff = 3999,
        /////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////
        /// Item
        StartItem = 4000,
        ItemStart,              // 아이템 관련 에러 시작
        ItemNoEnchant = 4002,          // 강화할 수 없는 아이템 입니다.
        ItemNoState = 4003,            // 아이템을 사용할 수 없는 상태입니다.
        ItemNotEnough = 4004,        // 아이템이 부족합니다.
        ItemNoUpgrade = 4005,          // 승급할 수 없는 아이템 입니다.
        ItemEquiped = 4006,            // 착용중인 아이템 입니다.
        ItemNoCombine = 4007,          // 조합할 수 없는 아이템 입니다.
        InvalidEquipSlot = 4008,       // 유효한 착용 부위가 아닙니다. 
        ItemInvalidGrade = 4009,       // 아이템 등급이 유효하지 않습니다.
        ItemInvalidUseTribe = 4010,    // 종족 조건이 맞지 않습니다.
        ItemInvalidUseClass = 4011,    // 직업 조건이 맞지 않습니다.
        ItemInvalidUseGender = 4012,   // 성별 조건이 맞지 않습니다.
        ItemInvalidUseWarehouse = 4013,// 창고 조건이 맞지 않습니다.
        ItemNotFound = 4014,
        ItemUnknown = 4015,
        ItemInvalid = 4016,
        ItemEmpty = 4017,
        ItemIsNull = 4018,
        ItemOver = 4019,
        ItemNoDisassemble = 4020,          // 분해할 수 없는 아이템 입니다.
        ItemNoProduction = 4021,          // 제작할 수 없는 아이템 입니다.
        ItemCoolTimeIsNotOver = 4022,  // 아이템 사용 쿨타임 입니다.
        ItemNoUse = 4023,              // 사용할 수 없는 아이템 입니다.
        ItemInvalidUseLevel = 4024,    // 사용 레벨 조건이 맞지 않습니다.
        InventoryFull = 4025,          // 가방 공간이 부족합니다.
        WarehouseFull = 4026,          // 창고 공간이 부족합니다.
        ItemNotEquipment = 4027,        // 장비 아이템이 아닙니다.
        PotionHasOver = 4028,       // 물약 아이템 소지량을 초과
        ItemLocked = 4029,          // 잠금 상태의 아이템 입니다.
        ItemNoInherit = 4030,          // 승계 할 수 없는 아이템 입니다.
        ItemInvalidInherit = 4031,     // 승계 조건이 맞지 않습니다.

        EndItem = 4499,         // 아이템 관련 에러 끝

        // quick slot
        QuickslotInvalidIndex = 4501,      // 슬롯 인덱스가 유효하지 않음
        

        /////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////
        /// Wallet
        StartWallet = 5000,
        WalletStart,
        WalletNotEnough,        // 사용 재화가 부족합니다. 
        EndWallet = 5499,
        /////////////////////////////////////////////////////////////
        ///Event
        PlayerEventAlreadyAttendance = 5501,        // 오늘 출석은 이미 함.
        PlayerEventNotProgress = 5502,    // 출석이벤트 진행중이 아님.
        PlayerEventInvalid = 5503,      // 유효한 이벤트가 아님
        PlayerEventFullAttendance = 5504, // 모든 출석 완료
        PlayerEventNotAttendance = 5505,  // 출석하지 않은 거
        PlayerEventAlreadyAttendanceReward = 5506,     // 출석 보상을 이미 수령함.
        PlayerEventNotCompleted = 5507,
        PlayerEventAlreadyRewarded = 5508,

        /////////////////////////////////////////////////////////////
        /// Quest
        StartQuest = 6000,
        QuestInvalid,
        QuestNotAcceptableClass,
        QuestNotEnoughMinLevel,
        QuestOverMaxLevel,
        QuestUnableToProgress,
        QuestAlreadyProgressed,
        QuestDbProgressFailed,
        QuestCantAbandonQuest,
        QuestNotFound,
        QuestNotReady,
        QuestNotProgressing,
        QuestNotCompleted,
        QuestCantComplete,
        QuestCantGetReward,
        QuestCantTeleport,
        QuestCantAccept,
        TutorialIsNotCleared,
        QuestOverMaxSubQuestCount,
        QuestOverMaxDailyQuestCount,
        DailyQuestRerollOverCount,
        DailyQuestRerollNotEnoughMoney,
        DailyQuestEmpty,
        DailyQuestResetFailed,
        DailyQuestNotEnoughLevel,
        TutorialSkipFailed,
        QuestTeleportTooClose,
        EndQuest = 6999,
        /////////////////////////////////////////////////////////////
        
        /////////////////////////////////////////////////////////////
        /// Mail
        StartMail = 7000,
        MailNotFound,
        MailAlreadyRead,
        MailReadFailed,
        MailExpired,
        EndMail = 7999,
        /////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////
        /// Chat
        StartChat = 8000,
        TargetPlayerNotFound = 8001,
        EndChat = 8999,
        /////////////////////////////////////////////////////////////
        
        /////////////////////////////////////////////////////////////
        /// Battle
        StartBattle = 10_000,
        NotFoundForSharing = 10_001,    // 분배 받을 대상이 없음
        
        EndBattle = 10_999,
        /////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////
        /// Portal, BindStone
        StartPortalBindStone = 11_000,
        BindStoneNotFound = 11_001,
        AlreadyExistBindStone = 11_002,
        PortalNotFound = 11_003,
        BindStoneNotPortal = 11_004,
         
        EndPortalBindStone = 11_999,



        /////////////////////////////////////////////////////////////
        /// Party
        StartParty = 12_000,
        PartyAlreadyHas = 12_001,                   // 이미 파티가 있습니다.
        PartyNotFoundMember = 12_002,               // 맴버를 찾을 수 없음
        PartyNotFound = 12_003,                     // 파티가 없음
        PartyCreateFailed = 12_004,                 // 파티 생성 실패
        PartyJoinFailedPlayerNotFound = 12_005,     // 파티 가입을 시도한 플레이어를 찾을 수 없음
        PartyInvitePlayerNotFound = 12_006,         // 초대한 플레이어를 찾을 수 없음
        PartyInvitePlayerAlreadyHas = 12_007,       // 대상이 이미 파티 중
        PartyIsNotLeader = 12_008,                  // 파티 리더가 아님
        PartyAlreadyLeader = 12_009,                // 대상이 이미 파티 리더
        PartyCanNotKickLeader = 12_010,             // 파티 리더를 킥 할 수 없음
        PartyCanNotSelfKick = 12_011,               // 자기 자신을 킥 할 수 없음
        PartyInviterNotFound = 12_012,              // 초대한 플레이어를 찾을 수 없음
        PartyInviteByMe = 12_013,                   // 나를 초대할 수 없음
        PartySameLootingType = 12_014,              // 같은 루팅 타입
        PartyEnterDungeonZoneIdInvalid = 12_015,    // 입장 던전의 존 아이디 오류 ( 리소스 찾을 수 없음 )
        PartyEnterDungeonAlreadyReply = 12_016,     // 던전 입장에 대한 응답을 이미 했음
        PartyIsNotStateEnterDungeon = 12_017,       // 던전 입장 상태가 아님
        PartyIsNotEnterSoloDungeon = 12_018,        // 파티 중 솔로 던전 입장할 수 없음
        PartyInvitePlayerCanNotJoin = 12_019,       // 초대한 파티원이 파티에 참여할 수 없음 (다른 컨텐츠 진행 중)
        PartyPlayerJoinBloodFog = 12_020,           // 블러드 포그에 참여하는 동안 파티에 참석할 수 없음
        
        MemberUnknown,
        MemberInvalid,
        MemberEmpty,
        MemberExists,
        MemberDuplicate,
        MemberNotEnough,
        MemberOver,

        PartyUnknown,
        PartyInvalid,
        PartyEmpty,
        PartyExists,
        PartyDuplicate,
        
        EndParty = 12_999,
        /////////////////////////////////////////////////////////////
        
        /////////////////////////////////////////////////////////////
        /// Monster
        StartMonster = 13_000,
        MonsterNoDamaged = 13_000,
        EndMonster = 13_999,
        /////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////
        /// Pvp , 살생부
        StartBlackRoster = 14_000,
        BlackRosterTargetPlayerNotFound = 14_001,
        BlackRosterNotEnoughProvocationCost = 14_002,
        BlackRosterNotEnoughObserveCost = 14_003,
        BlackRosterNotEnoughRevengeCost = 14_004,
        BlackRosterCanNotWarpToTargetPlayer = 14_005,
        BlackRosterSetPreferenceError = 14_006,
        BlackRosterAlreadyUseProvocation = 14_007,
        BlackRosterAlreadyUseObserve = 14_008,
        BlackRosterAlreadyUseRevenge = 14_009,
        BlackRosterCanNotUseRevenge = 14_010,
        BlackRosterTooManyObserving = 14_011,
        
        EndBlackRoster = 14_999,
        /////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////
        /// Relation
        StartRelation = 15_000,
        RelationNotFoundFactionType = 15_001,
        RelationNotFoundTarget = 15_002,
        RelationRemoveFailedFromDb = 15_003,
        RelationAlreadyHas = 15_004,
        
        EndRelation = 15_999,
        /////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////
        /// Matching
        StartMatching = 16_000,
        MatchingInvalidForm = 16_001,
        MatchingApplyFailed = 16_002,
        MatchingApplicationNotFound = 16_003,
        MatchingZoneNotFoundInForm = 16_004,
        MatchingFormRemoveFailed = 16_005,
        MatchingFormRemoveFailedByZoneDataId = 16_006,
        MatchingMatchedGroupNotFound = 16_007,
        MatchingNotMatched = 16_008,
        
        MatchingScheduleAddFailed = 16_101,
        MatchingScheduleMatchedSetNotFound = 16_102,
        MatchingSchedulePlayerNotFound = 16_103,
        MatchingScheduleAlreadyReplied = 16_104,
        MatchingScheduleAcceptReplyHasNoPlayers = 16_105,
        MatchingSchedulePartyNotFound = 16_106,
        
        MatchingIdNotMatched = 16_201,
        MatchingRemoveFailedFromIncompleteGroups = 16_202,
        MatchingIdInvalid = 16_203,
        
        EndMatching = 16_999,
        /////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////
        /// Interact
        __StartInteract__ = 17_000,
        InteractInvalidAction = 17_001,
        InteractTargetNotFound = 17_002,        
        InteractAlreadyPlayer = 17_003,         //이미 상호작용 중인 유저가 있음
        InteractCanceld = 17_004,               //인터렉션 취소되었는데 완료 패킷 전송 시
        InteractNotStarted = 17_005,            //인터렉션 완료 시 ActorId 매칭되지 않을 때
        InteractPlayerUseOtherActor = 17_006,   //이미 다른 오브젝트와 상호작용 중
        InteractTargetDisappear = 17_007,       //상호작용 중인 타겟 사라짐

        __EndInteract__ = 17_999,
        /////////////////////////////////////////////////////////////
        
        /// Character
        StartCharacter = 18_000,

        CharacterClassInvalid = 18_001,
        CharacterClassLevelNotEnough = 18_002,

        EndCharacter = 18_999,
        /////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////
        /// Trade
        StartTrade = 20_000,
        TradeCronUnitInvalid = 20_001,          // 크론 유닛 ( 1_000_000 ) 단위가 아님
        TradeTooLowCronAmount = 20_002,         // 크론 유닛 보다 작은 수
        TradeHasNoCron = 20_003,                // 크론이 부족함
        TradeBalanceInvalid = 20_004,           // 교환비 오류
        TradeCronPriceComputeInvalid = 20_005,  // 가격 연산 오류
        TradeLowCronBalance = 20_006,           // 낮은 교환비
        TradeHighCronBalance = 20_007,          // 높은 교환비
        TradeCronBalanceChangeFailed = 20_007,  // 교환비 변경 실패 
        TradeCronBalanceHistoryAddFailed = 20_008,  // 교환비 변경 이력 추가 실패 
        TradeCronNotFoundByTradeId = 20_009,    // trade id 에 해당하는 대상을 찾을 수 없음.
        TradeHasNoRubyInBuyCron = 20_010,       // 루비 부족
        TradeHasNotSubscribed = 20_011,         // 정액제 가입되지 않음
        TradeCronNotExpired = 20_012,           // 만료되지 않았음
        TradeCronCanceledPenalty = 20_013,      // 취소 패널티 상태
        
        TradeInvalidPrice = 20101,              // 등록 가격이 맞지 않음.
        TradeCountOver = 20102,                 // 최대 등록 갯수가 넘어감
        TradeNoPermission = 20103,              // 거래 권한이 없음.
        TradeNoItem = 20104,                    // 거래 할 수 없는 아이템.
        TradeInvalidTarget = 20105,             // 거래 대상을 찾을 수 없음.
        TradeInvalidState = 20106,              // 거래 상태가 맞지 않음
        TradeBookmarkDuplicate = 20107,         // 같은 북마크가 이미 있음. 
        TradeBookmarkCountOver = 20108,         // 북마크 최대 갯수 초과. 
        TradeBookmarkInvaled = 20109,           // 유효하지 않는 북마크


        EndTrade = 20_999,
        /////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////
        /// BloodFog
        StartBloodFog = 21_000,
        BloodFogNotStart = 21_001,              //블러드포그 스케줄 시작되지 않음
        BloodFogLevelLimit = 21_002,            //블러드포그 레벨 제한
        BloodFogDataNotFound = 21_003,          //블러드포그 정보 없음
        BloodFogNotJoinUser = 21_004,           //블러드포그 참여유저가 아님
        BloodFogNotAccessSkill = 21_005,        //블러드포그 허용되지 않는 스킬
        BloodFogNotEnoughPoint = 21_006,        //블러드포그 포인트 부족
        BloodFogPartyPlayerCanNotJoin = 21_007, //블러드포그 파티 가입 플레이어 입장 불가능
        BloodFogAlreadyFinished = 21_008,       //블러드포그 이벤트 종료 후 입장 시도 시
        BloodFogPlayerNotExistZone = 21_009,    //블러드포그 입장 시도 시 블러드 포그가 열린 맵에 있지 않음
        BloodFogOverUseSkill = 21_010,          //블러드포그 버프 최대 횟수에 도달함
        BloodFogAlreadyJoin = 21_011,           //블러드포그 이미 입장함
        BloodFogOverGetPoint = 21_012,          //블러드포그 혈청을 얻을 수 있는 최대 개수를 넘김

        /////////////////////////////////////////////////////////////
        
        /////////////////////////////////////////////////////////////
        /// 아직 정리 못 한 것들
        StartMisc = 30000,
        MacroEmpty,
        InvalidPlayerId,
        BlockAlreadyHasTargetPlayer,
        DungeonResourceNotFound1,
        DungeonResourceNotFound2,
        DungeonJoinBloodFogPlayerCanNotEnter,   //블러드 포그에 입장한 유저는 던전 입장 불가능
        
        SessionIsNull,
        PlayerDataNotFound,
        AccountIdNotMatched,
        PlayerCreateFailed,
        // 플레이어 튜토리얼이 완료되지 않았을때 넘어가는 에러코드이름
        PlayerTutorialIsNotCleared,
        PlayerDeleteFailed,
        AccountAddFailed,
        UserNameIsNullOrEmpty,
        AccountNotFound,
        PlayerNameDuplicated,
        AccountProfileCreateFailed,
        InvalidAccountId,
        PlayerNameIsNullOrEmpty,
        InvalidPlayerName,
        InvalidPlayerClassId,
        CharacterClassStartResourceNotFound,
        CharacterLocationRowCreateFailed,
        SecondaryJobNotFound,
        PlayerMoveError,
        CharacterStartItemCreatFailed,
        PlayerInventoryPropertyRowCreateFailed,
        ZoneCreateFailed,
        ZoneEnterFailed,
        ActorZoneIsNull, // 존에 입장한 상태가 아님.
        MonsterMoveError,

        InvalidParameter,
        InvalidStatParameter,


        ActorIsDeadState,

        StatNotChanged,
        
        TargetActorNotFound,

        InvalidActor,

        NotEnoughHp,
        NotEnoughMp,
        NotEnoughItems,
        NotEnoughStatPoint,
        NotEnoughCron,
        NotEnoughRuby,

        CheatZoneNameIsNull,
        ZoneResourceNotFound,
        CheatTargetZoneIsNull,
        ZoneExitFailed,

        CheatSummonMonsterNotFoundResource,
        CheatCreateItemNotFoundResource,
        CheatInvalidLevelValue,

        ShopNotFoundFromResource,
        ShopInvalidLevel,

        NotSupportedYet,
        
        PlayerDeathInfoEmpty,
        PlayerIsNotDeath,
        PlayerDeathExpIsZero,
        PlayerRecoverExpCostNotHas,

        MonsterHitDelay,
        
        InvalidNameLength,
        
        EndMisc = 39999,
        /////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////
        /// Auth & Hive
        StartAuthEtc = 100_000,
        Auth_UnauthorizedUser,
        Auth_PermissionDenied,
        Auth_VersionInvalid,
        Auth_UserDuplicate,
        Auth_UserDuplicateClose,

        HivePlatform_Unknown,
        HivePlatform_VerificationFailed,
        HivePlatform_ServerError,
        EndAuthEnd = 100_999,
        /////////////////////////////////////////////////////////////
        
        #region Obsolate RM2

        // 일의 자리 수 공통
        // 1 - Unknown		알 수 없음
        // 2 - Invalid		값이 잘못됨 / 잘못된 파라미터
        // 3 - Empty		값이 존재하지 않음 = null = not found
        // 4 - Exists		이미 존재하는 값
        // 5 - Duplicate	중복된 값 / 동일한 값
        // 6 - NotEnough	값이 불충분 함
        // 7 - Over			값이 넘침

        Invalid,
        Empty,
        Exists,
        Duplicate,
        NotEnough,
        Over,
        ParamUnknown,
        ParamInvalid,
        ParamEmpty,
        ParamDuplicate,
        ParamNotEnough,
        ParamOver,
        TimeNotEnough,
        TimeOver,
        TableInvalid,
        TableEmpty,
        ServerEmpty,
        ServerInvalid,
        SessionInvalid,
        SessionEmpty,
        RedisUnknown,
        RedisEmpty,
        DbUnknown,
        DbInvalid,
        DbEmpty,
        DbExists,
        DbDuplicate,
        DbNotEnough,
        DbOver,
        MapInvalid,
        MapEmpty,
        SectorInvalid,
        SectorEmpty,
        UserInvalid,
        UserEmpty,
        UserExists,
        UserOver,
        AccountInvalid,
        AccountEmpty,
        AccountExists,
        AccountOver,
        PlayerInvalid,
        PlayerNotFound,
        PlayerEmpty,
        PlayerExists,
        PlayerNotEnough,
        PlayerLevelLow,
        PlayerClassTypeNotMatch,
        PlayerSearchMe,
        NpcInvalid,
        NpcEmpty,
        NpcExists,
        NpcNotEnough,
        SkillInvalid,
        SkillShortageUseMp,
        SkillNotExists,
        SkillCoolTimeIsNotOver,
        SkillRangeOver,
        SkillWeaponTypeNotMatch,
        SkillLearnLevelNotEnough,
        SkillLearnPointNotEnough,
        SkillLearnCostNotEnough,
        SkillLearnHigherSkillNotExist,
        SkillLearnMaxLevel,
        SkillCostInvalid,
        SkillReinforceLevelNotEnough,
        SkillResetCostNotEnough,
        SkillEquipInvalid,
        SkillRangeTooClose,
        SlotInvalid,
        SlotEmpty,
        SlotExists,
        SlotDuplicate,
        SlotNotEnough,
        SlotOver,
        LevelInvalid,
        LevelNotEnough,
        LevelOver,
        PropertyInvalid,
        PropertyEmpty,
        PropertyExists,
        PropertyNotEnough,
        PropertyOver,
        CurrencyInvalid,
        CurrencyEmpty,
        CurrencyExists,
        CurrencyNotEnough,

        
        #endregion

        WareHouseEmpty,
        GameServerError,
        DungeonCreateFailed,
        TicketError,
        TicketNotEnough,
        NotInDungeon,
        IndungeonNotEnoughCost,         // 인던 입장 비용 부족

        AuthorityInvalid,
        AuthorityExists,
        AuthorityDuplicate,
        AuthorityNotEnough,

        CountOver,

        TextOver,

        TargetUnknown,
        TargetInvalid,
        TargetEmpty,
        TargetExists,
        TargetDuplicate,

        MatchRoomUnknown,
        MatchRoomInvalid,
        MatchRoomEmpty,
        MatchRoomExists,
        MatchRoomDuplicate,

        #region >>> Shop

        ShopUnknown,
        ShopCantSellItem,
        ShopBuyCountInvalid,
        ShopSellCountInvalid,

        #endregion

        
        /////////////////////////////////////////////////////////////
        /// Guild
        #region >>> Guild Error
        GuildError = 260_000, // StartGuild(Error), // 0 - Pet(ERROR) - PetError : 1 ~ 7 >> 계획된 에러 값
        GuildUnknown, // 1 - Unknown		알 수 없음
        GuildInvalid, // 2 - Invalid		값이 잘못됨 / 잘못된 파라미터
        GuildEmpty, // 3 - Empty		값이 존재하지 않음 = null = not found
        GuildExists, // 4 - Exists		이미 존재하는 값
        GuildDuplicate,// 5 - Duplicate	중복된 값 / 동일한 값
        GuildNotEnough,// 6 - NotEnough	값이 불충분 함
        GuildOver,// 7 - Over			값이 넘침
        
        GuildClose,

        GuildNameLengthNotEnough,
        GuildNameDuplicated, // 길드 이름 중복
        GuildNameLengthOver,
        GuildNameSpecialCharacter,
        GuildNameDuplicate,
        
        GuildCreateAlreadyHas, // 이미 길드를 가지고 있는 상태에서 생성 시도
        GuildCreateFailed, // 길드 생성 실패
        GuildCreateFail,
        GuildCreatePlayerLevelNotEnough,
        
        GuildCrestsBGEmpty,
        GuildCrestsEmpty,
        GuildCrestBGInvalid,
        GuildCrestInvalid,
        
        GuildDeleteConditionNot,
        
        GuildLeaveFail,
        
        GuildMasterInsertFailed, // 길드 마스터 등록 실패
        GuildApplyFailed,   // 길드 신청 실패
        GuildNotFound,      // 길드 찾을 수 없음
        GuildBanishSelfNot, // 자신을 추방할 수 없음
        GuildBanishFail,    // 길드 추방 실패
        
        GuildJoined,
        GuildJoinNot,
        GuildJoinFail,
        GuildJoinPenalty,
        GuildJoinTypeNotEnough,
        GuildJoinTypeOver,
        GuildJoinConflict,
        GuildJoinPlayerLevelNotEnough,

        GuildVoteConflict,
        GuildVoteNotTime,

        GuildStateNotNormal,

        GuildSignRequestFail,
        GuildSignRequestCancelFail,
        
        GuildTendencyOver,
        GuildTendencyNotEnough,
        
        GuildAdminNot, 
        
        GuildMemberEmpty,
        GuildMemberNot,
        GuildMemberOver,
        GuildMemberNotWaiting,
        GuildMemberAlreadyWaiting,
        GuildMemberTypeWrong,
        GuildMemberIdConflict,
        
        GuildMasterChangeNot,
        GuildMasterNot,
        GuildMasterUnableLeave,
        GuildMasterImpeachNot,

        GuildNeedPoint,
        GuildNeedCron,
        
        GuildBuffInvalid,
        GuildBuffActiveNot,
        GuildBuffBuyNot,
        GuildBuffLevelConflict,
        
        GuildWaitingMemberEmpty,
        GuildWaitingMemberCountOver,
        
        NonDismantling,
        NoPermissionModify,
        LengthOver,
        RecommendListEmpty,
        ApplicationListEmpty,
        
        CannotJoinAndCreateFor24Hours,
        CannotVoting,
        
        NotvotingPeriod,
        IDInvalid,
        ImmediatelyJoinSuccess,
        ApprovalJoinSuccess,
        NoKickOutMaster,
        
        GuildAlreadyAttended,
        GuildDonationOver,
        GuildDonationFail,
        GuildDonationTypeWrong,
        AlreadyGuildEffect,
        NoAppliedGuildEffect,
        
        GuildCronNotEnough,
        GuildRubyNotEnough,
        GuildHallBeingRented,
        GuildHallRentalEnd,
        GuildHallRentalPeriodRemains,
        GuildWarehouseNotUsed,
        GuildWarehouseEmpty,
        GuildMasterWarehouseEmpty,
        
        GuildDBInsertFail,
        GuildDBUpdateFail,
        GuildDBDeleteFail,
        
        GuildDBCreateGuildFail,
        GuildDBAddGuildMemberFail,
        GuildDBAddWaitingMemberFail,
        GuildDBAddGuildHistoryFail,
        GuildDBDeleteGuildMemberFail,
        
        GuildTerritoryNotHas,
        GuildTerritoryResourceInvalid,
        GuildTerritorySetValueInvalid,
        
        // EndGuild = 260_999,
        #endregion
        /////////////////////////////////////////////////////////////
        

        /////////////////////////////////////////////////////////////
        /// Pet
        #region >>> Pet Error
        PetError = 261_000, // StartPet(Error), // 0 - Pet(ERROR) - PetError : 1 ~ 7 >> 계획된 에러 값
        PetUnknown, // 1 - Unknown		알 수 없음
        PetInvalid, // 2 - Invalid		값이 잘못됨 / 잘못된 파라미터
        PetEmpty, // 3 - Empty		값이 존재하지 않음 = null = not found
        PetExists, // 4 - Exists		이미 존재하는 값
        PetDuplicate,// 5 - Duplicate	중복된 값 / 동일한 값
        PetNotEnough,// 6 - NotEnough	값이 불충분 함
        PetOver,// 7 - Over			값이 넘침
        
        PetMixFail,
        PetFeedTypeWrong,
        PetFeedGradeWrong,
        PetTrainingTypeWrong,
        PetTrainingLevelWrong,
        PetTrainingItemWrong,
        PetTrainingItemNot,
        PetTrainingCronNotEnough,
        PetGachaFail,
        PetGachaItemNot,
        PetGachaTypeWrong,
        PetGachaGradeWrong,
        PetUpgradeInfoNot,

        #endregion
        /////////////////////////////////////////////////////////////


        /////////////////////////////////////////////////////////////
        /// Ride
        #region >>> Ride Error
        RideError = 262_000, // StartPet(Error), // 0 - Ride(ERROR) - RideError : 1 ~ 7 >> 계획된 에러 값
        RideUnknown, // 1 - Unknown		알 수 없음
        RideInvalid, // 2 - Invalid		값이 잘못됨 / 잘못된 파라미터
        RideEmpty, // 3 - Empty		값이 존재하지 않음 = null = not found
        RideExists, // 4 - Exists		이미 존재하는 값
        RideDuplicate,// 5 - Duplicate	중복된 값 / 동일한 값
        RideNotEnough,// 6 - NotEnough	값이 불충분 함
        RideOver,// 7 - Over			값이 넘침

        DifferentTribe,
        RideMixFail,
        RideSitFail,
        RideEquipFail,
        RideAttachInvenExtendFail,
        RideAttachNotID,
        RideAttachEquipFail,
        RideAttachGachaItemNot, 
        RideAttachGachaTypeWrong, 
        RideAttachGachaFail,
        RideGachaFail,
        RideGachaTypeWrong,
        RideGachaItemNot,
        RideGachaGradeWrong,
        #endregion
        /////////////////////////////////////////////////////////////


        /////////////////////////////////////////////////////////////
        /// Costume
        #region >>> Costume Error
        CostumeError = 263_000, // StartPet(Error), // 0 - Costume(ERROR) - CostumeError : 1 ~ 7 >> 계획된 에러 값
        CostumeUnknown, // 1 - Unknown		알 수 없음
        CostumeInvalid, // 2 - Invalid		값이 잘못됨 / 잘못된 파라미터
        CostumeEmpty, // 3 - Empty		값이 존재하지 않음 = null = not found
        CostumeExists, // 4 - Exists		이미 존재하는 값
        CostumeDuplicate,// 5 - Duplicate	중복된 값 / 동일한 값
        CostumeNotEnough,// 6 - NotEnough	값이 불충분 함
        CostumeOver,// 7 - Over			값이 넘침

        CostumeMixFail,
        CostumeEquipFail,
        CostumeGachaFail,
        CostumeGachaTypeWrong,
        CostumeGachaItemNot,
        CostumeGachaGradeWrong,
        
        CostumeCardInvalid,
        CostumeCardOpenInvalid,
        CostumeCardOpenNotEnough,
        
        CostumeInfoNot,
        #endregion
        /////////////////////////////////////////////////////////////


        #region >>> Title Error

        TitleUnknown,
        TitleEmpty,
        TitleAlreadyExists,

        #endregion

        #region >>> SiegeWar

        NotInDungeonSiegeWar,

        #endregion
        
        
    }
}