using System;
using System.Collections.Generic;
using System.Numerics;
using NetProtocol.Models.Item.Features;
using Guid = System.Guid;

namespace NetProtocol.Packet
{
    #region >>> Server

    public class WorldV2
    {
        public ServerOperateType OperateType = ServerOperateType.Dev;
        public int WorldId = 0;
        public string Name = string.Empty;
        public string Ip = "";
        public int Port = 0;
        public ServerTraffic Traffic = 0;
        public int PlayerCount = 0;
        public DateTime UpdateTime = DateTime.UtcNow;
    }
    
    public class Server
    {
        public ServerOperateType OperateType = ServerOperateType.Dev;
        public uint WorldId = 0;
        public string Name = string.Empty;
        public string Ip = "";
        public ushort Port = 0;
        public ServerTraffic Traffic = 0;
        public int UserCount = 0;
        public long UpdateTime = 0;
    }
    #endregion
    #region >>> User
    public class User
    {
        public Guid Id = new Guid();
        public byte Type = 1;
        public byte LastSelectAccountSlot = 0;
        public List<Guid> Accounts = new List<Guid>();
    }
    public class Account
    {
        public Guid Id = new Guid();
        public string Name = string.Empty;
        public uint LastSelectWorldId = 0;
        public List<WorldAccount> WorldAccounts = new List<WorldAccount>();
    }
    public class WorldAccount
    {
        public uint WorldId = 0;
        public byte Slot = 0;
        public long LastSelectPlayer = 0;
        public List<long> PlayerSlot = new();
        public byte WarehouseSizeLv = 0;
    }
    #endregion
    
    
    #region >>> Character
    public abstract class BaseObject
    {
        public ObjectType Type;
        public long Id;

        public BaseObject() { }
        public BaseObject(BaseObject baseObj)
        {
            Type = baseObj.Type;
            Id = baseObj.Id;
        }
    }
    public class MovableObject : BaseObject
    {
        public Vector3 Pos = new();
        public Vector3 Dir = new();
        public Vector3 TargetPos = new();
        public float MoveSpeed;

        public MovableObject() { }
        public MovableObject(MovableObject movObj) : base(movObj)
        {
            Pos = movObj.Pos;
            Dir = movObj.Dir;
            TargetPos = movObj.TargetPos;
            MoveSpeed = movObj.MoveSpeed;
        }
    }
    public class Character : MovableObject
    {
        public uint Index;
        public ActorState State;
        public long Hp;
        public long Mp;

        public Character() { }
        public Character(Character character) : base(character)
        {
            Index = character.Index;
            State = character.State;
            Hp = character.Hp;
            Mp = character.Mp;
        }
    }
    #endregion
    
    #region >>> Player
    public class Player : Character
    {
        public string Name = string.Empty;
        public uint Title = 0;
        public ushort Lv = 1;
        public ulong[] Stat = new ulong[(int)Stat1stOrder.End];
        public uint MapId = 1;
        public string Customize = "";

        // public GuildInfoData GuildInfo = new();
//        public MatchRoom matchRoom = new();
        public Player() { }

        public Player(Player player) : base(player)
        {
            Name = player.Name;
            Title = player.Title;
            Lv = player.Lv;
            Array.Copy(player.Stat, Stat, player.Stat.Length);
            MapId = player.MapId;
            Customize = player.Customize;
//            matchRoom = player.matchRoom;

        }
    }
    public class LobbyPlayer : Player
    {
        public string AccountId = "";
        public string Face = "";

        public long LastAccessTime = 0;
        public long CreateTime = 0;

        public List<uint> EquipmentIndicies = new();
        public Dictionary<EquipSlot, bool> EquipmentVisible = new();

        public LobbyPlayer() { }
        public LobbyPlayer(Player player) : base(player) { }

    }

    public class LoginPlayer : Player
    {
        public ulong Exp = 0;
        public ulong MaxHp = 0;
        public ulong MaxMp = 0;
        public ushort StatPoint;
        public ushort SkillPoint;
        public Crime Crime = new();
        public Wanted Wanted = new();

        public LoginPlayer() { }
        public LoginPlayer(Player player) : base(player) { }
    }
    #endregion
    #region >>> Npc
    public class Npc : Character
    {
    }
    #endregion
    #region >>> Item
    public class ItemOption
    {
        public int Index = 0;
        public long Value = 0;
        public long Per = 0;
    }
    public class ItemSkill
    {
        public uint Index = 0;
        public byte Lv = 0;
    }
    public class ItemUpdate
    {
        public uint Index;
        public int UpdateCount;
    }
    #endregion
    #region >>> Skill
    public class SkillUseObject
    {
        public long Id = 0;
        public ActorState State = 0;
        public long PrevMp = 0;
        public long CurrMp = 0;
        public uint SkillId = 0;

        public void Set(long id, long prevMp, long currMp, ActorState state, uint skillId)
        {
            Id = id;
            PrevMp = prevMp;
            CurrMp = currMp;
            State = state;
            SkillId = skillId;
        }
        public void Clear()
        {
            Id = 0;
            State = 0;
            PrevMp = CurrMp = 0;
            SkillId = 0;
        }
    }

    public class SkillResultObject
    {
        public long Id = 0;
        public uint SkillLinkIndex;
        public uint SkillResultValue;
        public long Hp = 0;
        public long Mp = 0;
        public uint SkillId = 0;
        public AttackJudgment AttackJudgment = AttackJudgment.Normal;
        public Vector3 ForceMoveDir = new Vector3();
        public Vector3 ForceMovePos = new Vector3();
        public long ResultTime = 0;
        public BuffInfo Buff = new();

        private uint _hitCount;
        public uint HitCount { get => _hitCount; set { _hitCount = value; } }
    }

    public class TargetInfo
    {
        public ObjectType TargetType;
        public long TargetId;
    }

    
    public class OwnSkill
    {
        public uint SkillSerial;
        public bool IsAuto;
    }

    #endregion
    #region >>> Buff
    public class BuffInfo
    {
        public long BuffId;
        public uint Index;
        public long OwnerId;
        public ActorState OwnerState;
        public long ExpireTime;
        public uint RetentionTime;
    }
    public class DeleteBuffInfo
    {
        public long OwnerId;
        public long BuffId;
    }
    #endregion
    #region >>> Commnunity
    #endregion
    #region >>> PvP / HitList
    public class Crime
    {
        public long RemainTime = 0;

        public Crime Clone() => (Crime)MemberwiseClone();
    }
    public class Wanted
    {
        public byte Lv = 0;
        public uint KillCount = 0;
        public long RemainTime = 0;
        public uint SeasonKillCount = 0;
        public uint SeasonPvpPoint = 0;

        public Wanted Clone() => (Wanted)MemberwiseClone();
    }
    //public class SeasonPvp
    //{
    //    public long PlayerId;
    //    public string PlayerName = string.Empty;
    //    public uint KillCount;
    //    public uint PvpPoint;
    //}
    public class HitListData
    {
        public long PlayerId = 0;
        public string PlayerName = string.Empty;
        public long GuildId = 0;
        public string GuildName = string.Empty;
        public BattleResult BattleResult = BattleResult.Lose;
        public uint MapIndex = 0;
        public long TimeStamp = 0;
    }
    // public class Tracking
    // {
    //     public long TargetId = 0;
    //     public uint MapIndex = 0;
    //     public Vector3 Pos = new();
    //     public long RemainTime = 0;
    // }
    #endregion
    #region >>> Event
    public class PlayerEvent
    {
        public EventCode EventCode = EventCode.None;
        public long EventId = 0;
        public long EventEndTime = 0;
    }
    #endregion

    public class ObjInfo
    {
        public ObjectType Type = ObjectType.Unknown;
        public long Id = 0;

        #region Sync_Move  //TODO : 이동 관련된 작업 이후 리팩토링
        public ActorState State = ActorState.Idle;
        public MoveState MoveState = MoveState.None;
        public Vector3 Pos = new Vector3();
        public Vector3 TargetPos = new Vector3();
        public Vector3 Dir = new Vector3();
        public float MoveSpeed = 0.0f;
        public long PerformTime;
        #endregion
        public bool IsBattleMode;

        public uint Index = 0;
        public string Name = string.Empty;
        public ushort Lv = 1;
        public ulong Hp = 0;
        public ulong MaxHp = 0;
        public ulong Mp = 0;
        public ulong MaxMp = 0;
        public uint MapId = 0;
        public CustomizationFace customizationFace = new();
        //TODO : 오브젝트의 Visual에 관련된 데이터 추가
        public List<BuffInfo> Buffs = new();
          
        public bool IsHoldAction = false;
        public SiegeWarFaction SiegeWarFaction = SiegeWarFaction.None;
        public SiegeModeState SiegeMode = SiegeModeState.None;
    }


    public class NpcInfo : ObjInfo
    {
        public byte MonsterType = 0;
    }

    public class PropInfo : NpcInfo
    {
        public byte InteractPropType = 0;
    }

    public class LoginSceneCharacterInfoV2
    {
        public int WorldId = 0;
        public long PlayerId = 0;
        public string Name = "";
        public int Level = 0;
        public short ClassId = 0;
        public DateTime LastPlayedAt = DateTime.UtcNow;
    }

    public class LoginSceneCharacterInfo
    {
        public uint WorldId = 0;
        public long PlayerId = 0;
        public string Name = "";
        public ushort Lv = 0;
        public uint Index = 0;
        public long LastAccessTime = 0;
    }

    #region Event
    public class EventAttainmentInfoV2
    {
        public uint EventId;
        public uint Day;
        public uint EventCondition;
        public uint EventConditionValue;
        public bool IsRewarded;
    }
    #endregion

    #region Quest
    public class QuestInfoV2
    {
        public uint QuestType; // 퀘스트 타입
        public uint QuestId; // 퀘스트 테이블 id
        public QuestState State; // 퀘스트 진행 상태
        public uint[] Value; // 퀘스트 진행 카운트 (최대 3개)
        public TargetPosInfo[] TargetPosInfo; // 퀘스트 목표 지점 (최대 3개)
    }

    public class TargetPosInfo
    {
        public uint MapIndex = 0;
        public Vector3 Pos = Vector3.Zero;
        public Vector3 Dir = Vector3.Zero;
    }

    #endregion
    //Quest Packet


    #region >>> Community
    public class PartyPlayer : Player
    {
        public ulong MaxHp = 0;
        public ulong MaxMp = 0;
    
        public bool IsMember = false;
        public long InvitedTime = 0;
        public long AccessEndTime = 0;
    
        public PartyPlayer() { }
        public PartyPlayer(Player player) : base(player) { }
        public PartyPlayer(PartyPlayer player) : base(player)
        {
            MaxHp = player.MaxHp;
            MaxMp = player.MaxMp;
    
            IsMember = player.IsMember;
            InvitedTime = player.InvitedTime;
            AccessEndTime = player.AccessEndTime;
        }
    }
    // public class PartyRecommandPlayer
    // {
    //     public long Id = 0;
    //     public string Name = string.Empty;
    //     public uint Index = 0;
    //     public ushort Lv = 0;
    // }


    public class MatchRoom
    {
        public long RoomId = 0;
        public uint DungeonIndex = 0;
        public List<MatchRoomPlayer> Members = new();
        public short Status = 0;
    
    }
    public class MatchRoomPlayer : PartyPlayer
    {
        public long Strength = 0;
        public bool IsChief = false;
        public bool IsReady = false;
        public byte SiegeWarFaction = 0;
    
        public MatchRoomPlayer() { }
        public MatchRoomPlayer(PartyPlayer player) : base(player) { }
        public MatchRoomPlayer(MatchRoomPlayer player) : base(player)
        {
            MaxHp = player.MaxHp;
            MaxMp = player.MaxMp;
            IsReady = player.IsReady;
            IsChief = player.IsChief;
            InvitedTime = player.InvitedTime;
            AccessEndTime = player.AccessEndTime;
            Index = player.Index;
            SiegeWarFaction = player.SiegeWarFaction;
        }
    }
    public class RoomListInfo
    {
        public long RoomId = 0;
        public ushort Lv = 0;
        public string Name = string.Empty;
        public uint DungeonIndex = 0;
        public uint charIndex = 0;
        public ushort Count = 0;
        public short Status = 0;
    }
    #endregion

    // #region >>> BloodFog
    // public class BloodFogPlayerResult
    // {
    //     public ushort Rank;
    //     public string PlayerName = string.Empty;
    //     public ushort PlayerLv;
    //     public ushort PlayerAp;
    //     public string GuildName = string.Empty;
    //     public ushort KillCount;
    //     public long DeathTime;
    // }
    // #endregion

    
    // ========================================================================
    #region >>> Guild
    // ------------------------------------------------------------------------
    public class GuildTendency
    {
        public short Tendency = 0;

        public GuildTendencyType GetTendencyLHS()
        {
            return (GuildTendencyType)(0b_0000_0000_1111_0000 & Tendency >> 4);
        }
        public GuildTendencyType GetTendencyRHS()
        {
            return (GuildTendencyType)(0b_0000_0000_0000_1111 & Tendency);
        }
        
        public bool SetTendencyLHS(byte type)
        {
            int mask = 0b_0000_0000_0000_1111 & Tendency;
            if (mask == type) return false;
            int lhs = type << 4;
            Tendency = (short)(mask | lhs);

            return true;
        }
        public bool SetTendencyRHS(byte type)
        {
            int mask = 0b_0000_0000_1111_0000 & Tendency;
            if (mask == type << 4) return false;
            int rhs = type;
            Tendency = (short)(mask | rhs);

            return true;
        }
        public bool IsValid()
        {
            if (Tendency == 0) return false;
            int lhs = 0b_0000_0000_1111_0000 & Tendency >> 4;
            int rhs = 0b_0000_0000_0000_1111 & Tendency;

            return lhs != rhs;
        }
    }
    
    // public class GuildHistory
    // {
    //     public long Time;
    //     public byte Type;
    //     public string Param1 = string.Empty;
    //     public string Param2 = string.Empty;
    // }

    // public class GuildBuff
    // {
    //     public uint GuildBuffCostTdIndex;
    //     public uint BuffIndex;
    //     public long ExpiredTime;
    // }
    // ========================================================================
    
    

    #endregion
    // #region >>> Rank&Reward
    // public class RankPlayer
    // {
    //     public long PlayerId = 0;
    //     public string PlayerName = string.Empty;
    //     public uint Rank = 0;
    //     public uint Score = 0;
    // }
    // #endregion

    #region >>> Mail
    public class Mail
    {
        public long Id = 0;
        public int Type = 0;
        public int SubType = 0;
        
        public string Title = string.Empty;
        public string Body = string.Empty;
        public SimpleItem[] Items = Array.Empty<SimpleItem>();
        
        public long ExpireTime = 0;
        public long SendTime = 0;
    }

    public class MailItem
    {
        public uint Index = 0;
        public uint Count = 0;

        public MailItem() { }
        public MailItem(uint tdIndex, uint count)
        {
            this.Index = tdIndex;
            this.Count = count;
        }
    }
    #endregion

    public class CustomizationBoneInfo
    {
        public sbyte Index;
        public sbyte Offset;
    }
    public class CustomizationFace
    {
        public sbyte SkinColor;
        public sbyte HairType;
        public sbyte HairColor;
        public CustomizationBoneInfo[] BoneGroupData;
        public CustomizationFace()
        {
            BoneGroupData = Array.Empty<CustomizationBoneInfo>();
        }

    }

    // ========================================================================
    #region >>> Pet
    // ------------------------------------------------------------------------
    public class PetData
    {
        public uint Index;
        public uint Level;
        public int Stack;
        public int Saturation;
        public long SaturationTime;
        public bool IsEquipped;
    }
    
    public class PetCostData
    {
        public uint Index;
        public int Count;
    }
    
    public class PetMixData
    {
        public byte MixGrade;
        public int MixCount;
        public List<PetCostData> Costs;
    }

    public class PetCollect
    {
        public int Index;
        public short CheckBox;
        public bool IsComplete;
    }
    #endregion
    // ========================================================================

    
    // ========================================================================
    #region >>> Ride
    // ------------------------------------------------------------------------
    public class RideData
    {
        public uint Index;
        public int Stack;
        public long AttachHead;
        public long AttachBack;
        public long AttachTail;
    }
    
    public class RideCostData
    {
        public uint Index;
        public int Count;
    }
    
    public class RideMixData
    {
        public byte MixGrade;
        public int MixCount;
        public List<RideCostData> Costs;
    }
    
    public class RideAttachData
    {
        public long AttachID;
        public uint Index;
    }
    
    #endregion
    // ========================================================================
    
    
    // ========================================================================
    #region >>> Costume
    // ------------------------------------------------------------------------
    public class CostumeData
    {
        public uint Index;
        public long TimeCreate;
    }
    
    public class CostumeCard
    {
        public uint Index;
        public int Count;
        public int Build;
    }
    
    public class CostumeCost
    {
        public uint Index;
        public int Count;
    }
    
    public class CostumeConfirm
    {
        public long ConfirmID;
        public uint CostumeIndex;
        public int ReRollNow;
        public int ReRollMax;
        public long TimeExpire;
        public long TimeCreate;
    }
    public class CostumeAppearanceInfo
    {
        public uint Head;
        public bool HeadShow;
        public uint Body;
        public bool BodyShow;
    }
    public class CostumeMixData
    {
        public byte MixGrade;
        public int MixCount;
        public List<CostumeCost> Costs;
    }
    #endregion
    // ========================================================================


    // ========================================================================
    #region >>>WeaponAppearance
    // ------------------------------------------------------------------------
    public class WeaponAppearanceInfo
    {
        public uint WeaponAppearanceIndex;
        public bool IsHidden;
        public bool IsEquiped;
    }
    #endregion
    // ========================================================================
    
    

    
    #region >>> ItemCollection
    public class ItemCollect
    {
        public int ItemCollectTableIndex;
        //public uint[] ItemTableIndex = Array.Empty<uint>();
        public int[] ItemTableIndex;
    }
    #endregion

    
    public class TitleConditionInfo
    {
        public int TitleIndex;
        public int Value;
    }


    #region >>> EventSystem

    public class AttendanceBaseData
    {
        public uint Day = 0;
        public long RewardTime = 0;
        public bool IsReward = false;
        public bool IsAttendance = false;
    }
    public class AttendanceEvent
    {
        public uint EventIndex = 0;
        public uint TotalAttendanceDay = 0;
        public List<AttendanceBaseData> Attendances = new();
    }

    public class AttainmentNormal
    {
        public uint AchieveConditionIndex;
        public long Count;
        public long RewardTime;
        public bool IsReward;
        public bool IsComplete;
    }
    public class AttainmentNormalEvent
    {
        public uint EventIndex;
        public List<AttainmentNormal> AttainmentNormalEvents = new();
    }

    public class AttainmentDaily
    {
        public uint Day;
        public uint AchieveConditionIndex;
        public long Count;
        public long RewardTime;
        public bool IsReward;
        public bool IsComplete;
    }
    public class AttainmentDailyEvent
    {
        public uint EventIndex;
        public List<AttainmentDaily> AttainmentDailyEvents = new();
    }

    public class EventGrowth
    {
        public uint EventIndex;
        public List<uint> MapIndex = new();
    }
    public class EventExchange
    {
        public uint ExchangeCount;
        public uint ExchangeItem;
    }

    public class EventExchangeEvent
    {
        public uint EventIndex;
        public uint EventMap;      // TdExchangeEffectMap
        public List<EventExchange> EventExchanges;
    }
    #endregion

    #region >>> SiegeWar
    [System.Serializable]
    public class SiegeWarMatchInfoBase
    {
        public uint Index = 0;
        public long ApplyStartTime = 0;
        public long ApplyEndTime = 0;
        public long WarStartTime = 0;
        public uint ApplyAttackerCount = 0;
        public uint ApplyDefenderCount = 0;
    }
    [System.Serializable]
    public class SiegeWarMatchInfo : SiegeWarMatchInfoBase
    {
        public SiegeWarMatchInfo()
        {

        }
        public SiegeWarMatchInfo(SiegeWarMatchInfoBase matchInfoBase)
        {
            FromBase(matchInfoBase);
        }

        public void FromBase(SiegeWarMatchInfoBase matchInfoBase)
        {
            Index = matchInfoBase.Index;
            ApplyStartTime = matchInfoBase.ApplyStartTime;
            ApplyEndTime = matchInfoBase.ApplyEndTime;
            WarStartTime = matchInfoBase.WarStartTime;
            ApplyAttackerCount = matchInfoBase.ApplyAttackerCount;
            ApplyDefenderCount = matchInfoBase.ApplyDefenderCount;
        }

        public byte SelectedMyFaction = 0;
    }
    [System.Serializable]
    public class SiegeWarObject
    {
        public byte ObjectType = 0;
        public byte Faction = 0;
        public bool IsActive = false;
        public Vector3 Pos;
    }
    [System.Serializable]
    public class SiegeWarInfo
    {
        public SiegeWarObject[] Objects = Array.Empty<SiegeWarObject>();
        public long StartTime = 0;
        public long AttackerNextRevivalTime = 0;
        public long DefenderNextRevivalTime = 0;
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    /// 
    // public class Item
    // {
    //     public long Id = 0;
    //     public byte Type = 0;
    //     public uint Index = 0;
    //     public uint Count = 1;
    //     public bool IsFixedOwner = false;
    //     public long ExpireDate = 0;
    //
    //     public Item() { }
    //     public Item(Item item)
    //     {
    //         Id = item.Id;
    //         Type = item.Type;
    //         Index = item.DataId;
    //         Count = item.Qty;
    //         IsFixedOwner = item.IsFixedOwner;
    //         ExpireDate = item.ExpireDate;
    //     }
    // }
 
    // public class Equipment : Item
    // {
    //     public EquipSlot EquipSlot = 0;
    //     public byte Intension = 0;
    //     public ushort Enchant = 0;
    //     public byte OptionCount = 0;
    //     public uint[] Options = Enumerable.Repeat<uint>(0, 7).ToArray();
    //     public byte SkillCount = 0;
    //     public ItemSkill[] Skills = new ItemSkill[2];
    //     public bool IsVisible = true;
    //     public uint SubParameter = 0;
    //     public ulong SubParameterValue = 0;
    //
    //     public Equipment()
    //     {
    //         for (int i = 0; i < Skills.Length; ++i)
    //             Skills[i] = new();
    //     }
    //     public Equipment(Item item) : base(item)
    //     {
    //         for (int i = 0; i < Skills.Length; ++i)
    //             Skills[i] = new();
    //     }
    // }
    
    // public class ItemEquipPlayer : PlayerActors
    // {
    //     public List<Equipment> Equipments = new();
    //
    //     public ItemEquipPlayer() { }
    //     public ItemEquipPlayer(PlayerActors player) : base(player) { }
    // }
    
    // public class PkLooting
    // {
    //     public long Id = 0;
    //     public long PlayerId = 0;
    //     public string PlayerName = string.Empty;
    //     public uint PlayerIndex = 0;
    //     public ushort PlayerLv = 0;
    //     public uint MapIndex = 0;
    //     public long GainEndTime = 0;
    //     public List<Item> Items = new();
    // }
 
    // public class PlayerInfo : ObjInfo
    // {
    //     public string Face = "";
    //     public string Customize = "";
    //     public uint Title = 0;
    //
    //     public List<Equipment> Equipments = null;
    //
    //     public bool IsCutScene = false;
    //     public bool IsCriminal = false;
    //     public bool IsBloodFogPlayer = false;
    //     public GuildBase GuildInfo = new GuildBase();
    //
    //     public uint EquipPet = 0;
    //
    //     public RideInfo RideInfo = null;
    //
    //     public WeaponAppearanceInfo WeaponAppearance = null;
    // }
 
    // public class QuestRewardInfo
    // {
    //     public uint TbIndex = 0;
    //     public ulong Exp = 0;
    //     public Item[] Items = Array.Empty<Item>();
    // }
 
    // public class PersonalRewardInfo
    // {
    //     public long player_id = 0;
    //     public ItemUpdate[] ItemUpdates = Array.Empty<ItemUpdate>();
    //     public Item[] Items = Array.Empty<Item>();
    // }
    //
 
    // public class ChangeItemInfo
    // {
    //     public List<long> Deletes = new List<long>();
    //     public List<Item> Updates = new List<Item>();
    // }
 
    // public class Party
    // {
    //     public long Id = 0;
    //     public List<PartyPlayer> Members = new();
    //     public List<Item> Items = new();
    // }
 
    // public class GuildInfo : GuildSummary
    // {
    //     public string Notice = string.Empty; // 길드 공지
    //     //public Item[] GuildGoods = new Item[2]; //길드 재화;	=> 소유 타입은 무슨 타입으로 할것인가? 유료재화? 무료재화?
    //     public List<Item> GuildGoods = new List<Item>(); //길드 재화;	=> 소유 타입은 무슨 타입으로 할것인가? 유료재화? 무료재화?
    //     public long GuildPoint;    // 길드 포인트
    //     public long GuildMaster;   // 길드장 UID
    //     public long GuildViceMaster;   // 부길드장 UID
    //     public bool IsRemovalVote; // 길드장 해임 투표 진행 여부
    //     public long RemovalVoteEndTime;  // 길드장 해임 투표 종료 시간
    //     public int Ranking;
    // }
 
    // public class GuildMember
    // {
    //     public long Uid = 0;
    //     public string Name = string.Empty;
    //     public ushort Level = 0;
    //     public long BattlePower = 0;       // 전투력
    //     //public Item[] GuildGoods = new Item[2]; //기부 재화 누적
    //     public List<Item> GuildGoods = new List<Item>(); //길드 재화;	=> 소유 타입은 무슨 타입으로 할것인가? 유료재화? 무료재화?
    //     public uint DonationCount = 0;
    //     public long DonationPoint = 0; // 누적 공여 포인트
    //     public long LogoutTime = 0;        // 로그 아웃 시간
    //     public byte State = 0;         // 로그아웃, 로그인, 가입승인대기, 초대 응답 대기중?
    //     public long JoinTime = 0;
    //     public uint CharacterTableID = 0;
    // }
 
    // public class RankReward
    // {
    //     public uint Rank = 0;
    //     public List<Item> Items = new();
    // }
 
    // public class RideEquipItem : Item
    // {
    //     public byte EquipParts = 0;
    //     public byte Intension = 0;
    //     public ushort Enchant = 0;
    //     public byte OptionCount = 0;
    //     public uint[] Options = Enumerable.Repeat<uint>(0, 7).ToArray();
    //     public byte SkillCount = 0;
    //     public ItemSkill[] Skills = new ItemSkill[2];
    //     public uint RideIndex = 0;
    //
    //     public RideEquipItem()
    //     {
    //         for (int i = 0; i < Skills.Length; ++i)
    //             Skills[i] = new();
    //     }
    //     public RideEquipItem(Item item) : base(item)
    //     {
    //         for (int i = 0; i < Skills.Length; ++i)
    //             Skills[i] = new();
    //     }
    // }
 
    // public class RideInfo
    // {
    //     public uint RideTdId;
    //     public List<RideEquipItem> EquipItem = new();
    //     public bool IsRegister = false; // 등록된 탈 것
    //     public bool IsMountState = false; // 탈 것 소환된 상태
    //
    //     public void UpdateRegisterState()
    //     {
    //         if (IsRegister)
    //         {
    //             IsRegister = false;
    //         }
    //         else
    //         {
    //             IsRegister = true;
    //         }
    //     }
    //
    //     public bool GetRegisterState() => IsRegister;
    //
    //     public void UpdateMountState()
    //     {
    //         //IsMountState |= true;
    //         if (IsMountState)
    //         {
    //             IsMountState = false;
    //         }
    //         else
    //         {
    //             IsMountState = true;
    //         }
    //     }
    //
    //     public bool GetRideState() => IsMountState;
    // }

    
    
    // public class SkillData
    // {
    //     public List<OwnSkill> Skills = new();
    //     public SkillPreset[] SkillPresets = Array.Empty<SkillPreset>();
    // }

    // public class SkillPreset
    // {
    //     public byte PresetNum;
    //     public bool IsSelected;
    //     public List<SkillInfo> EquipSkills = new();
    // }

    // public class SkillInfo
    // {
    //     public uint Gid;
    //     public byte Slot;
    // }

    
}