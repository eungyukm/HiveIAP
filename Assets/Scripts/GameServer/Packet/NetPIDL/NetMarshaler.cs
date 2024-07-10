#pragma warning disable CS0108
// @brief 이 파일은 자동생성 되었습니다.

using Nettention.Proud;
using System;
using System.Collections.Generic;

namespace NetProtocol.Packet {
    public partial class NetMarshaler : BaseMarshaler
    {
        public static bool Read(Message msg, out EventCode value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (EventCode)temp;
            return true;
        }
        public static void Write(Message msg, EventCode value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out ServerOperateType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (ServerOperateType)temp;
            return true;
        }
        public static void Write(Message msg, ServerOperateType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out ServerStatus value)
        {
            value = default;
            if (!Read(msg, out Byte temp))
                return false;

            value = (ServerStatus)temp;
            return true;
        }
        public static void Write(Message msg, ServerStatus value)
        {
            Write(msg, (Byte)value);
        }
        public static bool Read(Message msg, out ServerTraffic value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (ServerTraffic)temp;
            return true;
        }
        public static void Write(Message msg, ServerTraffic value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out UserType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (UserType)temp;
            return true;
        }
        public static void Write(Message msg, UserType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out ObjectType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (ObjectType)temp;
            return true;
        }
        public static void Write(Message msg, ObjectType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out MoveState value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (MoveState)temp;
            return true;
        }
        public static void Write(Message msg, MoveState value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out MountType value)
        {
            value = default;
            if (!Read(msg, out Int16 temp))
                return false;

            value = (MountType)temp;
            return true;
        }
        public static void Write(Message msg, MountType value)
        {
            Write(msg, (Int16)value);
        }
        public static bool Read(Message msg, out SlotType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (SlotType)temp;
            return true;
        }
        public static void Write(Message msg, SlotType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out WarehouseType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (WarehouseType)temp;
            return true;
        }
        public static void Write(Message msg, WarehouseType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out AttackJudgment value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (AttackJudgment)temp;
            return true;
        }
        public static void Write(Message msg, AttackJudgment value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out BattleResult value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (BattleResult)temp;
            return true;
        }
        public static void Write(Message msg, BattleResult value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out AcceptType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (AcceptType)temp;
            return true;
        }
        public static void Write(Message msg, AcceptType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out BanType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (BanType)temp;
            return true;
        }
        public static void Write(Message msg, BanType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out LeaveType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (LeaveType)temp;
            return true;
        }
        public static void Write(Message msg, LeaveType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out QuestState value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (QuestState)temp;
            return true;
        }
        public static void Write(Message msg, QuestState value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out PortalType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (PortalType)temp;
            return true;
        }
        public static void Write(Message msg, PortalType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out LootingType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (LootingType)temp;
            return true;
        }
        public static void Write(Message msg, LootingType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out TicketType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (TicketType)temp;
            return true;
        }
        public static void Write(Message msg, TicketType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out DungeonType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (DungeonType)temp;
            return true;
        }
        public static void Write(Message msg, DungeonType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out ClearCondition value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (ClearCondition)temp;
            return true;
        }
        public static void Write(Message msg, ClearCondition value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out MapType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (MapType)temp;
            return true;
        }
        public static void Write(Message msg, MapType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out EntranceCostType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (EntranceCostType)temp;
            return true;
        }
        public static void Write(Message msg, EntranceCostType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out GuildType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (GuildType)temp;
            return true;
        }
        public static void Write(Message msg, GuildType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out GuildStateType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (GuildStateType)temp;
            return true;
        }
        public static void Write(Message msg, GuildStateType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out GuildTendencyType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (GuildTendencyType)temp;
            return true;
        }
        public static void Write(Message msg, GuildTendencyType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out GuildFindCaseType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (GuildFindCaseType)temp;
            return true;
        }
        public static void Write(Message msg, GuildFindCaseType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out GuildFindOptionType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (GuildFindOptionType)temp;
            return true;
        }
        public static void Write(Message msg, GuildFindOptionType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out GuildMemberType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (GuildMemberType)temp;
            return true;
        }
        public static void Write(Message msg, GuildMemberType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out GuildMemberStateType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (GuildMemberStateType)temp;
            return true;
        }
        public static void Write(Message msg, GuildMemberStateType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out GuildMemberUpdateType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (GuildMemberUpdateType)temp;
            return true;
        }
        public static void Write(Message msg, GuildMemberUpdateType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out GuildVoteType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (GuildVoteType)temp;
            return true;
        }
        public static void Write(Message msg, GuildVoteType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out GuildDonateType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (GuildDonateType)temp;
            return true;
        }
        public static void Write(Message msg, GuildDonateType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out GuildSolodarityStep value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (GuildSolodarityStep)temp;
            return true;
        }
        public static void Write(Message msg, GuildSolodarityStep value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out TendencyType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (TendencyType)temp;
            return true;
        }
        public static void Write(Message msg, TendencyType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out TendencyKarmaType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (TendencyKarmaType)temp;
            return true;
        }
        public static void Write(Message msg, TendencyKarmaType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out ChangedSiegeWarMatchInfoNotiType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (ChangedSiegeWarMatchInfoNotiType)temp;
            return true;
        }
        public static void Write(Message msg, ChangedSiegeWarMatchInfoNotiType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out SiegeWarFaction value)
        {
            value = default;
            if (!Read(msg, out Byte temp))
                return false;

            value = (SiegeWarFaction)temp;
            return true;
        }
        public static void Write(Message msg, SiegeWarFaction value)
        {
            Write(msg, (Byte)value);
        }
        public static bool Read(Message msg, out SiegeModeState value)
        {
            value = default;
            if (!Read(msg, out Byte temp))
                return false;

            value = (SiegeModeState)temp;
            return true;
        }
        public static void Write(Message msg, SiegeModeState value)
        {
            Write(msg, (Byte)value);
        }
        public static bool Read(Message msg, out PhaseFieldState value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (PhaseFieldState)temp;
            return true;
        }
        public static void Write(Message msg, PhaseFieldState value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out BloodFogWaveType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (BloodFogWaveType)temp;
            return true;
        }
        public static void Write(Message msg, BloodFogWaveType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out BloodFogMessageType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (BloodFogMessageType)temp;
            return true;
        }
        public static void Write(Message msg, BloodFogMessageType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.WorldV2 value)
        {
            value = new NetProtocol.Packet.WorldV2();
                
            if (!Read(msg, out value.OperateType))
                return false;
            if (!Read(msg, out value.WorldId))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Ip))
                return false;
            if (!Read(msg, out value.Port))
                return false;
            if (!Read(msg, out value.Traffic))
                return false;
            if (!Read(msg, out value.PlayerCount))
                return false;
            if (!Read(msg, out value.UpdateTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.WorldV2 value)
        {
            Write(msg, value.OperateType);
            Write(msg, value.WorldId);
            Write(msg, value.Name);
            Write(msg, value.Ip);
            Write(msg, value.Port);
            Write(msg, value.Traffic);
            Write(msg, value.PlayerCount);
            Write(msg, value.UpdateTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.Server value)
        {
            value = new NetProtocol.Packet.Server();
                
            if (!Read(msg, out value.OperateType))
                return false;
            if (!Read(msg, out value.WorldId))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Ip))
                return false;
            if (!Read(msg, out value.Port))
                return false;
            if (!Read(msg, out value.Traffic))
                return false;
            if (!Read(msg, out value.UserCount))
                return false;
            if (!Read(msg, out value.UpdateTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.Server value)
        {
            Write(msg, value.OperateType);
            Write(msg, value.WorldId);
            Write(msg, value.Name);
            Write(msg, value.Ip);
            Write(msg, value.Port);
            Write(msg, value.Traffic);
            Write(msg, value.UserCount);
            Write(msg, value.UpdateTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.User value)
        {
            value = new NetProtocol.Packet.User();
                
            if (!Read(msg, out value.Id))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.LastSelectAccountSlot))
                return false;
            if (!Read(msg, out value.Accounts))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.User value)
        {
            Write(msg, value.Id);
            Write(msg, value.Type);
            Write(msg, value.LastSelectAccountSlot);
            Write(msg, value.Accounts);
        }
        public static bool Read(Message msg, out List<System.Guid> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<System.Guid>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out System.Guid val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<System.Guid> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.Account value)
        {
            value = new NetProtocol.Packet.Account();
                
            if (!Read(msg, out value.Id))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.LastSelectWorldId))
                return false;
            if (!Read(msg, out value.WorldAccounts))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.Account value)
        {
            Write(msg, value.Id);
            Write(msg, value.Name);
            Write(msg, value.LastSelectWorldId);
            Write(msg, value.WorldAccounts);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.WorldAccount value)
        {
            value = new NetProtocol.Packet.WorldAccount();
                
            if (!Read(msg, out value.WorldId))
                return false;
            if (!Read(msg, out value.Slot))
                return false;
            if (!Read(msg, out value.LastSelectPlayer))
                return false;
            if (!Read(msg, out value.PlayerSlot))
                return false;
            if (!Read(msg, out value.WarehouseSizeLv))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.WorldAccount value)
        {
            Write(msg, value.WorldId);
            Write(msg, value.Slot);
            Write(msg, value.LastSelectPlayer);
            Write(msg, value.PlayerSlot);
            Write(msg, value.WarehouseSizeLv);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.WorldAccount> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.WorldAccount>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.WorldAccount val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.WorldAccount> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out List<System.Int64> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<System.Int64>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out System.Int64 val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<System.Int64> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.MovableObject value)
        {
            if (!Read(msg, out byte derivedType))
            {
                value = default;
                return false;
            }

            switch (derivedType)
            {
                case 1:
                {
                    bool result = Read(msg, out NetProtocol.Packet.Character derived);
                    value = derived;
                    return result;
                }
            }

            value = new NetProtocol.Packet.MovableObject();
                
            if (!Read(msg, out value.Pos))
                return false;
            if (!Read(msg, out value.Dir))
                return false;
            if (!Read(msg, out value.TargetPos))
                return false;
            if (!Read(msg, out value.MoveSpeed))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Id))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.MovableObject value)
        {
            switch (value)
            {
                case NetProtocol.Packet.Character derive:
                {
                    Write(msg, (byte)1);
                    Write(msg, derive);
                    return;
                }
            }
            Write(msg, (byte)2);

            Write(msg, value.Pos);
            Write(msg, value.Dir);
            Write(msg, value.TargetPos);
            Write(msg, value.MoveSpeed);
            Write(msg, value.Type);
            Write(msg, value.Id);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.Character value)
        {
            if (!Read(msg, out byte derivedType))
            {
                value = default;
                return false;
            }

            switch (derivedType)
            {
                case 1:
                {
                    bool result = Read(msg, out NetProtocol.Packet.Player derived);
                    value = derived;
                    return result;
                }
                case 2:
                {
                    bool result = Read(msg, out NetProtocol.Packet.Npc derived);
                    value = derived;
                    return result;
                }
            }

            value = new NetProtocol.Packet.Character();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.Pos))
                return false;
            if (!Read(msg, out value.Dir))
                return false;
            if (!Read(msg, out value.TargetPos))
                return false;
            if (!Read(msg, out value.MoveSpeed))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Id))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.Character value)
        {
            switch (value)
            {
                case NetProtocol.Packet.Player derive:
                {
                    Write(msg, (byte)1);
                    Write(msg, derive);
                    return;
                }
                case NetProtocol.Packet.Npc derive:
                {
                    Write(msg, (byte)2);
                    Write(msg, derive);
                    return;
                }
            }
            Write(msg, (byte)3);

            Write(msg, value.Index);
            Write(msg, value.State);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
            Write(msg, value.Pos);
            Write(msg, value.Dir);
            Write(msg, value.TargetPos);
            Write(msg, value.MoveSpeed);
            Write(msg, value.Type);
            Write(msg, value.Id);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.Player value)
        {
            if (!Read(msg, out byte derivedType))
            {
                value = default;
                return false;
            }

            switch (derivedType)
            {
                case 1:
                {
                    bool result = Read(msg, out NetProtocol.Packet.LobbyPlayer derived);
                    value = derived;
                    return result;
                }
                case 2:
                {
                    bool result = Read(msg, out NetProtocol.Packet.LoginPlayer derived);
                    value = derived;
                    return result;
                }
                case 3:
                {
                    bool result = Read(msg, out NetProtocol.Packet.PartyPlayer derived);
                    value = derived;
                    return result;
                }
            }

            value = new NetProtocol.Packet.Player();
                
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Title))
                return false;
            if (!Read(msg, out value.Lv))
                return false;
            if (!Read(msg, out value.Stat))
                return false;
            if (!Read(msg, out value.MapId))
                return false;
            if (!Read(msg, out value.Customize))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.Pos))
                return false;
            if (!Read(msg, out value.Dir))
                return false;
            if (!Read(msg, out value.TargetPos))
                return false;
            if (!Read(msg, out value.MoveSpeed))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Id))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.Player value)
        {
            switch (value)
            {
                case NetProtocol.Packet.LobbyPlayer derive:
                {
                    Write(msg, (byte)1);
                    Write(msg, derive);
                    return;
                }
                case NetProtocol.Packet.LoginPlayer derive:
                {
                    Write(msg, (byte)2);
                    Write(msg, derive);
                    return;
                }
                case NetProtocol.Packet.PartyPlayer derive:
                {
                    Write(msg, (byte)3);
                    Write(msg, derive);
                    return;
                }
            }
            Write(msg, (byte)4);

            Write(msg, value.Name);
            Write(msg, value.Title);
            Write(msg, value.Lv);
            Write(msg, value.Stat);
            Write(msg, value.MapId);
            Write(msg, value.Customize);
            Write(msg, value.Index);
            Write(msg, value.State);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
            Write(msg, value.Pos);
            Write(msg, value.Dir);
            Write(msg, value.TargetPos);
            Write(msg, value.MoveSpeed);
            Write(msg, value.Type);
            Write(msg, value.Id);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.LobbyPlayer value)
        {
            value = new NetProtocol.Packet.LobbyPlayer();
                
            if (!Read(msg, out value.AccountId))
                return false;
            if (!Read(msg, out value.Face))
                return false;
            if (!Read(msg, out value.LastAccessTime))
                return false;
            if (!Read(msg, out value.CreateTime))
                return false;
            if (!Read(msg, out value.EquipmentIndicies))
                return false;
            if (!Read(msg, out value.EquipmentVisible))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Title))
                return false;
            if (!Read(msg, out value.Lv))
                return false;
            if (!Read(msg, out value.Stat))
                return false;
            if (!Read(msg, out value.MapId))
                return false;
            if (!Read(msg, out value.Customize))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.Pos))
                return false;
            if (!Read(msg, out value.Dir))
                return false;
            if (!Read(msg, out value.TargetPos))
                return false;
            if (!Read(msg, out value.MoveSpeed))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Id))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.LobbyPlayer value)
        {
            Write(msg, value.AccountId);
            Write(msg, value.Face);
            Write(msg, value.LastAccessTime);
            Write(msg, value.CreateTime);
            Write(msg, value.EquipmentIndicies);
            Write(msg, value.EquipmentVisible);
            Write(msg, value.Name);
            Write(msg, value.Title);
            Write(msg, value.Lv);
            Write(msg, value.Stat);
            Write(msg, value.MapId);
            Write(msg, value.Customize);
            Write(msg, value.Index);
            Write(msg, value.State);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
            Write(msg, value.Pos);
            Write(msg, value.Dir);
            Write(msg, value.TargetPos);
            Write(msg, value.MoveSpeed);
            Write(msg, value.Type);
            Write(msg, value.Id);
        }
        public static bool Read(Message msg, out List<System.UInt32> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<System.UInt32>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out System.UInt32 val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<System.UInt32> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out EquipSlot value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (EquipSlot)temp;
            return true;
        }
        public static void Write(Message msg, EquipSlot value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out Dictionary<NetProtocol.Packet.EquipSlot, System.Boolean> value)
        {
            value = new();

            int count = 0;
            Read(msg, out count);

            for (int i = 0; i < count; ++i)
            {
                if (!Read(msg, out NetProtocol.Packet.EquipSlot key))
                    return false;
                if (!Read(msg, out System.Boolean val))
                    return false;

                value.Add(key, val);
            }

            return true;
        }
        public static void Write(Message msg, Dictionary<NetProtocol.Packet.EquipSlot, System.Boolean> value)
        {
            Write(msg, value.Count);

            foreach (var pair in value)
            {
                Write(msg, pair.Key);
                Write(msg, pair.Value);
            }
        }
        public static bool Read(Message msg, out ActorState value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (ActorState)temp;
            return true;
        }
        public static void Write(Message msg, ActorState value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.LoginPlayer value)
        {
            value = new NetProtocol.Packet.LoginPlayer();
                
            if (!Read(msg, out value.Exp))
                return false;
            if (!Read(msg, out value.MaxHp))
                return false;
            if (!Read(msg, out value.MaxMp))
                return false;
            if (!Read(msg, out value.StatPoint))
                return false;
            if (!Read(msg, out value.SkillPoint))
                return false;
            if (!Read(msg, out value.Crime))
                return false;
            if (!Read(msg, out value.Wanted))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Title))
                return false;
            if (!Read(msg, out value.Lv))
                return false;
            if (!Read(msg, out value.Stat))
                return false;
            if (!Read(msg, out value.MapId))
                return false;
            if (!Read(msg, out value.Customize))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.Pos))
                return false;
            if (!Read(msg, out value.Dir))
                return false;
            if (!Read(msg, out value.TargetPos))
                return false;
            if (!Read(msg, out value.MoveSpeed))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Id))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.LoginPlayer value)
        {
            Write(msg, value.Exp);
            Write(msg, value.MaxHp);
            Write(msg, value.MaxMp);
            Write(msg, value.StatPoint);
            Write(msg, value.SkillPoint);
            Write(msg, value.Crime);
            Write(msg, value.Wanted);
            Write(msg, value.Name);
            Write(msg, value.Title);
            Write(msg, value.Lv);
            Write(msg, value.Stat);
            Write(msg, value.MapId);
            Write(msg, value.Customize);
            Write(msg, value.Index);
            Write(msg, value.State);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
            Write(msg, value.Pos);
            Write(msg, value.Dir);
            Write(msg, value.TargetPos);
            Write(msg, value.MoveSpeed);
            Write(msg, value.Type);
            Write(msg, value.Id);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.Crime value)
        {
            value = new NetProtocol.Packet.Crime();
                
            if (!Read(msg, out value.RemainTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.Crime value)
        {
            Write(msg, value.RemainTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.Wanted value)
        {
            value = new NetProtocol.Packet.Wanted();
                
            if (!Read(msg, out value.Lv))
                return false;
            if (!Read(msg, out value.KillCount))
                return false;
            if (!Read(msg, out value.RemainTime))
                return false;
            if (!Read(msg, out value.SeasonKillCount))
                return false;
            if (!Read(msg, out value.SeasonPvpPoint))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.Wanted value)
        {
            Write(msg, value.Lv);
            Write(msg, value.KillCount);
            Write(msg, value.RemainTime);
            Write(msg, value.SeasonKillCount);
            Write(msg, value.SeasonPvpPoint);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.PartyPlayer value)
        {
            if (!Read(msg, out byte derivedType))
            {
                value = default;
                return false;
            }

            switch (derivedType)
            {
                case 1:
                {
                    bool result = Read(msg, out NetProtocol.Packet.MatchRoomPlayer derived);
                    value = derived;
                    return result;
                }
            }

            value = new NetProtocol.Packet.PartyPlayer();
                
            if (!Read(msg, out value.MaxHp))
                return false;
            if (!Read(msg, out value.MaxMp))
                return false;
            if (!Read(msg, out value.IsMember))
                return false;
            if (!Read(msg, out value.InvitedTime))
                return false;
            if (!Read(msg, out value.AccessEndTime))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Title))
                return false;
            if (!Read(msg, out value.Lv))
                return false;
            if (!Read(msg, out value.Stat))
                return false;
            if (!Read(msg, out value.MapId))
                return false;
            if (!Read(msg, out value.Customize))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.Pos))
                return false;
            if (!Read(msg, out value.Dir))
                return false;
            if (!Read(msg, out value.TargetPos))
                return false;
            if (!Read(msg, out value.MoveSpeed))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Id))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.PartyPlayer value)
        {
            switch (value)
            {
                case NetProtocol.Packet.MatchRoomPlayer derive:
                {
                    Write(msg, (byte)1);
                    Write(msg, derive);
                    return;
                }
            }
            Write(msg, (byte)2);

            Write(msg, value.MaxHp);
            Write(msg, value.MaxMp);
            Write(msg, value.IsMember);
            Write(msg, value.InvitedTime);
            Write(msg, value.AccessEndTime);
            Write(msg, value.Name);
            Write(msg, value.Title);
            Write(msg, value.Lv);
            Write(msg, value.Stat);
            Write(msg, value.MapId);
            Write(msg, value.Customize);
            Write(msg, value.Index);
            Write(msg, value.State);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
            Write(msg, value.Pos);
            Write(msg, value.Dir);
            Write(msg, value.TargetPos);
            Write(msg, value.MoveSpeed);
            Write(msg, value.Type);
            Write(msg, value.Id);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.MatchRoomPlayer value)
        {
            value = new NetProtocol.Packet.MatchRoomPlayer();
                
            if (!Read(msg, out value.Strength))
                return false;
            if (!Read(msg, out value.IsChief))
                return false;
            if (!Read(msg, out value.IsReady))
                return false;
            if (!Read(msg, out value.SiegeWarFaction))
                return false;
            if (!Read(msg, out value.MaxHp))
                return false;
            if (!Read(msg, out value.MaxMp))
                return false;
            if (!Read(msg, out value.IsMember))
                return false;
            if (!Read(msg, out value.InvitedTime))
                return false;
            if (!Read(msg, out value.AccessEndTime))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Title))
                return false;
            if (!Read(msg, out value.Lv))
                return false;
            if (!Read(msg, out value.Stat))
                return false;
            if (!Read(msg, out value.MapId))
                return false;
            if (!Read(msg, out value.Customize))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.Pos))
                return false;
            if (!Read(msg, out value.Dir))
                return false;
            if (!Read(msg, out value.TargetPos))
                return false;
            if (!Read(msg, out value.MoveSpeed))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Id))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.MatchRoomPlayer value)
        {
            Write(msg, value.Strength);
            Write(msg, value.IsChief);
            Write(msg, value.IsReady);
            Write(msg, value.SiegeWarFaction);
            Write(msg, value.MaxHp);
            Write(msg, value.MaxMp);
            Write(msg, value.IsMember);
            Write(msg, value.InvitedTime);
            Write(msg, value.AccessEndTime);
            Write(msg, value.Name);
            Write(msg, value.Title);
            Write(msg, value.Lv);
            Write(msg, value.Stat);
            Write(msg, value.MapId);
            Write(msg, value.Customize);
            Write(msg, value.Index);
            Write(msg, value.State);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
            Write(msg, value.Pos);
            Write(msg, value.Dir);
            Write(msg, value.TargetPos);
            Write(msg, value.MoveSpeed);
            Write(msg, value.Type);
            Write(msg, value.Id);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.Npc value)
        {
            value = new NetProtocol.Packet.Npc();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.Pos))
                return false;
            if (!Read(msg, out value.Dir))
                return false;
            if (!Read(msg, out value.TargetPos))
                return false;
            if (!Read(msg, out value.MoveSpeed))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Id))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.Npc value)
        {
            Write(msg, value.Index);
            Write(msg, value.State);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
            Write(msg, value.Pos);
            Write(msg, value.Dir);
            Write(msg, value.TargetPos);
            Write(msg, value.MoveSpeed);
            Write(msg, value.Type);
            Write(msg, value.Id);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.ItemOption value)
        {
            value = new NetProtocol.Packet.ItemOption();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.Value))
                return false;
            if (!Read(msg, out value.Per))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.ItemOption value)
        {
            Write(msg, value.Index);
            Write(msg, value.Value);
            Write(msg, value.Per);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.ItemSkill value)
        {
            value = new NetProtocol.Packet.ItemSkill();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.Lv))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.ItemSkill value)
        {
            Write(msg, value.Index);
            Write(msg, value.Lv);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.ItemUpdate value)
        {
            value = new NetProtocol.Packet.ItemUpdate();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.UpdateCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.ItemUpdate value)
        {
            Write(msg, value.Index);
            Write(msg, value.UpdateCount);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.SkillUseObject value)
        {
            value = new NetProtocol.Packet.SkillUseObject();
                
            if (!Read(msg, out value.Id))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.PrevMp))
                return false;
            if (!Read(msg, out value.CurrMp))
                return false;
            if (!Read(msg, out value.SkillId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.SkillUseObject value)
        {
            Write(msg, value.Id);
            Write(msg, value.State);
            Write(msg, value.PrevMp);
            Write(msg, value.CurrMp);
            Write(msg, value.SkillId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.SkillResultObject value)
        {
            value = new NetProtocol.Packet.SkillResultObject();
                
            if (!Read(msg, out value.Id))
                return false;
            if (!Read(msg, out value.SkillLinkIndex))
                return false;
            if (!Read(msg, out value.SkillResultValue))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.SkillId))
                return false;
            if (!Read(msg, out value.AttackJudgment))
                return false;
            if (!Read(msg, out value.ForceMoveDir))
                return false;
            if (!Read(msg, out value.ForceMovePos))
                return false;
            if (!Read(msg, out value.ResultTime))
                return false;
            if (!Read(msg, out value.Buff))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.SkillResultObject value)
        {
            Write(msg, value.Id);
            Write(msg, value.SkillLinkIndex);
            Write(msg, value.SkillResultValue);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
            Write(msg, value.SkillId);
            Write(msg, value.AttackJudgment);
            Write(msg, value.ForceMoveDir);
            Write(msg, value.ForceMovePos);
            Write(msg, value.ResultTime);
            Write(msg, value.Buff);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.BuffInfo value)
        {
            value = new NetProtocol.Packet.BuffInfo();
                
            if (!Read(msg, out value.BuffId))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.OwnerId))
                return false;
            if (!Read(msg, out value.OwnerState))
                return false;
            if (!Read(msg, out value.ExpireTime))
                return false;
            if (!Read(msg, out value.RetentionTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.BuffInfo value)
        {
            Write(msg, value.BuffId);
            Write(msg, value.Index);
            Write(msg, value.OwnerId);
            Write(msg, value.OwnerState);
            Write(msg, value.ExpireTime);
            Write(msg, value.RetentionTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.TargetInfo value)
        {
            value = new NetProtocol.Packet.TargetInfo();
                
            if (!Read(msg, out value.TargetType))
                return false;
            if (!Read(msg, out value.TargetId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.TargetInfo value)
        {
            Write(msg, value.TargetType);
            Write(msg, value.TargetId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.OwnSkill value)
        {
            value = new NetProtocol.Packet.OwnSkill();
                
            if (!Read(msg, out value.SkillSerial))
                return false;
            if (!Read(msg, out value.IsAuto))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.OwnSkill value)
        {
            Write(msg, value.SkillSerial);
            Write(msg, value.IsAuto);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.DeleteBuffInfo value)
        {
            value = new NetProtocol.Packet.DeleteBuffInfo();
                
            if (!Read(msg, out value.OwnerId))
                return false;
            if (!Read(msg, out value.BuffId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.DeleteBuffInfo value)
        {
            Write(msg, value.OwnerId);
            Write(msg, value.BuffId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.HitListData value)
        {
            value = new NetProtocol.Packet.HitListData();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.PlayerName))
                return false;
            if (!Read(msg, out value.GuildId))
                return false;
            if (!Read(msg, out value.GuildName))
                return false;
            if (!Read(msg, out value.BattleResult))
                return false;
            if (!Read(msg, out value.MapIndex))
                return false;
            if (!Read(msg, out value.TimeStamp))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.HitListData value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.PlayerName);
            Write(msg, value.GuildId);
            Write(msg, value.GuildName);
            Write(msg, value.BattleResult);
            Write(msg, value.MapIndex);
            Write(msg, value.TimeStamp);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.PlayerEvent value)
        {
            value = new NetProtocol.Packet.PlayerEvent();
                
            if (!Read(msg, out value.EventCode))
                return false;
            if (!Read(msg, out value.EventId))
                return false;
            if (!Read(msg, out value.EventEndTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.PlayerEvent value)
        {
            Write(msg, value.EventCode);
            Write(msg, value.EventId);
            Write(msg, value.EventEndTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.ObjInfo value)
        {
            if (!Read(msg, out byte derivedType))
            {
                value = default;
                return false;
            }

            switch (derivedType)
            {
                case 1:
                {
                    bool result = Read(msg, out NetProtocol.Packet.NpcInfo derived);
                    value = derived;
                    return result;
                }
            }

            value = new NetProtocol.Packet.ObjInfo();
                
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Id))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.MoveState))
                return false;
            if (!Read(msg, out value.Pos))
                return false;
            if (!Read(msg, out value.TargetPos))
                return false;
            if (!Read(msg, out value.Dir))
                return false;
            if (!Read(msg, out value.MoveSpeed))
                return false;
            if (!Read(msg, out value.PerformTime))
                return false;
            if (!Read(msg, out value.IsBattleMode))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Lv))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.MaxHp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.MaxMp))
                return false;
            if (!Read(msg, out value.MapId))
                return false;
            if (!Read(msg, out value.customizationFace))
                return false;
            if (!Read(msg, out value.Buffs))
                return false;
            if (!Read(msg, out value.IsHoldAction))
                return false;
            if (!Read(msg, out value.SiegeWarFaction))
                return false;
            if (!Read(msg, out value.SiegeMode))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.ObjInfo value)
        {
            switch (value)
            {
                case NetProtocol.Packet.NpcInfo derive:
                {
                    Write(msg, (byte)1);
                    Write(msg, derive);
                    return;
                }
            }
            Write(msg, (byte)2);

            Write(msg, value.Type);
            Write(msg, value.Id);
            Write(msg, value.State);
            Write(msg, value.MoveState);
            Write(msg, value.Pos);
            Write(msg, value.TargetPos);
            Write(msg, value.Dir);
            Write(msg, value.MoveSpeed);
            Write(msg, value.PerformTime);
            Write(msg, value.IsBattleMode);
            Write(msg, value.Index);
            Write(msg, value.Name);
            Write(msg, value.Lv);
            Write(msg, value.Hp);
            Write(msg, value.MaxHp);
            Write(msg, value.Mp);
            Write(msg, value.MaxMp);
            Write(msg, value.MapId);
            Write(msg, value.customizationFace);
            Write(msg, value.Buffs);
            Write(msg, value.IsHoldAction);
            Write(msg, value.SiegeWarFaction);
            Write(msg, value.SiegeMode);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.NpcInfo value)
        {
            if (!Read(msg, out byte derivedType))
            {
                value = default;
                return false;
            }

            switch (derivedType)
            {
                case 1:
                {
                    bool result = Read(msg, out NetProtocol.Packet.PropInfo derived);
                    value = derived;
                    return result;
                }
            }

            value = new NetProtocol.Packet.NpcInfo();
                
            if (!Read(msg, out value.MonsterType))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Id))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.MoveState))
                return false;
            if (!Read(msg, out value.Pos))
                return false;
            if (!Read(msg, out value.TargetPos))
                return false;
            if (!Read(msg, out value.Dir))
                return false;
            if (!Read(msg, out value.MoveSpeed))
                return false;
            if (!Read(msg, out value.PerformTime))
                return false;
            if (!Read(msg, out value.IsBattleMode))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Lv))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.MaxHp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.MaxMp))
                return false;
            if (!Read(msg, out value.MapId))
                return false;
            if (!Read(msg, out value.customizationFace))
                return false;
            if (!Read(msg, out value.Buffs))
                return false;
            if (!Read(msg, out value.IsHoldAction))
                return false;
            if (!Read(msg, out value.SiegeWarFaction))
                return false;
            if (!Read(msg, out value.SiegeMode))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.NpcInfo value)
        {
            switch (value)
            {
                case NetProtocol.Packet.PropInfo derive:
                {
                    Write(msg, (byte)1);
                    Write(msg, derive);
                    return;
                }
            }
            Write(msg, (byte)2);

            Write(msg, value.MonsterType);
            Write(msg, value.Type);
            Write(msg, value.Id);
            Write(msg, value.State);
            Write(msg, value.MoveState);
            Write(msg, value.Pos);
            Write(msg, value.TargetPos);
            Write(msg, value.Dir);
            Write(msg, value.MoveSpeed);
            Write(msg, value.PerformTime);
            Write(msg, value.IsBattleMode);
            Write(msg, value.Index);
            Write(msg, value.Name);
            Write(msg, value.Lv);
            Write(msg, value.Hp);
            Write(msg, value.MaxHp);
            Write(msg, value.Mp);
            Write(msg, value.MaxMp);
            Write(msg, value.MapId);
            Write(msg, value.customizationFace);
            Write(msg, value.Buffs);
            Write(msg, value.IsHoldAction);
            Write(msg, value.SiegeWarFaction);
            Write(msg, value.SiegeMode);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.PropInfo value)
        {
            value = new NetProtocol.Packet.PropInfo();
                
            if (!Read(msg, out value.InteractPropType))
                return false;
            if (!Read(msg, out value.MonsterType))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Id))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.MoveState))
                return false;
            if (!Read(msg, out value.Pos))
                return false;
            if (!Read(msg, out value.TargetPos))
                return false;
            if (!Read(msg, out value.Dir))
                return false;
            if (!Read(msg, out value.MoveSpeed))
                return false;
            if (!Read(msg, out value.PerformTime))
                return false;
            if (!Read(msg, out value.IsBattleMode))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Lv))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.MaxHp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.MaxMp))
                return false;
            if (!Read(msg, out value.MapId))
                return false;
            if (!Read(msg, out value.customizationFace))
                return false;
            if (!Read(msg, out value.Buffs))
                return false;
            if (!Read(msg, out value.IsHoldAction))
                return false;
            if (!Read(msg, out value.SiegeWarFaction))
                return false;
            if (!Read(msg, out value.SiegeMode))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.PropInfo value)
        {
            Write(msg, value.InteractPropType);
            Write(msg, value.MonsterType);
            Write(msg, value.Type);
            Write(msg, value.Id);
            Write(msg, value.State);
            Write(msg, value.MoveState);
            Write(msg, value.Pos);
            Write(msg, value.TargetPos);
            Write(msg, value.Dir);
            Write(msg, value.MoveSpeed);
            Write(msg, value.PerformTime);
            Write(msg, value.IsBattleMode);
            Write(msg, value.Index);
            Write(msg, value.Name);
            Write(msg, value.Lv);
            Write(msg, value.Hp);
            Write(msg, value.MaxHp);
            Write(msg, value.Mp);
            Write(msg, value.MaxMp);
            Write(msg, value.MapId);
            Write(msg, value.customizationFace);
            Write(msg, value.Buffs);
            Write(msg, value.IsHoldAction);
            Write(msg, value.SiegeWarFaction);
            Write(msg, value.SiegeMode);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.CustomizationFace value)
        {
            value = new NetProtocol.Packet.CustomizationFace();
                
            if (!Read(msg, out value.SkinColor))
                return false;
            if (!Read(msg, out value.HairType))
                return false;
            if (!Read(msg, out value.HairColor))
                return false;
            if (!Read(msg, out value.BoneGroupData))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.CustomizationFace value)
        {
            Write(msg, value.SkinColor);
            Write(msg, value.HairType);
            Write(msg, value.HairColor);
            Write(msg, value.BoneGroupData);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.CustomizationBoneInfo value)
        {
            value = new NetProtocol.Packet.CustomizationBoneInfo();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.Offset))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.CustomizationBoneInfo value)
        {
            Write(msg, value.Index);
            Write(msg, value.Offset);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.CustomizationBoneInfo[] value)
        {
            int count = 0;
            Read(msg, out count);

            value = new NetProtocol.Packet.CustomizationBoneInfo[count];

            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.CustomizationBoneInfo val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.CustomizationBoneInfo[] value)
        {
            Write(msg, value.Length);
            for (int i = 0; i < value.Length; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.BuffInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.BuffInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.BuffInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.BuffInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.LoginSceneCharacterInfoV2 value)
        {
            value = new NetProtocol.Packet.LoginSceneCharacterInfoV2();
                
            if (!Read(msg, out value.WorldId))
                return false;
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.ClassId))
                return false;
            if (!Read(msg, out value.LastPlayedAt))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.LoginSceneCharacterInfoV2 value)
        {
            Write(msg, value.WorldId);
            Write(msg, value.PlayerId);
            Write(msg, value.Name);
            Write(msg, value.Level);
            Write(msg, value.ClassId);
            Write(msg, value.LastPlayedAt);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.LoginSceneCharacterInfo value)
        {
            value = new NetProtocol.Packet.LoginSceneCharacterInfo();
                
            if (!Read(msg, out value.WorldId))
                return false;
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Lv))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.LastAccessTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.LoginSceneCharacterInfo value)
        {
            Write(msg, value.WorldId);
            Write(msg, value.PlayerId);
            Write(msg, value.Name);
            Write(msg, value.Lv);
            Write(msg, value.Index);
            Write(msg, value.LastAccessTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.EventAttainmentInfoV2 value)
        {
            value = new NetProtocol.Packet.EventAttainmentInfoV2();
                
            if (!Read(msg, out value.EventId))
                return false;
            if (!Read(msg, out value.Day))
                return false;
            if (!Read(msg, out value.EventCondition))
                return false;
            if (!Read(msg, out value.EventConditionValue))
                return false;
            if (!Read(msg, out value.IsRewarded))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.EventAttainmentInfoV2 value)
        {
            Write(msg, value.EventId);
            Write(msg, value.Day);
            Write(msg, value.EventCondition);
            Write(msg, value.EventConditionValue);
            Write(msg, value.IsRewarded);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.QuestInfoV2 value)
        {
            value = new NetProtocol.Packet.QuestInfoV2();
                
            if (!Read(msg, out value.QuestType))
                return false;
            if (!Read(msg, out value.QuestId))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.Value))
                return false;
            if (!Read(msg, out value.TargetPosInfo))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.QuestInfoV2 value)
        {
            Write(msg, value.QuestType);
            Write(msg, value.QuestId);
            Write(msg, value.State);
            Write(msg, value.Value);
            Write(msg, value.TargetPosInfo);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.TargetPosInfo value)
        {
            value = new NetProtocol.Packet.TargetPosInfo();
                
            if (!Read(msg, out value.MapIndex))
                return false;
            if (!Read(msg, out value.Pos))
                return false;
            if (!Read(msg, out value.Dir))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.TargetPosInfo value)
        {
            Write(msg, value.MapIndex);
            Write(msg, value.Pos);
            Write(msg, value.Dir);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.TargetPosInfo[] value)
        {
            int count = 0;
            Read(msg, out count);

            value = new NetProtocol.Packet.TargetPosInfo[count];

            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.TargetPosInfo val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.TargetPosInfo[] value)
        {
            Write(msg, value.Length);
            for (int i = 0; i < value.Length; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.MatchRoom value)
        {
            value = new NetProtocol.Packet.MatchRoom();
                
            if (!Read(msg, out value.RoomId))
                return false;
            if (!Read(msg, out value.DungeonIndex))
                return false;
            if (!Read(msg, out value.Members))
                return false;
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.MatchRoom value)
        {
            Write(msg, value.RoomId);
            Write(msg, value.DungeonIndex);
            Write(msg, value.Members);
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.MatchRoomPlayer> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.MatchRoomPlayer>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.MatchRoomPlayer val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.MatchRoomPlayer> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.RoomListInfo value)
        {
            value = new NetProtocol.Packet.RoomListInfo();
                
            if (!Read(msg, out value.RoomId))
                return false;
            if (!Read(msg, out value.Lv))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.DungeonIndex))
                return false;
            if (!Read(msg, out value.charIndex))
                return false;
            if (!Read(msg, out value.Count))
                return false;
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.RoomListInfo value)
        {
            Write(msg, value.RoomId);
            Write(msg, value.Lv);
            Write(msg, value.Name);
            Write(msg, value.DungeonIndex);
            Write(msg, value.charIndex);
            Write(msg, value.Count);
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.GuildTendency value)
        {
            value = new NetProtocol.Packet.GuildTendency();
                
            if (!Read(msg, out value.Tendency))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.GuildTendency value)
        {
            Write(msg, value.Tendency);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.Mail value)
        {
            value = new NetProtocol.Packet.Mail();
                
            if (!Read(msg, out value.Id))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.SubType))
                return false;
            if (!Read(msg, out value.Title))
                return false;
            if (!Read(msg, out value.Body))
                return false;
            if (!Read(msg, out value.Items))
                return false;
            if (!Read(msg, out value.ExpireTime))
                return false;
            if (!Read(msg, out value.SendTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.Mail value)
        {
            Write(msg, value.Id);
            Write(msg, value.Type);
            Write(msg, value.SubType);
            Write(msg, value.Title);
            Write(msg, value.Body);
            Write(msg, value.Items);
            Write(msg, value.ExpireTime);
            Write(msg, value.SendTime);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Item.Features.SimpleItem value)
        {
            value = new NetProtocol.Models.Item.Features.SimpleItem();
                
            if (!Read(msg, out value.ItemIndex))
                return false;
            if (!Read(msg, out value.Count))
                return false;
            if (!Read(msg, out value.Belong))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Item.Features.SimpleItem value)
        {
            Write(msg, value.ItemIndex);
            Write(msg, value.Count);
            Write(msg, value.Belong);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Item.Features.SimpleItem[] value)
        {
            int count = 0;
            Read(msg, out count);

            value = new NetProtocol.Models.Item.Features.SimpleItem[count];

            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Item.Features.SimpleItem val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Item.Features.SimpleItem[] value)
        {
            Write(msg, value.Length);
            for (int i = 0; i < value.Length; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.MailItem value)
        {
            value = new NetProtocol.Packet.MailItem();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.Count))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.MailItem value)
        {
            Write(msg, value.Index);
            Write(msg, value.Count);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.PetData value)
        {
            value = new NetProtocol.Packet.PetData();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.Stack))
                return false;
            if (!Read(msg, out value.Saturation))
                return false;
            if (!Read(msg, out value.SaturationTime))
                return false;
            if (!Read(msg, out value.IsEquipped))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.PetData value)
        {
            Write(msg, value.Index);
            Write(msg, value.Level);
            Write(msg, value.Stack);
            Write(msg, value.Saturation);
            Write(msg, value.SaturationTime);
            Write(msg, value.IsEquipped);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.PetCostData value)
        {
            value = new NetProtocol.Packet.PetCostData();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.Count))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.PetCostData value)
        {
            Write(msg, value.Index);
            Write(msg, value.Count);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.PetMixData value)
        {
            value = new NetProtocol.Packet.PetMixData();
                
            if (!Read(msg, out value.MixGrade))
                return false;
            if (!Read(msg, out value.MixCount))
                return false;
            if (!Read(msg, out value.Costs))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.PetMixData value)
        {
            Write(msg, value.MixGrade);
            Write(msg, value.MixCount);
            Write(msg, value.Costs);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.PetCostData> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.PetCostData>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.PetCostData val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.PetCostData> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.PetCollect value)
        {
            value = new NetProtocol.Packet.PetCollect();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.CheckBox))
                return false;
            if (!Read(msg, out value.IsComplete))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.PetCollect value)
        {
            Write(msg, value.Index);
            Write(msg, value.CheckBox);
            Write(msg, value.IsComplete);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.RideData value)
        {
            value = new NetProtocol.Packet.RideData();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.Stack))
                return false;
            if (!Read(msg, out value.AttachHead))
                return false;
            if (!Read(msg, out value.AttachBack))
                return false;
            if (!Read(msg, out value.AttachTail))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.RideData value)
        {
            Write(msg, value.Index);
            Write(msg, value.Stack);
            Write(msg, value.AttachHead);
            Write(msg, value.AttachBack);
            Write(msg, value.AttachTail);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.RideCostData value)
        {
            value = new NetProtocol.Packet.RideCostData();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.Count))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.RideCostData value)
        {
            Write(msg, value.Index);
            Write(msg, value.Count);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.RideMixData value)
        {
            value = new NetProtocol.Packet.RideMixData();
                
            if (!Read(msg, out value.MixGrade))
                return false;
            if (!Read(msg, out value.MixCount))
                return false;
            if (!Read(msg, out value.Costs))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.RideMixData value)
        {
            Write(msg, value.MixGrade);
            Write(msg, value.MixCount);
            Write(msg, value.Costs);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.RideCostData> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.RideCostData>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.RideCostData val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.RideCostData> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.RideAttachData value)
        {
            value = new NetProtocol.Packet.RideAttachData();
                
            if (!Read(msg, out value.AttachID))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.RideAttachData value)
        {
            Write(msg, value.AttachID);
            Write(msg, value.Index);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.CostumeData value)
        {
            value = new NetProtocol.Packet.CostumeData();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.TimeCreate))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.CostumeData value)
        {
            Write(msg, value.Index);
            Write(msg, value.TimeCreate);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.CostumeCard value)
        {
            value = new NetProtocol.Packet.CostumeCard();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.Count))
                return false;
            if (!Read(msg, out value.Build))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.CostumeCard value)
        {
            Write(msg, value.Index);
            Write(msg, value.Count);
            Write(msg, value.Build);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.CostumeCost value)
        {
            value = new NetProtocol.Packet.CostumeCost();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.Count))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.CostumeCost value)
        {
            Write(msg, value.Index);
            Write(msg, value.Count);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.CostumeConfirm value)
        {
            value = new NetProtocol.Packet.CostumeConfirm();
                
            if (!Read(msg, out value.ConfirmID))
                return false;
            if (!Read(msg, out value.CostumeIndex))
                return false;
            if (!Read(msg, out value.ReRollNow))
                return false;
            if (!Read(msg, out value.ReRollMax))
                return false;
            if (!Read(msg, out value.TimeExpire))
                return false;
            if (!Read(msg, out value.TimeCreate))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.CostumeConfirm value)
        {
            Write(msg, value.ConfirmID);
            Write(msg, value.CostumeIndex);
            Write(msg, value.ReRollNow);
            Write(msg, value.ReRollMax);
            Write(msg, value.TimeExpire);
            Write(msg, value.TimeCreate);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.CostumeAppearanceInfo value)
        {
            value = new NetProtocol.Packet.CostumeAppearanceInfo();
                
            if (!Read(msg, out value.Head))
                return false;
            if (!Read(msg, out value.HeadShow))
                return false;
            if (!Read(msg, out value.Body))
                return false;
            if (!Read(msg, out value.BodyShow))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.CostumeAppearanceInfo value)
        {
            Write(msg, value.Head);
            Write(msg, value.HeadShow);
            Write(msg, value.Body);
            Write(msg, value.BodyShow);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.CostumeMixData value)
        {
            value = new NetProtocol.Packet.CostumeMixData();
                
            if (!Read(msg, out value.MixGrade))
                return false;
            if (!Read(msg, out value.MixCount))
                return false;
            if (!Read(msg, out value.Costs))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.CostumeMixData value)
        {
            Write(msg, value.MixGrade);
            Write(msg, value.MixCount);
            Write(msg, value.Costs);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.CostumeCost> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.CostumeCost>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.CostumeCost val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.CostumeCost> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.WeaponAppearanceInfo value)
        {
            value = new NetProtocol.Packet.WeaponAppearanceInfo();
                
            if (!Read(msg, out value.WeaponAppearanceIndex))
                return false;
            if (!Read(msg, out value.IsHidden))
                return false;
            if (!Read(msg, out value.IsEquiped))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.WeaponAppearanceInfo value)
        {
            Write(msg, value.WeaponAppearanceIndex);
            Write(msg, value.IsHidden);
            Write(msg, value.IsEquiped);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.ItemCollect value)
        {
            value = new NetProtocol.Packet.ItemCollect();
                
            if (!Read(msg, out value.ItemCollectTableIndex))
                return false;
            if (!Read(msg, out value.ItemTableIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.ItemCollect value)
        {
            Write(msg, value.ItemCollectTableIndex);
            Write(msg, value.ItemTableIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.TitleConditionInfo value)
        {
            value = new NetProtocol.Packet.TitleConditionInfo();
                
            if (!Read(msg, out value.TitleIndex))
                return false;
            if (!Read(msg, out value.Value))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.TitleConditionInfo value)
        {
            Write(msg, value.TitleIndex);
            Write(msg, value.Value);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.AttendanceBaseData value)
        {
            value = new NetProtocol.Packet.AttendanceBaseData();
                
            if (!Read(msg, out value.Day))
                return false;
            if (!Read(msg, out value.RewardTime))
                return false;
            if (!Read(msg, out value.IsReward))
                return false;
            if (!Read(msg, out value.IsAttendance))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.AttendanceBaseData value)
        {
            Write(msg, value.Day);
            Write(msg, value.RewardTime);
            Write(msg, value.IsReward);
            Write(msg, value.IsAttendance);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.AttendanceEvent value)
        {
            value = new NetProtocol.Packet.AttendanceEvent();
                
            if (!Read(msg, out value.EventIndex))
                return false;
            if (!Read(msg, out value.TotalAttendanceDay))
                return false;
            if (!Read(msg, out value.Attendances))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.AttendanceEvent value)
        {
            Write(msg, value.EventIndex);
            Write(msg, value.TotalAttendanceDay);
            Write(msg, value.Attendances);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.AttendanceBaseData> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.AttendanceBaseData>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.AttendanceBaseData val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.AttendanceBaseData> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.AttainmentNormal value)
        {
            value = new NetProtocol.Packet.AttainmentNormal();
                
            if (!Read(msg, out value.AchieveConditionIndex))
                return false;
            if (!Read(msg, out value.Count))
                return false;
            if (!Read(msg, out value.RewardTime))
                return false;
            if (!Read(msg, out value.IsReward))
                return false;
            if (!Read(msg, out value.IsComplete))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.AttainmentNormal value)
        {
            Write(msg, value.AchieveConditionIndex);
            Write(msg, value.Count);
            Write(msg, value.RewardTime);
            Write(msg, value.IsReward);
            Write(msg, value.IsComplete);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.AttainmentNormalEvent value)
        {
            value = new NetProtocol.Packet.AttainmentNormalEvent();
                
            if (!Read(msg, out value.EventIndex))
                return false;
            if (!Read(msg, out value.AttainmentNormalEvents))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.AttainmentNormalEvent value)
        {
            Write(msg, value.EventIndex);
            Write(msg, value.AttainmentNormalEvents);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.AttainmentNormal> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.AttainmentNormal>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.AttainmentNormal val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.AttainmentNormal> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.AttainmentDaily value)
        {
            value = new NetProtocol.Packet.AttainmentDaily();
                
            if (!Read(msg, out value.Day))
                return false;
            if (!Read(msg, out value.AchieveConditionIndex))
                return false;
            if (!Read(msg, out value.Count))
                return false;
            if (!Read(msg, out value.RewardTime))
                return false;
            if (!Read(msg, out value.IsReward))
                return false;
            if (!Read(msg, out value.IsComplete))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.AttainmentDaily value)
        {
            Write(msg, value.Day);
            Write(msg, value.AchieveConditionIndex);
            Write(msg, value.Count);
            Write(msg, value.RewardTime);
            Write(msg, value.IsReward);
            Write(msg, value.IsComplete);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.AttainmentDailyEvent value)
        {
            value = new NetProtocol.Packet.AttainmentDailyEvent();
                
            if (!Read(msg, out value.EventIndex))
                return false;
            if (!Read(msg, out value.AttainmentDailyEvents))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.AttainmentDailyEvent value)
        {
            Write(msg, value.EventIndex);
            Write(msg, value.AttainmentDailyEvents);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.AttainmentDaily> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.AttainmentDaily>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.AttainmentDaily val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.AttainmentDaily> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.EventGrowth value)
        {
            value = new NetProtocol.Packet.EventGrowth();
                
            if (!Read(msg, out value.EventIndex))
                return false;
            if (!Read(msg, out value.MapIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.EventGrowth value)
        {
            Write(msg, value.EventIndex);
            Write(msg, value.MapIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.EventExchange value)
        {
            value = new NetProtocol.Packet.EventExchange();
                
            if (!Read(msg, out value.ExchangeCount))
                return false;
            if (!Read(msg, out value.ExchangeItem))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.EventExchange value)
        {
            Write(msg, value.ExchangeCount);
            Write(msg, value.ExchangeItem);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.EventExchangeEvent value)
        {
            value = new NetProtocol.Packet.EventExchangeEvent();
                
            if (!Read(msg, out value.EventIndex))
                return false;
            if (!Read(msg, out value.EventMap))
                return false;
            if (!Read(msg, out value.EventExchanges))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.EventExchangeEvent value)
        {
            Write(msg, value.EventIndex);
            Write(msg, value.EventMap);
            Write(msg, value.EventExchanges);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.EventExchange> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.EventExchange>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.EventExchange val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.EventExchange> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.SiegeWarMatchInfoBase value)
        {
            if (!Read(msg, out byte derivedType))
            {
                value = default;
                return false;
            }

            switch (derivedType)
            {
                case 1:
                {
                    bool result = Read(msg, out NetProtocol.Packet.SiegeWarMatchInfo derived);
                    value = derived;
                    return result;
                }
            }

            value = new NetProtocol.Packet.SiegeWarMatchInfoBase();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.ApplyStartTime))
                return false;
            if (!Read(msg, out value.ApplyEndTime))
                return false;
            if (!Read(msg, out value.WarStartTime))
                return false;
            if (!Read(msg, out value.ApplyAttackerCount))
                return false;
            if (!Read(msg, out value.ApplyDefenderCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.SiegeWarMatchInfoBase value)
        {
            switch (value)
            {
                case NetProtocol.Packet.SiegeWarMatchInfo derive:
                {
                    Write(msg, (byte)1);
                    Write(msg, derive);
                    return;
                }
            }
            Write(msg, (byte)2);

            Write(msg, value.Index);
            Write(msg, value.ApplyStartTime);
            Write(msg, value.ApplyEndTime);
            Write(msg, value.WarStartTime);
            Write(msg, value.ApplyAttackerCount);
            Write(msg, value.ApplyDefenderCount);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.SiegeWarMatchInfo value)
        {
            value = new NetProtocol.Packet.SiegeWarMatchInfo();
                
            if (!Read(msg, out value.SelectedMyFaction))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.ApplyStartTime))
                return false;
            if (!Read(msg, out value.ApplyEndTime))
                return false;
            if (!Read(msg, out value.WarStartTime))
                return false;
            if (!Read(msg, out value.ApplyAttackerCount))
                return false;
            if (!Read(msg, out value.ApplyDefenderCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.SiegeWarMatchInfo value)
        {
            Write(msg, value.SelectedMyFaction);
            Write(msg, value.Index);
            Write(msg, value.ApplyStartTime);
            Write(msg, value.ApplyEndTime);
            Write(msg, value.WarStartTime);
            Write(msg, value.ApplyAttackerCount);
            Write(msg, value.ApplyDefenderCount);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.SiegeWarObject value)
        {
            value = new NetProtocol.Packet.SiegeWarObject();
                
            if (!Read(msg, out value.ObjectType))
                return false;
            if (!Read(msg, out value.Faction))
                return false;
            if (!Read(msg, out value.IsActive))
                return false;
            if (!Read(msg, out value.Pos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.SiegeWarObject value)
        {
            Write(msg, value.ObjectType);
            Write(msg, value.Faction);
            Write(msg, value.IsActive);
            Write(msg, value.Pos);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.SiegeWarInfo value)
        {
            value = new NetProtocol.Packet.SiegeWarInfo();
                
            if (!Read(msg, out value.Objects))
                return false;
            if (!Read(msg, out value.StartTime))
                return false;
            if (!Read(msg, out value.AttackerNextRevivalTime))
                return false;
            if (!Read(msg, out value.DefenderNextRevivalTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.SiegeWarInfo value)
        {
            Write(msg, value.Objects);
            Write(msg, value.StartTime);
            Write(msg, value.AttackerNextRevivalTime);
            Write(msg, value.DefenderNextRevivalTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.SiegeWarObject[] value)
        {
            int count = 0;
            Read(msg, out count);

            value = new NetProtocol.Packet.SiegeWarObject[count];

            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.SiegeWarObject val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.SiegeWarObject[] value)
        {
            Write(msg, value.Length);
            for (int i = 0; i < value.Length; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.AccountPvpRankInfo value)
        {
            value = new NetProtocol.Packet.AccountPvpRankInfo();
                
            if (!Read(msg, out value.Rank))
                return false;
            if (!Read(msg, out value.AccountId))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.PvpPoint))
                return false;
            if (!Read(msg, out value.AssistPoint))
                return false;
            if (!Read(msg, out value.KillPoint))
                return false;
            if (!Read(msg, out value.DeathPoint))
                return false;
            if (!Read(msg, out value.GuildInfo))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.AccountPvpRankInfo value)
        {
            Write(msg, value.Rank);
            Write(msg, value.AccountId);
            Write(msg, value.Name);
            Write(msg, value.PvpPoint);
            Write(msg, value.AssistPoint);
            Write(msg, value.KillPoint);
            Write(msg, value.DeathPoint);
            Write(msg, value.GuildInfo);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Actor.Features.DGuild value)
        {
            value = new NetProtocol.Models.Actor.Features.DGuild();
                
            if (!Read(msg, out value.GuildId))
                return false;
            if (!Read(msg, out value.CrestImage))
                return false;
            if (!Read(msg, out value.CrestFrame))
                return false;
            if (!Read(msg, out value.GuildName))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Actor.Features.DGuild value)
        {
            Write(msg, value.GuildId);
            Write(msg, value.CrestImage);
            Write(msg, value.CrestFrame);
            Write(msg, value.GuildName);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.BindStone value)
        {
            value = new NetProtocol.Packet.BindStone();
                
            if (!Read(msg, out value.BindStoneIndex))
                return false;
            if (!Read(msg, out value.CreatedAt))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.BindStone value)
        {
            Write(msg, value.BindStoneIndex);
            Write(msg, value.CreatedAt);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.BlackRosterDeathInfo value)
        {
            value = new NetProtocol.Packet.BlackRosterDeathInfo();
                
            if (!Read(msg, out value.UniqueId))
                return false;
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.PlayerName))
                return false;
            if (!Read(msg, out value.GuildId))
                return false;
            if (!Read(msg, out value.GuildName))
                return false;
            if (!Read(msg, out value.GuildCrest))
                return false;
            if (!Read(msg, out value.GuildFrame))
                return false;
            if (!Read(msg, out value.ZoneIndex))
                return false;
            if (!Read(msg, out value.IsObserved))
                return false;
            if (!Read(msg, out value.Revenged_Time))
                return false;
            if (!Read(msg, out value.LossPoint))
                return false;
            if (!Read(msg, out value.At))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.BlackRosterDeathInfo value)
        {
            Write(msg, value.UniqueId);
            Write(msg, value.ActorId);
            Write(msg, value.PlayerName);
            Write(msg, value.GuildId);
            Write(msg, value.GuildName);
            Write(msg, value.GuildCrest);
            Write(msg, value.GuildFrame);
            Write(msg, value.ZoneIndex);
            Write(msg, value.IsObserved);
            Write(msg, value.Revenged_Time);
            Write(msg, value.LossPoint);
            Write(msg, value.At);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.BlackRosterKillInfo value)
        {
            value = new NetProtocol.Packet.BlackRosterKillInfo();
                
            if (!Read(msg, out value.UniqueId))
                return false;
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.PlayerName))
                return false;
            if (!Read(msg, out value.GuildId))
                return false;
            if (!Read(msg, out value.GuildName))
                return false;
            if (!Read(msg, out value.GuildCrest))
                return false;
            if (!Read(msg, out value.GuildFrame))
                return false;
            if (!Read(msg, out value.ZoneIndex))
                return false;
            if (!Read(msg, out value.IsAssist))
                return false;
            if (!Read(msg, out value.Point))
                return false;
            if (!Read(msg, out value.IsProvocated))
                return false;
            if (!Read(msg, out value.At))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.BlackRosterKillInfo value)
        {
            Write(msg, value.UniqueId);
            Write(msg, value.ActorId);
            Write(msg, value.PlayerName);
            Write(msg, value.GuildId);
            Write(msg, value.GuildName);
            Write(msg, value.GuildCrest);
            Write(msg, value.GuildFrame);
            Write(msg, value.ZoneIndex);
            Write(msg, value.IsAssist);
            Write(msg, value.Point);
            Write(msg, value.IsProvocated);
            Write(msg, value.At);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.BlackRosterPreferenceInfo value)
        {
            value = new NetProtocol.Packet.BlackRosterPreferenceInfo();
                
            if (!Read(msg, out value.IsAuto))
                return false;
            if (!Read(msg, out value.KillMessage))
                return false;
            if (!Read(msg, out value.DeathMessage))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.BlackRosterPreferenceInfo value)
        {
            Write(msg, value.IsAuto);
            Write(msg, value.KillMessage);
            Write(msg, value.DeathMessage);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.BossDamagedInfo value)
        {
            value = new NetProtocol.Packet.BossDamagedInfo();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.Property))
                return false;
            if (!Read(msg, out value.GuildInfo))
                return false;
            if (!Read(msg, out value.Damage))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.BossDamagedInfo value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.Name);
            Write(msg, value.Level);
            Write(msg, value.Property);
            Write(msg, value.GuildInfo);
            Write(msg, value.Damage);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Actor.Features.DActorProperty value)
        {
            value = new NetProtocol.Models.Actor.Features.DActorProperty();
                
            if (!Read(msg, out value.Id))
                return false;
            if (!Read(msg, out value.DataId))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Actor.Features.DActorProperty value)
        {
            Write(msg, value.Id);
            Write(msg, value.DataId);
            Write(msg, value.Type);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.BossScheduleInfo value)
        {
            value = new NetProtocol.Packet.BossScheduleInfo();
                
            if (!Read(msg, out value.BossScheduleIndex))
                return false;
            if (!Read(msg, out value.ServerIndex))
                return false;
            if (!Read(msg, out value.BossIndex))
                return false;
            if (!Read(msg, out value.MapIndex))
                return false;
            if (!Read(msg, out value.Position))
                return false;
            if (!Read(msg, out value.NoticeAt))
                return false;
            if (!Read(msg, out value.SpawnAt))
                return false;
            if (!Read(msg, out value.DeSpawnAt))
                return false;
            if (!Read(msg, out value.SpawnTimeSpanMilliseconds))
                return false;
            if (!Read(msg, out value.NoticeTimeSpanMilliseconds))
                return false;
            if (!Read(msg, out value.DeSpawnTimeSpanMilliseconds))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.BossScheduleInfo value)
        {
            Write(msg, value.BossScheduleIndex);
            Write(msg, value.ServerIndex);
            Write(msg, value.BossIndex);
            Write(msg, value.MapIndex);
            Write(msg, value.Position);
            Write(msg, value.NoticeAt);
            Write(msg, value.SpawnAt);
            Write(msg, value.DeSpawnAt);
            Write(msg, value.SpawnTimeSpanMilliseconds);
            Write(msg, value.NoticeTimeSpanMilliseconds);
            Write(msg, value.DeSpawnTimeSpanMilliseconds);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.PlayerAlarmInfo value)
        {
            value = new NetProtocol.Packet.PlayerAlarmInfo();
                
            if (!Read(msg, out value.CanExpRecover))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.PlayerAlarmInfo value)
        {
            Write(msg, value.CanExpRecover);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.PlayerDeathInfo value)
        {
            value = new NetProtocol.Packet.PlayerDeathInfo();
                
            if (!Read(msg, out value.AttackerActorType))
                return false;
            if (!Read(msg, out value.AttackerActorId))
                return false;
            if (!Read(msg, out value.AttackerPlayerId))
                return false;
            if (!Read(msg, out value.AttackerMonsterIndex))
                return false;
            if (!Read(msg, out value.AttackerName))
                return false;
            if (!Read(msg, out value.ZoneIndex))
                return false;
            if (!Read(msg, out value.DeathAt))
                return false;
            if (!Read(msg, out value.LossExp))
                return false;
            if (!Read(msg, out value.ExceptedCostType))
                return false;
            if (!Read(msg, out value.ExceptedCost))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.PlayerDeathInfo value)
        {
            Write(msg, value.AttackerActorType);
            Write(msg, value.AttackerActorId);
            Write(msg, value.AttackerPlayerId);
            Write(msg, value.AttackerMonsterIndex);
            Write(msg, value.AttackerName);
            Write(msg, value.ZoneIndex);
            Write(msg, value.DeathAt);
            Write(msg, value.LossExp);
            Write(msg, value.ExceptedCostType);
            Write(msg, value.ExceptedCost);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.PlayerExpRecoveryInfo value)
        {
            value = new NetProtocol.Packet.PlayerExpRecoveryInfo();
                
            if (!Read(msg, out value.UniqueId))
                return false;
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.RecoverExp))
                return false;
            if (!Read(msg, out value.ExpectCost))
                return false;
            if (!Read(msg, out value.At))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.PlayerExpRecoveryInfo value)
        {
            Write(msg, value.UniqueId);
            Write(msg, value.Level);
            Write(msg, value.RecoverExp);
            Write(msg, value.ExpectCost);
            Write(msg, value.At);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.RelationInfo value)
        {
            value = new NetProtocol.Packet.RelationInfo();
                
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.TargetType))
                return false;
            if (!Read(msg, out value.TargetId))
                return false;
            if (!Read(msg, out value.Relation))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.RelationInfo value)
        {
            Write(msg, value.Type);
            Write(msg, value.TargetType);
            Write(msg, value.TargetId);
            Write(msg, value.Relation);
        }
        public static bool Read(Message msg, out FactionType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (FactionType)temp;
            return true;
        }
        public static void Write(Message msg, FactionType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out RelationshipType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (RelationshipType)temp;
            return true;
        }
        public static void Write(Message msg, RelationshipType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.TicketInfo value)
        {
            value = new NetProtocol.Packet.TicketInfo();
                
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.TableIndex))
                return false;
            if (!Read(msg, out value.Count))
                return false;
            if (!Read(msg, out value.FreeCount))
                return false;
            if (!Read(msg, out value.ExpirationTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.TicketInfo value)
        {
            Write(msg, value.Type);
            Write(msg, value.TableIndex);
            Write(msg, value.Count);
            Write(msg, value.FreeCount);
            Write(msg, value.ExpirationTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.WorldBossDamagedInfo value)
        {
            value = new NetProtocol.Packet.WorldBossDamagedInfo();
                
            if (!Read(msg, out value.Guild))
                return false;
            if (!Read(msg, out value.Damage))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.WorldBossDamagedInfo value)
        {
            Write(msg, value.Guild);
            Write(msg, value.Damage);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Guild.GuildInfo value)
        {
            value = new NetProtocol.Models.Guild.GuildInfo();
                
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.EXP))
                return false;
            if (!Read(msg, out value.Point))
                return false;
            if (!Read(msg, out value.Tendency))
                return false;
            if (!Read(msg, out value.Ruby))
                return false;
            if (!Read(msg, out value.Cron))
                return false;
            if (!Read(msg, out value.Notice))
                return false;
            if (!Read(msg, out value.Id))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.CrestImage))
                return false;
            if (!Read(msg, out value.CrestFrame))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Guild.GuildInfo value)
        {
            Write(msg, value.Type);
            Write(msg, value.State);
            Write(msg, value.Level);
            Write(msg, value.EXP);
            Write(msg, value.Point);
            Write(msg, value.Tendency);
            Write(msg, value.Ruby);
            Write(msg, value.Cron);
            Write(msg, value.Notice);
            Write(msg, value.Id);
            Write(msg, value.Name);
            Write(msg, value.CrestImage);
            Write(msg, value.CrestFrame);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.AccountBlockPlayerInfo value)
        {
            value = new NetProtocol.Packet.AccountBlockPlayerInfo();
                
            if (!Read(msg, out value.BlockAccountId))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.BlockReason))
                return false;
            if (!Read(msg, out value.AddedAt))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.AccountBlockPlayerInfo value)
        {
            Write(msg, value.BlockAccountId);
            Write(msg, value.Name);
            Write(msg, value.BlockReason);
            Write(msg, value.AddedAt);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.ShopInfo value)
        {
            value = new NetProtocol.Packet.ShopInfo();
                
            if (!Read(msg, out value.ShopIndex))
                return false;
            if (!Read(msg, out value.BuyCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.ShopInfo value)
        {
            Write(msg, value.ShopIndex);
            Write(msg, value.BuyCount);
        }
        public static bool Read(Message msg, out ActorStateEffect value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (ActorStateEffect)temp;
            return true;
        }
        public static void Write(Message msg, ActorStateEffect value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out DungeonClearType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (DungeonClearType)temp;
            return true;
        }
        public static void Write(Message msg, DungeonClearType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out ErrorCode value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (ErrorCode)temp;
            return true;
        }
        public static void Write(Message msg, ErrorCode value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out WhereType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (WhereType)temp;
            return true;
        }
        public static void Write(Message msg, WhereType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out WhatType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (WhatType)temp;
            return true;
        }
        public static void Write(Message msg, WhatType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out InteractPropState value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (InteractPropState)temp;
            return true;
        }
        public static void Write(Message msg, InteractPropState value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out InteractState value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (InteractState)temp;
            return true;
        }
        public static void Write(Message msg, InteractState value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out MailSubType value)
        {
            value = default;
            if (!Read(msg, out Byte temp))
                return false;

            value = (MailSubType)temp;
            return true;
        }
        public static void Write(Message msg, MailSubType value)
        {
            Write(msg, (Byte)value);
        }
        public static bool Read(Message msg, out MailType value)
        {
            value = default;
            if (!Read(msg, out Byte temp))
                return false;

            value = (MailType)temp;
            return true;
        }
        public static void Write(Message msg, MailType value)
        {
            Write(msg, (Byte)value);
        }
        public static bool Read(Message msg, out MatchingReply value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (MatchingReply)temp;
            return true;
        }
        public static void Write(Message msg, MatchingReply value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out PacketTradeCronState value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (PacketTradeCronState)temp;
            return true;
        }
        public static void Write(Message msg, PacketTradeCronState value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out PacketTradeCronType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (PacketTradeCronType)temp;
            return true;
        }
        public static void Write(Message msg, PacketTradeCronType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out PartyLootingEnum value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (PartyLootingEnum)temp;
            return true;
        }
        public static void Write(Message msg, PartyLootingEnum value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out Trace value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (Trace)temp;
            return true;
        }
        public static void Write(Message msg, Trace value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out TradeItemState value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (TradeItemState)temp;
            return true;
        }
        public static void Write(Message msg, TradeItemState value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out TradePersonalState value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (TradePersonalState)temp;
            return true;
        }
        public static void Write(Message msg, TradePersonalState value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out WalletType value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (WalletType)temp;
            return true;
        }
        public static void Write(Message msg, WalletType value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out YesOrNo value)
        {
            value = default;
            if (!Read(msg, out Int32 temp))
                return false;

            value = (YesOrNo)temp;
            return true;
        }
        public static void Write(Message msg, YesOrNo value)
        {
            Write(msg, (Int32)value);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.AccountCreateNameRes value)
        {
            value = new NetProtocol.Packet.G2C.AccountCreateNameRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.AccountCreateNameRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorAddBuffV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ActorAddBuffV2Noti();
                
            if (!Read(msg, out value.Buff))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorAddBuffV2Noti value)
        {
            Write(msg, value.Buff);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Actor.Features.DActorBuff value)
        {
            value = new NetProtocol.Models.Actor.Features.DActorBuff();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.BuffId))
                return false;
            if (!Read(msg, out value.BarrierValue))
                return false;
            if (!Read(msg, out value.BarrierStack))
                return false;
            if (!Read(msg, out value.Effect))
                return false;
            if (!Read(msg, out value.SkillLinkDataId))
                return false;
            if (!Read(msg, out value.ExpiredAt))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Actor.Features.DActorBuff value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.BuffId);
            Write(msg, value.BarrierValue);
            Write(msg, value.BarrierStack);
            Write(msg, value.Effect);
            Write(msg, value.SkillLinkDataId);
            Write(msg, value.ExpiredAt);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorChangedLevelToMeV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ActorChangedLevelToMeV2Noti();
                
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.Exp))
                return false;
            if (!Read(msg, out value.StatPoint))
                return false;
            if (!Read(msg, out value.SkillPoint))
                return false;
            if (!Read(msg, out value.ChangedCount))
                return false;
            if (!Read(msg, out value.AddedStatPoint))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorChangedLevelToMeV2Noti value)
        {
            Write(msg, value.Level);
            Write(msg, value.Exp);
            Write(msg, value.StatPoint);
            Write(msg, value.SkillPoint);
            Write(msg, value.ChangedCount);
            Write(msg, value.AddedStatPoint);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorChangedLevelV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ActorChangedLevelV2Noti();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorChangedLevelV2Noti value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.Level);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorChangeStateV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ActorChangeStateV2Noti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.State))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorChangeStateV2Noti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.State);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorCostumeNoti value)
        {
            value = new NetProtocol.Packet.G2C.ActorCostumeNoti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.Head))
                return false;
            if (!Read(msg, out value.HeadShow))
                return false;
            if (!Read(msg, out value.Body))
                return false;
            if (!Read(msg, out value.BodyShow))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorCostumeNoti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.Head);
            Write(msg, value.HeadShow);
            Write(msg, value.Body);
            Write(msg, value.BodyShow);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorDeathV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ActorDeathV2Noti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.State))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorDeathV2Noti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.State);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorDisAppearV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ActorDisAppearV2Noti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorDisAppearV2Noti value)
        {
            Write(msg, value.ActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorGuildV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ActorGuildV2Noti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.GuildId))
                return false;
            if (!Read(msg, out value.CrestImage))
                return false;
            if (!Read(msg, out value.CrestFrame))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorGuildV2Noti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.GuildId);
            Write(msg, value.CrestImage);
            Write(msg, value.CrestFrame);
            Write(msg, value.Name);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorHpMpUpdateV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ActorHpMpUpdateV2Noti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.MaxHp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.MaxMp))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorHpMpUpdateV2Noti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.Hp);
            Write(msg, value.MaxHp);
            Write(msg, value.Mp);
            Write(msg, value.MaxMp);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorHpUpdateV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ActorHpUpdateV2Noti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.Amount))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.MaxHp))
                return false;
            if (!Read(msg, out value.From))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorHpUpdateV2Noti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.Amount);
            Write(msg, value.Hp);
            Write(msg, value.MaxHp);
            Write(msg, value.From);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorMoveV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ActorMoveV2Noti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.Position))
                return false;
            if (!Read(msg, out value.MoveState))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorMoveV2Noti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.Position);
            Write(msg, value.MoveState);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorMpUpdateV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ActorMpUpdateV2Noti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.Amount))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.MaxMp))
                return false;
            if (!Read(msg, out value.From))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorMpUpdateV2Noti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.Amount);
            Write(msg, value.Mp);
            Write(msg, value.MaxMp);
            Write(msg, value.From);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorPendingDisAppearNoti value)
        {
            value = new NetProtocol.Packet.G2C.ActorPendingDisAppearNoti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.PropIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorPendingDisAppearNoti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.PropIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorPetV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ActorPetV2Noti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.PetIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorPetV2Noti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.PetIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorRemoveBuffV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ActorRemoveBuffV2Noti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.BuffId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorRemoveBuffV2Noti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.BuffId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorRideV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ActorRideV2Noti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.RideIndex))
                return false;
            if (!Read(msg, out value.RideSit))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorRideV2Noti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.RideIndex);
            Write(msg, value.RideSit);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorsDisAppearV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ActorsDisAppearV2Noti();
                
            if (!Read(msg, out value.ActorIds))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorsDisAppearV2Noti value)
        {
            Write(msg, value.ActorIds);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorStatSyncNoti value)
        {
            value = new NetProtocol.Packet.G2C.ActorStatSyncNoti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.SyncStat))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorStatSyncNoti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.SyncStat);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Actor.Features.DActorSyncStat value)
        {
            value = new NetProtocol.Models.Actor.Features.DActorSyncStat();
                
            if (!Read(msg, out value.MoveSpeed))
                return false;
            if (!Read(msg, out value.AttackSpeed))
                return false;
            if (!Read(msg, out value.CastingSpeed))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Actor.Features.DActorSyncStat value)
        {
            Write(msg, value.MoveSpeed);
            Write(msg, value.AttackSpeed);
            Write(msg, value.CastingSpeed);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.MonsterActorAppearV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.MonsterActorAppearV2Noti();
                
            if (!Read(msg, out value.Monster))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.MonsterActorAppearV2Noti value)
        {
            Write(msg, value.Monster);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Actor.DMonsterActor value)
        {
            value = new NetProtocol.Models.Actor.DMonsterActor();
                
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.Buffs))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            if (!Read(msg, out value.SyncStat))
                return false;
            if (!Read(msg, out value.Property))
                return false;
            if (!Read(msg, out value.Transform))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Actor.DMonsterActor value)
        {
            Write(msg, value.Level);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
            Write(msg, value.State);
            Write(msg, value.Buffs);
            Write(msg, value.TargetActorId);
            Write(msg, value.SyncStat);
            Write(msg, value.Property);
            Write(msg, value.Transform);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Actor.Features.DHp value)
        {
            value = new NetProtocol.Models.Actor.Features.DHp();
                
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.MaxHp))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Actor.Features.DHp value)
        {
            Write(msg, value.Hp);
            Write(msg, value.MaxHp);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Actor.Features.DMp value)
        {
            value = new NetProtocol.Models.Actor.Features.DMp();
                
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.MaxMp))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Actor.Features.DMp value)
        {
            Write(msg, value.Mp);
            Write(msg, value.MaxMp);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Actor.Features.DActorBuff> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Actor.Features.DActorBuff>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Actor.Features.DActorBuff val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Actor.Features.DActorBuff> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Actor.Features.DTransform value)
        {
            value = new NetProtocol.Models.Actor.Features.DTransform();
                
            if (!Read(msg, out value.Position))
                return false;
            if (!Read(msg, out value.Direction))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Actor.Features.DTransform value)
        {
            Write(msg, value.Position);
            Write(msg, value.Direction);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.MonsterActorsAppearV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.MonsterActorsAppearV2Noti();
                
            if (!Read(msg, out value.Monsters))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.MonsterActorsAppearV2Noti value)
        {
            Write(msg, value.Monsters);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Actor.DMonsterActor> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Actor.DMonsterActor>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Actor.DMonsterActor val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Actor.DMonsterActor> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.MonsterActorTargetNoti value)
        {
            value = new NetProtocol.Packet.G2C.MonsterActorTargetNoti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.MonsterActorTargetNoti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.TargetActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerActorAppearV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerActorAppearV2Noti();
                
            if (!Read(msg, out value.Player))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerActorAppearV2Noti value)
        {
            Write(msg, value.Player);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Actor.DPlayerActorForBroadCast value)
        {
            value = new NetProtocol.Models.Actor.DPlayerActorForBroadCast();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.Face))
                return false;
            if (!Read(msg, out value.Customize))
                return false;
            if (!Read(msg, out value.Property))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.Transform))
                return false;
            if (!Read(msg, out value.Guild))
                return false;
            if (!Read(msg, out value.Equipment))
                return false;
            if (!Read(msg, out value.EquipPet))
                return false;
            if (!Read(msg, out value.Ride))
                return false;
            if (!Read(msg, out value.Costume))
                return false;
            if (!Read(msg, out value.Title))
                return false;
            if (!Read(msg, out value.IsBattleMode))
                return false;
            if (!Read(msg, out value.Buffs))
                return false;
            if (!Read(msg, out value.KarmaPoint))
                return false;
            if (!Read(msg, out value.PurpleActive))
                return false;
            if (!Read(msg, out value.ZoneState))
                return false;
            if (!Read(msg, out value.SyncStat))
                return false;
            if (!Read(msg, out value.Rank))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Actor.DPlayerActorForBroadCast value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.Name);
            Write(msg, value.Level);
            Write(msg, value.Face);
            Write(msg, value.Customize);
            Write(msg, value.Property);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
            Write(msg, value.Transform);
            Write(msg, value.Guild);
            Write(msg, value.Equipment);
            Write(msg, value.EquipPet);
            Write(msg, value.Ride);
            Write(msg, value.Costume);
            Write(msg, value.Title);
            Write(msg, value.IsBattleMode);
            Write(msg, value.Buffs);
            Write(msg, value.KarmaPoint);
            Write(msg, value.PurpleActive);
            Write(msg, value.ZoneState);
            Write(msg, value.SyncStat);
            Write(msg, value.Rank);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Actor.Features.DEquipment value)
        {
            value = new NetProtocol.Models.Actor.Features.DEquipment();
                
            if (!Read(msg, out value.Equipments))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Actor.Features.DEquipment value)
        {
            Write(msg, value.Equipments);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Item.Features.ItemEquipInfo value)
        {
            value = new NetProtocol.Models.Item.Features.ItemEquipInfo();
                
            if (!Read(msg, out value.EquipSlot))
                return false;
            if (!Read(msg, out value.ItemIndex))
                return false;
            if (!Read(msg, out value.IsVisible))
                return false;
            if (!Read(msg, out value.Enchant))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Item.Features.ItemEquipInfo value)
        {
            Write(msg, value.EquipSlot);
            Write(msg, value.ItemIndex);
            Write(msg, value.IsVisible);
            Write(msg, value.Enchant);
        }
        public static bool Read(Message msg, out Dictionary<NetProtocol.Packet.EquipSlot, NetProtocol.Models.Item.Features.ItemEquipInfo> value)
        {
            value = new();

            int count = 0;
            Read(msg, out count);

            for (int i = 0; i < count; ++i)
            {
                if (!Read(msg, out NetProtocol.Packet.EquipSlot key))
                    return false;
                if (!Read(msg, out NetProtocol.Models.Item.Features.ItemEquipInfo val))
                    return false;

                value.Add(key, val);
            }

            return true;
        }
        public static void Write(Message msg, Dictionary<NetProtocol.Packet.EquipSlot, NetProtocol.Models.Item.Features.ItemEquipInfo> value)
        {
            Write(msg, value.Count);

            foreach (var pair in value)
            {
                Write(msg, pair.Key);
                Write(msg, pair.Value);
            }
        }
        public static bool Read(Message msg, out NetProtocol.Models.Actor.Features.DRide value)
        {
            value = new NetProtocol.Models.Actor.Features.DRide();
                
            if (!Read(msg, out value.RideIndex))
                return false;
            if (!Read(msg, out value.RideSit))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Actor.Features.DRide value)
        {
            Write(msg, value.RideIndex);
            Write(msg, value.RideSit);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Actor.Features.DCostume value)
        {
            value = new NetProtocol.Models.Actor.Features.DCostume();
                
            if (!Read(msg, out value.Head))
                return false;
            if (!Read(msg, out value.HeadShow))
                return false;
            if (!Read(msg, out value.Body))
                return false;
            if (!Read(msg, out value.BodyShow))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Actor.Features.DCostume value)
        {
            Write(msg, value.Head);
            Write(msg, value.HeadShow);
            Write(msg, value.Body);
            Write(msg, value.BodyShow);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerActorsAppearV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerActorsAppearV2Noti();
                
            if (!Read(msg, out value.PlayerActors))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerActorsAppearV2Noti value)
        {
            Write(msg, value.PlayerActors);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Actor.DPlayerActorForBroadCast> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Actor.DPlayerActorForBroadCast>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Actor.DPlayerActorForBroadCast val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Actor.DPlayerActorForBroadCast> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerActorZoneStateNoti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerActorZoneStateNoti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.ZoneState))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerActorZoneStateNoti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.ZoneState);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PropActorAppearNoti value)
        {
            value = new NetProtocol.Packet.G2C.PropActorAppearNoti();
                
            if (!Read(msg, out value.PropActor))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PropActorAppearNoti value)
        {
            Write(msg, value.PropActor);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Actor.DPropActor value)
        {
            value = new NetProtocol.Models.Actor.DPropActor();
                
            if (!Read(msg, out value.OwnerActorId))
                return false;
            if (!Read(msg, out value.OwnerName))
                return false;
            if (!Read(msg, out value.Property))
                return false;
            if (!Read(msg, out value.Transform))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Actor.DPropActor value)
        {
            Write(msg, value.OwnerActorId);
            Write(msg, value.OwnerName);
            Write(msg, value.Property);
            Write(msg, value.Transform);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PropActorsAppearNoti value)
        {
            value = new NetProtocol.Packet.G2C.PropActorsAppearNoti();
                
            if (!Read(msg, out value.PropActors))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PropActorsAppearNoti value)
        {
            Write(msg, value.PropActors);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Actor.DPropActor> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Actor.DPropActor>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Actor.DPropActor val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Actor.DPropActor> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.DesignateBindStoneRes value)
        {
            value = new NetProtocol.Packet.G2C.DesignateBindStoneRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.AddedBindStoneIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.DesignateBindStoneRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.AddedBindStoneIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PortalByBindStoneRes value)
        {
            value = new NetProtocol.Packet.G2C.PortalByBindStoneRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PortalByBindStoneRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerBlackRosterGetPreferenceRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerBlackRosterGetPreferenceRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Info))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerBlackRosterGetPreferenceRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Info);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerBlackRosterLastWeekRankRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerBlackRosterLastWeekRankRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Ranks))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerBlackRosterLastWeekRankRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Ranks);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.AccountPvpRankInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.AccountPvpRankInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.AccountPvpRankInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.AccountPvpRankInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerBlackRosterMessageNoti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerBlackRosterMessageNoti();
                
            if (!Read(msg, out value.IsKill))
                return false;
            if (!Read(msg, out value.PlayerName))
                return false;
            if (!Read(msg, out value.Message))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerBlackRosterMessageNoti value)
        {
            Write(msg, value.IsKill);
            Write(msg, value.PlayerName);
            Write(msg, value.Message);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerBlackRosterObservingNoti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerBlackRosterObservingNoti();
                
            if (!Read(msg, out value.TargetActorId))
                return false;
            if (!Read(msg, out value.ZoneIndex))
                return false;
            if (!Read(msg, out value.TargetTransform))
                return false;
            if (!Read(msg, out value.TargetPartyTransform))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerBlackRosterObservingNoti value)
        {
            Write(msg, value.TargetActorId);
            Write(msg, value.ZoneIndex);
            Write(msg, value.TargetTransform);
            Write(msg, value.TargetPartyTransform);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Actor.Features.DTransform> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Actor.Features.DTransform>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Actor.Features.DTransform val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Actor.Features.DTransform> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerBlackRosterObservingRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerBlackRosterObservingRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.TargetPlayerName))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            if (!Read(msg, out value.ExpiredAt))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerBlackRosterObservingRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.TargetPlayerName);
            Write(msg, value.TargetActorId);
            Write(msg, value.ExpiredAt);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerBlackRosterProvocationNoti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerBlackRosterProvocationNoti();
                
            if (!Read(msg, out value.SourceName))
                return false;
            if (!Read(msg, out value.TargetName))
                return false;
            if (!Read(msg, out value.Message))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerBlackRosterProvocationNoti value)
        {
            Write(msg, value.SourceName);
            Write(msg, value.TargetName);
            Write(msg, value.Message);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerBlackRosterProvocationRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerBlackRosterProvocationRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerBlackRosterProvocationRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerBlackRosterRankRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerBlackRosterRankRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Ranks))
                return false;
            if (!Read(msg, out value.MyRank))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerBlackRosterRankRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Ranks);
            Write(msg, value.MyRank);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerBlackRosterRevengeRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerBlackRosterRevengeRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerBlackRosterRevengeRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerBlackRosterSetPreferenceRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerBlackRosterSetPreferenceRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerBlackRosterSetPreferenceRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerBlackRostersRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerBlackRostersRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Kills))
                return false;
            if (!Read(msg, out value.Deaths))
                return false;
            if (!Read(msg, out value.PVPValue))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerBlackRostersRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Kills);
            Write(msg, value.Deaths);
            Write(msg, value.PVPValue);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.BlackRosterKillInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.BlackRosterKillInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.BlackRosterKillInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.BlackRosterKillInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.BlackRosterDeathInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.BlackRosterDeathInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.BlackRosterDeathInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.BlackRosterDeathInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BloodFogChangeWaveNoti value)
        {
            value = new NetProtocol.Packet.G2C.BloodFogChangeWaveNoti();
                
            if (!Read(msg, out value.WaveType))
                return false;
            if (!Read(msg, out value.ServerTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BloodFogChangeWaveNoti value)
        {
            Write(msg, value.WaveType);
            Write(msg, value.ServerTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BloodFogEnterRes value)
        {
            value = new NetProtocol.Packet.G2C.BloodFogEnterRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.BloodFogIndex))
                return false;
            if (!Read(msg, out value.UnstableSerum))
                return false;
            if (!Read(msg, out value.StableSerum))
                return false;
            if (!Read(msg, out value.BloodFogGrade))
                return false;
            if (!Read(msg, out value.ChainKill))
                return false;
            if (!Read(msg, out value.ChainDeath))
                return false;
            if (!Read(msg, out value.EndTimeAt))
                return false;
            if (!Read(msg, out value.BloodFogAlters))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BloodFogEnterRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.BloodFogIndex);
            Write(msg, value.UnstableSerum);
            Write(msg, value.StableSerum);
            Write(msg, value.BloodFogGrade);
            Write(msg, value.ChainKill);
            Write(msg, value.ChainDeath);
            Write(msg, value.EndTimeAt);
            Write(msg, value.BloodFogAlters);
        }
        public static bool Read(Message msg, out List<System.Numerics.Vector3> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<System.Numerics.Vector3>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out System.Numerics.Vector3 val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<System.Numerics.Vector3> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BloodFogEventNoti value)
        {
            value = new NetProtocol.Packet.G2C.BloodFogEventNoti();
                
            if (!Read(msg, out value.ScheduleDataId))
                return false;
            if (!Read(msg, out value.BloodFogDataId))
                return false;
            if (!Read(msg, out value.StateType))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BloodFogEventNoti value)
        {
            Write(msg, value.ScheduleDataId);
            Write(msg, value.BloodFogDataId);
            Write(msg, value.StateType);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BloodFogKickoutNoti value)
        {
            value = new NetProtocol.Packet.G2C.BloodFogKickoutNoti();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BloodFogKickoutNoti value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BloodFogLeaveRes value)
        {
            value = new NetProtocol.Packet.G2C.BloodFogLeaveRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BloodFogLeaveRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BloodFogPlayerDeathNoti value)
        {
            value = new NetProtocol.Packet.G2C.BloodFogPlayerDeathNoti();
                
            if (!Read(msg, out value.IsPlayerKill))
                return false;
            if (!Read(msg, out value.MonsterActorId))
                return false;
            if (!Read(msg, out value.LossUnstableSerum))
                return false;
            if (!Read(msg, out value.LossStableSerum))
                return false;
            if (!Read(msg, out value.Rank))
                return false;
            if (!Read(msg, out value.ResurractionIntervalSecond))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BloodFogPlayerDeathNoti value)
        {
            Write(msg, value.IsPlayerKill);
            Write(msg, value.MonsterActorId);
            Write(msg, value.LossUnstableSerum);
            Write(msg, value.LossStableSerum);
            Write(msg, value.Rank);
            Write(msg, value.ResurractionIntervalSecond);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BloodFogPlayerPointUpdateNoti value)
        {
            value = new NetProtocol.Packet.G2C.BloodFogPlayerPointUpdateNoti();
                
            if (!Read(msg, out value.UnstableSerum))
                return false;
            if (!Read(msg, out value.StableSerum))
                return false;
            if (!Read(msg, out value.ComboKill))
                return false;
            if (!Read(msg, out value.ComboDeath))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BloodFogPlayerPointUpdateNoti value)
        {
            Write(msg, value.UnstableSerum);
            Write(msg, value.StableSerum);
            Write(msg, value.ComboKill);
            Write(msg, value.ComboDeath);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BloodFogPlayerRankUpdateNoti value)
        {
            value = new NetProtocol.Packet.G2C.BloodFogPlayerRankUpdateNoti();
                
            if (!Read(msg, out value.PlayerActorId))
                return false;
            if (!Read(msg, out value.Rank))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BloodFogPlayerRankUpdateNoti value)
        {
            Write(msg, value.PlayerActorId);
            Write(msg, value.Rank);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BloodFogResultNoti value)
        {
            value = new NetProtocol.Packet.G2C.BloodFogResultNoti();
                
            if (!Read(msg, out value.BloodFogRankDatas))
                return false;
            if (!Read(msg, out value.Buffs))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BloodFogResultNoti value)
        {
            Write(msg, value.BloodFogRankDatas);
            Write(msg, value.Buffs);
        }
        public static bool Read(Message msg, out NetProtocol.Models.BloodFog.BloodFogRankInfo value)
        {
            value = new NetProtocol.Models.BloodFog.BloodFogRankInfo();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Kill))
                return false;
            if (!Read(msg, out value.Death))
                return false;
            if (!Read(msg, out value.ChainKill))
                return false;
            if (!Read(msg, out value.BloodFogGrade))
                return false;
            if (!Read(msg, out value.TotalAcquireStableSerum))
                return false;
            if (!Read(msg, out value.UseUnstableSerum))
                return false;
            if (!Read(msg, out value.AcquireStableSerum))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.BloodFog.BloodFogRankInfo value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.Name);
            Write(msg, value.Kill);
            Write(msg, value.Death);
            Write(msg, value.ChainKill);
            Write(msg, value.BloodFogGrade);
            Write(msg, value.TotalAcquireStableSerum);
            Write(msg, value.UseUnstableSerum);
            Write(msg, value.AcquireStableSerum);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.BloodFog.BloodFogRankInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.BloodFog.BloodFogRankInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.BloodFog.BloodFogRankInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.BloodFog.BloodFogRankInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Models.BloodFog.BloodFogBuff value)
        {
            value = new NetProtocol.Models.BloodFog.BloodFogBuff();
                
            if (!Read(msg, out value.BuffIndex))
                return false;
            if (!Read(msg, out value.UseCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.BloodFog.BloodFogBuff value)
        {
            Write(msg, value.BuffIndex);
            Write(msg, value.UseCount);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.BloodFog.BloodFogBuff> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.BloodFog.BloodFogBuff>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.BloodFog.BloodFogBuff val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.BloodFog.BloodFogBuff> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BloodFogUseBuffRes value)
        {
            value = new NetProtocol.Packet.G2C.BloodFogUseBuffRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Buff))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BloodFogUseBuffRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Buff);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CheatGetMainQuestV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.CheatGetMainQuestV2Noti();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.QuestList))
                return false;
            if (!Read(msg, out value.AcceptQuest))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CheatGetMainQuestV2Noti value)
        {
            Write(msg, value.Err);
            Write(msg, value.QuestList);
            Write(msg, value.AcceptQuest);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.QuestInfoV2> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.QuestInfoV2>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.QuestInfoV2 val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.QuestInfoV2> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CheatMessageV2Res value)
        {
            value = new NetProtocol.Packet.G2C.CheatMessageV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CheatMessageV2Res value)
        {
            Write(msg, value.Err);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CheatQuestResetV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.CheatQuestResetV2Noti();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Quests))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CheatQuestResetV2Noti value)
        {
            Write(msg, value.Err);
            Write(msg, value.Quests);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.QuestInfoV2[] value)
        {
            int count = 0;
            Read(msg, out count);

            value = new NetProtocol.Packet.QuestInfoV2[count];

            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.QuestInfoV2 val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.QuestInfoV2[] value)
        {
            Write(msg, value.Length);
            for (int i = 0; i < value.Length; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.AccountBlockPlayerAddRes value)
        {
            value = new NetProtocol.Packet.G2C.AccountBlockPlayerAddRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.BlockPlayer))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.AccountBlockPlayerAddRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.BlockPlayer);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.AccountBlockPlayerDeleteRes value)
        {
            value = new NetProtocol.Packet.G2C.AccountBlockPlayerDeleteRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.BlockAccountId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.AccountBlockPlayerDeleteRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.BlockAccountId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.AccountBlockPlayerReasonEditRes value)
        {
            value = new NetProtocol.Packet.G2C.AccountBlockPlayerReasonEditRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.BlockPlayer))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.AccountBlockPlayerReasonEditRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.BlockPlayer);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.AccountBlockPlayersRes value)
        {
            value = new NetProtocol.Packet.G2C.AccountBlockPlayersRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.BlockPlayers))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.AccountBlockPlayersRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.BlockPlayers);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.AccountBlockPlayerInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.AccountBlockPlayerInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.AccountBlockPlayerInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.AccountBlockPlayerInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ChatMessageV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ChatMessageV2Noti();
                
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.AccountId))
                return false;
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.SourceName))
                return false;
            if (!Read(msg, out value.Message))
                return false;
            if (!Read(msg, out value.LinkItems))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ChatMessageV2Noti value)
        {
            Write(msg, value.Type);
            Write(msg, value.AccountId);
            Write(msg, value.ActorId);
            Write(msg, value.SourceName);
            Write(msg, value.Message);
            Write(msg, value.LinkItems);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Item.Features.ChatLinkItemInfo value)
        {
            value = new NetProtocol.Models.Item.Features.ChatLinkItemInfo();
                
            if (!Read(msg, out value.LinkId))
                return false;
            if (!Read(msg, out value.ItemId))
                return false;
            if (!Read(msg, out value.LinkedItemUniqueId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Item.Features.ChatLinkItemInfo value)
        {
            Write(msg, value.LinkId);
            Write(msg, value.ItemId);
            Write(msg, value.LinkedItemUniqueId);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Item.Features.ChatLinkItemInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Item.Features.ChatLinkItemInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Item.Features.ChatLinkItemInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Item.Features.ChatLinkItemInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ChatMessageV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ChatMessageV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ChatMessageV2Res value)
        {
            Write(msg, value.Err);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.LinkItemInfoRes value)
        {
            value = new NetProtocol.Packet.G2C.LinkItemInfoRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.ItemInfo))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.LinkItemInfoRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.ItemInfo);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Item.ItemV2 value)
        {
            if (!Read(msg, out byte derivedType))
            {
                value = default;
                return false;
            }

            switch (derivedType)
            {
                case 1:
                {
                    bool result = Read(msg, out NetProtocol.Models.Item.EquipmentItemV2 derived);
                    value = derived;
                    return result;
                }
                case 2:
                {
                    bool result = Read(msg, out NetProtocol.Models.Item.RideEquipItemExV2 derived);
                    value = derived;
                    return result;
                }
            }

            value = new NetProtocol.Models.Item.ItemV2();
                
            if (!Read(msg, out value.Id))
                return false;
            if (!Read(msg, out value.DataId))
                return false;
            if (!Read(msg, out value.Count))
                return false;
            if (!Read(msg, out value.IsFixedOwner))
                return false;
            if (!Read(msg, out value.IsLocked))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Item.ItemV2 value)
        {
            switch (value)
            {
                case NetProtocol.Models.Item.EquipmentItemV2 derive:
                {
                    Write(msg, (byte)1);
                    Write(msg, derive);
                    return;
                }
                case NetProtocol.Models.Item.RideEquipItemExV2 derive:
                {
                    Write(msg, (byte)2);
                    Write(msg, derive);
                    return;
                }
            }
            Write(msg, (byte)3);

            Write(msg, value.Id);
            Write(msg, value.DataId);
            Write(msg, value.Count);
            Write(msg, value.IsFixedOwner);
            Write(msg, value.IsLocked);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Item.EquipmentItemV2 value)
        {
            value = new NetProtocol.Models.Item.EquipmentItemV2();
                
            if (!Read(msg, out value.EquipSlot))
                return false;
            if (!Read(msg, out value.DownLevel))
                return false;
            if (!Read(msg, out value.Enchant))
                return false;
            if (!Read(msg, out value.SocketCount))
                return false;
            if (!Read(msg, out value.OptionList))
                return false;
            if (!Read(msg, out value.SkillCount))
                return false;
            if (!Read(msg, out value.SkillList))
                return false;
            if (!Read(msg, out value.SubStatList))
                return false;
            if (!Read(msg, out value.Id))
                return false;
            if (!Read(msg, out value.DataId))
                return false;
            if (!Read(msg, out value.Count))
                return false;
            if (!Read(msg, out value.IsFixedOwner))
                return false;
            if (!Read(msg, out value.IsLocked))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Item.EquipmentItemV2 value)
        {
            Write(msg, value.EquipSlot);
            Write(msg, value.DownLevel);
            Write(msg, value.Enchant);
            Write(msg, value.SocketCount);
            Write(msg, value.OptionList);
            Write(msg, value.SkillCount);
            Write(msg, value.SkillList);
            Write(msg, value.SubStatList);
            Write(msg, value.Id);
            Write(msg, value.DataId);
            Write(msg, value.Count);
            Write(msg, value.IsFixedOwner);
            Write(msg, value.IsLocked);
        }
        public static bool Read(Message msg, out List<System.Int32> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<System.Int32>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out System.Int32 val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<System.Int32> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Item.ItemSkillV2 value)
        {
            value = new NetProtocol.Models.Item.ItemSkillV2();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.Lv))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Item.ItemSkillV2 value)
        {
            Write(msg, value.Index);
            Write(msg, value.Lv);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Item.ItemSkillV2> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Item.ItemSkillV2>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Item.ItemSkillV2 val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Item.ItemSkillV2> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Stat.StatData value)
        {
            value = new NetProtocol.Models.Stat.StatData();
                
            if (!Read(msg, out value.StatType))
                return false;
            if (!Read(msg, out value.Value))
                return false;
            if (!Read(msg, out value.Per))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Stat.StatData value)
        {
            Write(msg, value.StatType);
            Write(msg, value.Value);
            Write(msg, value.Per);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Stat.StatData> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Stat.StatData>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Stat.StatData val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Stat.StatData> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Item.RideEquipItemExV2 value)
        {
            value = new NetProtocol.Models.Item.RideEquipItemExV2();
                
            if (!Read(msg, out value.EquipParts))
                return false;
            if (!Read(msg, out value.Intension))
                return false;
            if (!Read(msg, out value.Enchant))
                return false;
            if (!Read(msg, out value.OptionCount))
                return false;
            if (!Read(msg, out value.Options))
                return false;
            if (!Read(msg, out value.SkillCount))
                return false;
            if (!Read(msg, out value.Skills))
                return false;
            if (!Read(msg, out value.RideIndex))
                return false;
            if (!Read(msg, out value.Id))
                return false;
            if (!Read(msg, out value.DataId))
                return false;
            if (!Read(msg, out value.Count))
                return false;
            if (!Read(msg, out value.IsFixedOwner))
                return false;
            if (!Read(msg, out value.IsLocked))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Item.RideEquipItemExV2 value)
        {
            Write(msg, value.EquipParts);
            Write(msg, value.Intension);
            Write(msg, value.Enchant);
            Write(msg, value.OptionCount);
            Write(msg, value.Options);
            Write(msg, value.SkillCount);
            Write(msg, value.Skills);
            Write(msg, value.RideIndex);
            Write(msg, value.Id);
            Write(msg, value.DataId);
            Write(msg, value.Count);
            Write(msg, value.IsFixedOwner);
            Write(msg, value.IsLocked);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.ItemSkill[] value)
        {
            int count = 0;
            Read(msg, out count);

            value = new NetProtocol.Packet.ItemSkill[count];

            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.ItemSkill val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.ItemSkill[] value)
        {
            Write(msg, value.Length);
            for (int i = 0; i < value.Length; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerSearchV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PlayerSearchV2Res();
                
            if (!Read(msg, out value.Error))
                return false;
            if (!Read(msg, out value.SimpleInfo))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerSearchV2Res value)
        {
            Write(msg, value.Error);
            Write(msg, value.SimpleInfo);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Player.Features.PlayerSimpleInfo value)
        {
            value = new NetProtocol.Models.Player.Features.PlayerSimpleInfo();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Lv))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Player.Features.PlayerSimpleInfo value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.Index);
            Write(msg, value.Name);
            Write(msg, value.Lv);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CostumeCardBuildRes value)
        {
            value = new NetProtocol.Packet.G2C.CostumeCardBuildRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Card))
                return false;
            if (!Read(msg, out value.Costume))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CostumeCardBuildRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Card);
            Write(msg, value.Costume);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CostumeCardGachaRes value)
        {
            value = new NetProtocol.Packet.G2C.CostumeCardGachaRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Cards))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CostumeCardGachaRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Cards);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CostumeCardInfoRes value)
        {
            value = new NetProtocol.Packet.G2C.CostumeCardInfoRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Cards))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CostumeCardInfoRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Cards);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.CostumeCard> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.CostumeCard>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.CostumeCard val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.CostumeCard> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CostumeCardMixRes value)
        {
            value = new NetProtocol.Packet.G2C.CostumeCardMixRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Mixes))
                return false;
            if (!Read(msg, out value.Cards))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CostumeCardMixRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Mixes);
            Write(msg, value.Cards);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.CostumeMixData> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.CostumeMixData>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.CostumeMixData val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.CostumeMixData> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CostumeCollectNoti value)
        {
            value = new NetProtocol.Packet.G2C.CostumeCollectNoti();
                
            if (!Read(msg, out value.Collects))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CostumeCollectNoti value)
        {
            Write(msg, value.Collects);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CostumeCollectRes value)
        {
            value = new NetProtocol.Packet.G2C.CostumeCollectRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Collects))
                return false;
            if (!Read(msg, out value.CollectIndexes))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CostumeCollectRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Collects);
            Write(msg, value.CollectIndexes);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CostumeConfirmAcceptRes value)
        {
            value = new NetProtocol.Packet.G2C.CostumeConfirmAcceptRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Costume))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CostumeConfirmAcceptRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Costume);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CostumeConfirmChangeRes value)
        {
            value = new NetProtocol.Packet.G2C.CostumeConfirmChangeRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Confirm))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CostumeConfirmChangeRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Confirm);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CostumeConfirmInfoRes value)
        {
            value = new NetProtocol.Packet.G2C.CostumeConfirmInfoRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Confirms))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CostumeConfirmInfoRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Confirms);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.CostumeConfirm> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.CostumeConfirm>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.CostumeConfirm val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.CostumeConfirm> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CostumeEquipBodyRes value)
        {
            value = new NetProtocol.Packet.G2C.CostumeEquipBodyRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.CostumeIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CostumeEquipBodyRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.CostumeIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CostumeEquipBodyShowRes value)
        {
            value = new NetProtocol.Packet.G2C.CostumeEquipBodyShowRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.IsShow))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CostumeEquipBodyShowRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.IsShow);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CostumeEquipHeadRes value)
        {
            value = new NetProtocol.Packet.G2C.CostumeEquipHeadRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.CostumeIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CostumeEquipHeadRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.CostumeIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CostumeEquipHeadShowRes value)
        {
            value = new NetProtocol.Packet.G2C.CostumeEquipHeadShowRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.IsShow))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CostumeEquipHeadShowRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.IsShow);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CostumeInfoRes value)
        {
            value = new NetProtocol.Packet.G2C.CostumeInfoRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.HeadEquip))
                return false;
            if (!Read(msg, out value.HeadShow))
                return false;
            if (!Read(msg, out value.BodyEquip))
                return false;
            if (!Read(msg, out value.BodyShow))
                return false;
            if (!Read(msg, out value.Costumes))
                return false;
            if (!Read(msg, out value.Cards))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CostumeInfoRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.HeadEquip);
            Write(msg, value.HeadShow);
            Write(msg, value.BodyEquip);
            Write(msg, value.BodyShow);
            Write(msg, value.Costumes);
            Write(msg, value.Cards);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.CostumeData> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.CostumeData>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.CostumeData val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.CostumeData> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PortalEffectNoti value)
        {
            value = new NetProtocol.Packet.G2C.PortalEffectNoti();
                
            if (!Read(msg, out value.ActorProperty))
                return false;
            if (!Read(msg, out value.FromTrace))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PortalEffectNoti value)
        {
            Write(msg, value.ActorProperty);
            Write(msg, value.FromTrace);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PortalEffectRes value)
        {
            value = new NetProtocol.Packet.G2C.PortalEffectRes();
                
            if (!Read(msg, out value.err))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PortalEffectRes value)
        {
            Write(msg, value.err);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.AttainmentDailyRewardV2Res value)
        {
            value = new NetProtocol.Packet.G2C.AttainmentDailyRewardV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.EventIndex))
                return false;
            if (!Read(msg, out value.Day))
                return false;
            if (!Read(msg, out value.AchieveConditionIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.AttainmentDailyRewardV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.EventIndex);
            Write(msg, value.Day);
            Write(msg, value.AchieveConditionIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.AttainmentNormalRewardV2Res value)
        {
            value = new NetProtocol.Packet.G2C.AttainmentNormalRewardV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.EventIndex))
                return false;
            if (!Read(msg, out value.AchieveConditionIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.AttainmentNormalRewardV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.EventIndex);
            Write(msg, value.AchieveConditionIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.AttainmentProgressV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.AttainmentProgressV2Noti();
                
            if (!Read(msg, out value.EventId))
                return false;
            if (!Read(msg, out value.Day))
                return false;
            if (!Read(msg, out value.AchieveConditionIndex))
                return false;
            if (!Read(msg, out value.AchieveConditionValue))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.AttainmentProgressV2Noti value)
        {
            Write(msg, value.EventId);
            Write(msg, value.Day);
            Write(msg, value.AchieveConditionIndex);
            Write(msg, value.AchieveConditionValue);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.AttainmentsNoti value)
        {
            value = new NetProtocol.Packet.G2C.AttainmentsNoti();
                
            if (!Read(msg, out value.AttainmentInfoV2s))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.AttainmentsNoti value)
        {
            Write(msg, value.AttainmentInfoV2s);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.EventAttainmentInfoV2> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.EventAttainmentInfoV2>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.EventAttainmentInfoV2 val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.EventAttainmentInfoV2> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.AttendanceRewardV2Res value)
        {
            value = new NetProtocol.Packet.G2C.AttendanceRewardV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.EventIndex))
                return false;
            if (!Read(msg, out value.Day))
                return false;
            if (!Read(msg, out value.Reward))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.AttendanceRewardV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.EventIndex);
            Write(msg, value.Day);
            Write(msg, value.Reward);
        }
        public static bool Read(Message msg, out NetProtocol.Models.etc.RewardData value)
        {
            value = new NetProtocol.Models.etc.RewardData();
                
            if (!Read(msg, out value.RewardType))
                return false;
            if (!Read(msg, out value.ItemIndex))
                return false;
            if (!Read(msg, out value.Value))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.etc.RewardData value)
        {
            Write(msg, value.RewardType);
            Write(msg, value.ItemIndex);
            Write(msg, value.Value);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BossScheduleNoti value)
        {
            value = new NetProtocol.Packet.G2C.BossScheduleNoti();
                
            if (!Read(msg, out value.BossScheduleIndex))
                return false;
            if (!Read(msg, out value.BossDataId))
                return false;
            if (!Read(msg, out value.MessageKey))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BossScheduleNoti value)
        {
            Write(msg, value.BossScheduleIndex);
            Write(msg, value.BossDataId);
            Write(msg, value.MessageKey);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BossScheduleRes value)
        {
            value = new NetProtocol.Packet.G2C.BossScheduleRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Infos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BossScheduleRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Infos);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.BossScheduleInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.BossScheduleInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.BossScheduleInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.BossScheduleInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.EventAttendanceListV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.EventAttendanceListV2Noti();
                
            if (!Read(msg, out value.Events))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.EventAttendanceListV2Noti value)
        {
            Write(msg, value.Events);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Event.EventAttendanceInfo value)
        {
            value = new NetProtocol.Models.Event.EventAttendanceInfo();
                
            if (!Read(msg, out value.EventIndex))
                return false;
            if (!Read(msg, out value.Attendances))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Event.EventAttendanceInfo value)
        {
            Write(msg, value.EventIndex);
            Write(msg, value.Attendances);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Event.EventAttendanceInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Event.EventAttendanceInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Event.EventAttendanceInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Event.EventAttendanceInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Event.EventAttendanceUnit value)
        {
            value = new NetProtocol.Models.Event.EventAttendanceUnit();
                
            if (!Read(msg, out value.EventIndex))
                return false;
            if (!Read(msg, out value.day))
                return false;
            if (!Read(msg, out value.IsAttendance))
                return false;
            if (!Read(msg, out value.IsReward))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Event.EventAttendanceUnit value)
        {
            Write(msg, value.EventIndex);
            Write(msg, value.day);
            Write(msg, value.IsAttendance);
            Write(msg, value.IsReward);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Event.EventAttendanceUnit> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Event.EventAttendanceUnit>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Event.EventAttendanceUnit val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Event.EventAttendanceUnit> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.EventExchangeRewardV2Res value)
        {
            value = new NetProtocol.Packet.G2C.EventExchangeRewardV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.EventIndex))
                return false;
            if (!Read(msg, out value.Priority))
                return false;
            if (!Read(msg, out value.RewardItems))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.EventExchangeRewardV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.EventIndex);
            Write(msg, value.Priority);
            Write(msg, value.RewardItems);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Item.ItemV2[] value)
        {
            int count = 0;
            Read(msg, out count);

            value = new NetProtocol.Models.Item.ItemV2[count];

            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Item.ItemV2 val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Item.ItemV2[] value)
        {
            Write(msg, value.Length);
            for (int i = 0; i < value.Length; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminBuffActiveRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminBuffActiveRes();
                
            if (!Read(msg, out value.Result))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminBuffActiveRes value)
        {
            Write(msg, value.Result);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminBuffBuyRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminBuffBuyRes();
                
            if (!Read(msg, out value.Result))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminBuffBuyRes value)
        {
            Write(msg, value.Result);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminInfoRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminInfoRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Intro))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminInfoRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Intro);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminMasterChangeNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminMasterChangeNoti();
                
            if (!Read(msg, out value.AccountIdOldMaster))
                return false;
            if (!Read(msg, out value.AccountIdNewMaster))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminMasterChangeNoti value)
        {
            Write(msg, value.AccountIdOldMaster);
            Write(msg, value.AccountIdNewMaster);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminMasterChangeRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminMasterChangeRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.AccountIdNewMaster))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminMasterChangeRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.AccountIdNewMaster);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminMemberBanishNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminMemberBanishNoti();
                
            if (!Read(msg, out value.AccountId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminMemberBanishNoti value)
        {
            Write(msg, value.AccountId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminMemberBanishRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminMemberBanishRes();
                
            if (!Read(msg, out value.Result))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminMemberBanishRes value)
        {
            Write(msg, value.Result);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminMemberUpdateNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminMemberUpdateNoti();
                
            if (!Read(msg, out value.AccountId))
                return false;
            if (!Read(msg, out value.MemberType))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminMemberUpdateNoti value)
        {
            Write(msg, value.AccountId);
            Write(msg, value.MemberType);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminMemberUpdateRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminMemberUpdateRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.AccountId))
                return false;
            if (!Read(msg, out value.MemberType))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminMemberUpdateRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.AccountId);
            Write(msg, value.MemberType);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminUpdateBaseNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminUpdateBaseNoti();
                
            if (!Read(msg, out value.CrestImage))
                return false;
            if (!Read(msg, out value.CrestFrame))
                return false;
            if (!Read(msg, out value.Tendency))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminUpdateBaseNoti value)
        {
            Write(msg, value.CrestImage);
            Write(msg, value.CrestFrame);
            Write(msg, value.Tendency);
            Write(msg, value.Type);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminUpdateBaseRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminUpdateBaseRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.CrestImage))
                return false;
            if (!Read(msg, out value.CrestFrame))
                return false;
            if (!Read(msg, out value.Tendency))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminUpdateBaseRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.CrestImage);
            Write(msg, value.CrestFrame);
            Write(msg, value.Tendency);
            Write(msg, value.Type);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminUpdateIntroNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminUpdateIntroNoti();
                
            if (!Read(msg, out value.Intro))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminUpdateIntroNoti value)
        {
            Write(msg, value.Intro);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminUpdateIntroRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminUpdateIntroRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Intro))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminUpdateIntroRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Intro);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminUpdateNoticeNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminUpdateNoticeNoti();
                
            if (!Read(msg, out value.Notice))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminUpdateNoticeNoti value)
        {
            Write(msg, value.Notice);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminUpdateNoticeRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminUpdateNoticeRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Notice))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminUpdateNoticeRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Notice);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminUpdateTendencyNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminUpdateTendencyNoti();
                
            if (!Read(msg, out value.Tendency))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminUpdateTendencyNoti value)
        {
            Write(msg, value.Tendency);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminUpdateTendencyRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminUpdateTendencyRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Tendency))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminUpdateTendencyRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Tendency);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminUpdateTypeNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminUpdateTypeNoti();
                
            if (!Read(msg, out value.Type))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminUpdateTypeNoti value)
        {
            Write(msg, value.Type);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAdminUpdateTypeRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildAdminUpdateTypeRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAdminUpdateTypeRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Type);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildAttendRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildAttendRes();
                
            if (!Read(msg, out value.Result))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildAttendRes value)
        {
            Write(msg, value.Result);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildBaseNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildBaseNoti();
                
            if (!Read(msg, out value.GuildId))
                return false;
            if (!Read(msg, out value.GuildName))
                return false;
            if (!Read(msg, out value.CrestImage))
                return false;
            if (!Read(msg, out value.CrestFrame))
                return false;
            if (!Read(msg, out value.TimeLeave))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildBaseNoti value)
        {
            Write(msg, value.GuildId);
            Write(msg, value.GuildName);
            Write(msg, value.CrestImage);
            Write(msg, value.CrestFrame);
            Write(msg, value.TimeLeave);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildBuffInfoRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildBuffInfoRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.GuildBuffs))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildBuffInfoRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.GuildBuffs);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Guild.GuildBuff value)
        {
            value = new NetProtocol.Models.Guild.GuildBuff();
                
            if (!Read(msg, out value.BuffIndex))
                return false;
            if (!Read(msg, out value.TimeExpire))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Guild.GuildBuff value)
        {
            Write(msg, value.BuffIndex);
            Write(msg, value.TimeExpire);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Guild.GuildBuff> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Guild.GuildBuff>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Guild.GuildBuff val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Guild.GuildBuff> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildBuffNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildBuffNoti();
                
            if (!Read(msg, out value.Buff))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildBuffNoti value)
        {
            Write(msg, value.Buff);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildCreateRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildCreateRes();
                
            if (!Read(msg, out value.Result))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildCreateRes value)
        {
            Write(msg, value.Result);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildCronNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildCronNoti();
                
            if (!Read(msg, out value.Cron))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildCronNoti value)
        {
            Write(msg, value.Cron);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildDeleteRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildDeleteRes();
                
            if (!Read(msg, out value.Result))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildDeleteRes value)
        {
            Write(msg, value.Result);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildDonateRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildDonateRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.DonateCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildDonateRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.DonateCount);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildDonationByCronV2Res value)
        {
            value = new NetProtocol.Packet.G2C.GuildDonationByCronV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.RewardItemCounts))
                return false;
            if (!Read(msg, out value.RewardItems))
                return false;
            if (!Read(msg, out value.UseItemCounts))
                return false;
            if (!Read(msg, out value.UseItems))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildDonationByCronV2Res value)
        {
            Write(msg, value.Result);
            Write(msg, value.RewardItemCounts);
            Write(msg, value.RewardItems);
            Write(msg, value.UseItemCounts);
            Write(msg, value.UseItems);
        }
        public static bool Read(Message msg, out Dictionary<System.Int64, System.Int32> value)
        {
            value = new();

            int count = 0;
            Read(msg, out count);

            for (int i = 0; i < count; ++i)
            {
                if (!Read(msg, out System.Int64 key))
                    return false;
                if (!Read(msg, out System.Int32 val))
                    return false;

                value.Add(key, val);
            }

            return true;
        }
        public static void Write(Message msg, Dictionary<System.Int64, System.Int32> value)
        {
            Write(msg, value.Count);

            foreach (var pair in value)
            {
                Write(msg, pair.Key);
                Write(msg, pair.Value);
            }
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildFindRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildFindRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Guilds))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildFindRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Guilds);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Guild.GuildIntro value)
        {
            value = new NetProtocol.Models.Guild.GuildIntro();
                
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Master))
                return false;
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.Tendency))
                return false;
            if (!Read(msg, out value.Intro))
                return false;
            if (!Read(msg, out value.MemberCount))
                return false;
            if (!Read(msg, out value.Id))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.CrestImage))
                return false;
            if (!Read(msg, out value.CrestFrame))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Guild.GuildIntro value)
        {
            Write(msg, value.Type);
            Write(msg, value.Master);
            Write(msg, value.Level);
            Write(msg, value.Tendency);
            Write(msg, value.Intro);
            Write(msg, value.MemberCount);
            Write(msg, value.Id);
            Write(msg, value.Name);
            Write(msg, value.CrestImage);
            Write(msg, value.CrestFrame);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Guild.GuildIntro> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Guild.GuildIntro>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Guild.GuildIntro val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Guild.GuildIntro> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildHistoryNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildHistoryNoti();
                
            if (!Read(msg, out value.History))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildHistoryNoti value)
        {
            Write(msg, value.History);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Guild.GuildHistory value)
        {
            value = new NetProtocol.Models.Guild.GuildHistory();
                
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Param0))
                return false;
            if (!Read(msg, out value.Param1))
                return false;
            if (!Read(msg, out value.Param2))
                return false;
            if (!Read(msg, out value.TimeHistory))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Guild.GuildHistory value)
        {
            Write(msg, value.Type);
            Write(msg, value.Param0);
            Write(msg, value.Param1);
            Write(msg, value.Param2);
            Write(msg, value.TimeHistory);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildHistoryRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildHistoryRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.HistoryList))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildHistoryRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.HistoryList);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Guild.GuildHistory> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Guild.GuildHistory>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Guild.GuildHistory val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Guild.GuildHistory> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildInfoCallRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildInfoCallRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.GuildViews))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildInfoCallRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.GuildViews);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Guild.GuildView value)
        {
            value = new NetProtocol.Models.Guild.GuildView();
                
            if (!Read(msg, out value.Id))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.CrestImage))
                return false;
            if (!Read(msg, out value.CrestFrame))
                return false;
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.Master))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Guild.GuildView value)
        {
            Write(msg, value.Id);
            Write(msg, value.Name);
            Write(msg, value.CrestImage);
            Write(msg, value.CrestFrame);
            Write(msg, value.Level);
            Write(msg, value.Master);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Guild.GuildView> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Guild.GuildView>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Guild.GuildView val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Guild.GuildView> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildInfoRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildInfoRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Info))
                return false;
            if (!Read(msg, out value.Members))
                return false;
            if (!Read(msg, out value.Buffs))
                return false;
            if (!Read(msg, out value.TimeLogin))
                return false;
            if (!Read(msg, out value.DonateCount))
                return false;
            if (!Read(msg, out value.Ranking))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildInfoRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Info);
            Write(msg, value.Members);
            Write(msg, value.Buffs);
            Write(msg, value.TimeLogin);
            Write(msg, value.DonateCount);
            Write(msg, value.Ranking);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Guild.GuildMember value)
        {
            value = new NetProtocol.Models.Guild.GuildMember();
                
            if (!Read(msg, out value.AccountId))
                return false;
            if (!Read(msg, out value.MemberType))
                return false;
            if (!Read(msg, out value.ClassIndex))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.BattlePower))
                return false;
            if (!Read(msg, out value.DonationPoint))
                return false;
            if (!Read(msg, out value.DonationStack))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.TimeState))
                return false;
            if (!Read(msg, out value.TimeJoin))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Guild.GuildMember value)
        {
            Write(msg, value.AccountId);
            Write(msg, value.MemberType);
            Write(msg, value.ClassIndex);
            Write(msg, value.Name);
            Write(msg, value.Level);
            Write(msg, value.BattlePower);
            Write(msg, value.DonationPoint);
            Write(msg, value.DonationStack);
            Write(msg, value.State);
            Write(msg, value.TimeState);
            Write(msg, value.TimeJoin);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Guild.GuildMember> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Guild.GuildMember>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Guild.GuildMember val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Guild.GuildMember> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildJoinRequestConfirmNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildJoinRequestConfirmNoti();
                
            if (!Read(msg, out value.GuildId))
                return false;
            if (!Read(msg, out value.GuildName))
                return false;
            if (!Read(msg, out value.CrestImage))
                return false;
            if (!Read(msg, out value.CrestFrame))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildJoinRequestConfirmNoti value)
        {
            Write(msg, value.GuildId);
            Write(msg, value.GuildName);
            Write(msg, value.CrestImage);
            Write(msg, value.CrestFrame);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildJoinRequestConfirmRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildJoinRequestConfirmRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.AccountId))
                return false;
            if (!Read(msg, out value.Confirm))
                return false;
            if (!Read(msg, out value.Member))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildJoinRequestConfirmRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.AccountId);
            Write(msg, value.Confirm);
            Write(msg, value.Member);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildJoinRequestListRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildJoinRequestListRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Players))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildJoinRequestListRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Players);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Guild.GuildJoin value)
        {
            value = new NetProtocol.Models.Guild.GuildJoin();
                
            if (!Read(msg, out value.AccountId))
                return false;
            if (!Read(msg, out value.ClassIndex))
                return false;
            if (!Read(msg, out value.PlayerName))
                return false;
            if (!Read(msg, out value.TimeRequest))
                return false;
            if (!Read(msg, out value.TimeLogined))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Guild.GuildJoin value)
        {
            Write(msg, value.AccountId);
            Write(msg, value.ClassIndex);
            Write(msg, value.PlayerName);
            Write(msg, value.TimeRequest);
            Write(msg, value.TimeLogined);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Guild.GuildJoin> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Guild.GuildJoin>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Guild.GuildJoin val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Guild.GuildJoin> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildLeaveNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildLeaveNoti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildLeaveNoti value)
        {
            Write(msg, value.ActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildLeaveRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildLeaveRes();
                
            if (!Read(msg, out value.Result))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildLeaveRes value)
        {
            Write(msg, value.Result);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildLiveInviteConfirmNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildLiveInviteConfirmNoti();
                
            if (!Read(msg, out value.InviteeName))
                return false;
            if (!Read(msg, out value.Confirm))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildLiveInviteConfirmNoti value)
        {
            Write(msg, value.InviteeName);
            Write(msg, value.Confirm);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildLiveInviteConfirmRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildLiveInviteConfirmRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Confirm))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildLiveInviteConfirmRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Confirm);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildLiveInviteNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildLiveInviteNoti();
                
            if (!Read(msg, out value.InviterName))
                return false;
            if (!Read(msg, out value.Guild))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildLiveInviteNoti value)
        {
            Write(msg, value.InviterName);
            Write(msg, value.Guild);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildLiveInviteRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildLiveInviteRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.PlayerName))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildLiveInviteRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.PlayerName);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildMemberInfoRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildMemberInfoRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Members))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildMemberInfoRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Members);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildMemberNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildMemberNoti();
                
            if (!Read(msg, out value.Members))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildMemberNoti value)
        {
            Write(msg, value.Members);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildMemberStateV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.GuildMemberStateV2Noti();
                
            if (!Read(msg, out value.PlayerName))
                return false;
            if (!Read(msg, out value.State))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildMemberStateV2Noti value)
        {
            Write(msg, value.PlayerName);
            Write(msg, value.State);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildMemberUpdateNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildMemberUpdateNoti();
                
            if (!Read(msg, out value.UpdateType))
                return false;
            if (!Read(msg, out value.MemberData))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildMemberUpdateNoti value)
        {
            Write(msg, value.UpdateType);
            Write(msg, value.MemberData);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildPointNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildPointNoti();
                
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.EXP))
                return false;
            if (!Read(msg, out value.Point))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildPointNoti value)
        {
            Write(msg, value.Level);
            Write(msg, value.EXP);
            Write(msg, value.Point);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildRubyNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildRubyNoti();
                
            if (!Read(msg, out value.Ruby))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildRubyNoti value)
        {
            Write(msg, value.Ruby);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildSignRequestCancelRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildSignRequestCancelRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.GuildId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildSignRequestCancelRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.GuildId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildSignRequestListRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildSignRequestListRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Guilds))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildSignRequestListRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Guilds);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Guild.GuildSign value)
        {
            value = new NetProtocol.Models.Guild.GuildSign();
                
            if (!Read(msg, out value.GuildId))
                return false;
            if (!Read(msg, out value.TimeRequest))
                return false;
            if (!Read(msg, out value.TimeRefusal))
                return false;
            if (!Read(msg, out value.Intro))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Guild.GuildSign value)
        {
            Write(msg, value.GuildId);
            Write(msg, value.TimeRequest);
            Write(msg, value.TimeRefusal);
            Write(msg, value.Intro);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Guild.GuildSign> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Guild.GuildSign>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Guild.GuildSign val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Guild.GuildSign> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildSignRequestRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildSignRequestRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.GuildType))
                return false;
            if (!Read(msg, out value.GuildId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildSignRequestRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.GuildType);
            Write(msg, value.GuildId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildTerritoryInfoRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildTerritoryInfoRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.HasTerritory))
                return false;
            if (!Read(msg, out value.Infos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildTerritoryInfoRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.HasTerritory);
            Write(msg, value.Infos);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Guild.TerritoryInfo value)
        {
            value = new NetProtocol.Models.Guild.TerritoryInfo();
                
            if (!Read(msg, out value.ZoneIndex))
                return false;
            if (!Read(msg, out value.TaxRate))
                return false;
            if (!Read(msg, out value.ShopRate))
                return false;
            if (!Read(msg, out value.ItemDropRate))
                return false;
            if (!Read(msg, out value.CronDropRate))
                return false;
            if (!Read(msg, out value.MonsterLevel))
                return false;
            if (!Read(msg, out value.CanPvp))
                return false;
            if (!Read(msg, out value.CanEnterPlayers))
                return false;
            if (!Read(msg, out value.CanEnterEnemyGuild))
                return false;
            if (!Read(msg, out value.CanEnterCriminalPlayer))
                return false;
            if (!Read(msg, out value.CanEnterMurdererPlayer))
                return false;
            if (!Read(msg, out value.LeftTimeSpanTicks))
                return false;
            if (!Read(msg, out value.ExpiredAt))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Guild.TerritoryInfo value)
        {
            Write(msg, value.ZoneIndex);
            Write(msg, value.TaxRate);
            Write(msg, value.ShopRate);
            Write(msg, value.ItemDropRate);
            Write(msg, value.CronDropRate);
            Write(msg, value.MonsterLevel);
            Write(msg, value.CanPvp);
            Write(msg, value.CanEnterPlayers);
            Write(msg, value.CanEnterEnemyGuild);
            Write(msg, value.CanEnterCriminalPlayer);
            Write(msg, value.CanEnterMurdererPlayer);
            Write(msg, value.LeftTimeSpanTicks);
            Write(msg, value.ExpiredAt);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Guild.TerritoryInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Guild.TerritoryInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Guild.TerritoryInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Guild.TerritoryInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildTerritorySetRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildTerritorySetRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Info))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildTerritorySetRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Info);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildUpdateCrestNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildUpdateCrestNoti();
                
            if (!Read(msg, out value.Crest))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildUpdateCrestNoti value)
        {
            Write(msg, value.Crest);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildUpdateCurrencyV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.GuildUpdateCurrencyV2Noti();
                
            if (!Read(msg, out value.CurrencyItems))
                return false;
            if (!Read(msg, out value.UseCurrencyItemCounts))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildUpdateCurrencyV2Noti value)
        {
            Write(msg, value.CurrencyItems);
            Write(msg, value.UseCurrencyItemCounts);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildVoteInfoRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildVoteInfoRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Votes))
                return false;
            if (!Read(msg, out value.Voters))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildVoteInfoRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.Votes);
            Write(msg, value.Voters);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Guild.GuildVote value)
        {
            value = new NetProtocol.Models.Guild.GuildVote();
                
            if (!Read(msg, out value.VoteId))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.VoterCount))
                return false;
            if (!Read(msg, out value.TimeVotingStart))
                return false;
            if (!Read(msg, out value.TimeVotingClose))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Guild.GuildVote value)
        {
            Write(msg, value.VoteId);
            Write(msg, value.Type);
            Write(msg, value.VoterCount);
            Write(msg, value.TimeVotingStart);
            Write(msg, value.TimeVotingClose);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Guild.GuildVote> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Guild.GuildVote>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Guild.GuildVote val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Guild.GuildVote> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Guild.GuildVoter value)
        {
            value = new NetProtocol.Models.Guild.GuildVoter();
                
            if (!Read(msg, out value.VoteId))
                return false;
            if (!Read(msg, out value.AccountId))
                return false;
            if (!Read(msg, out value.TimeVoted))
                return false;
            if (!Read(msg, out value.TimeVotingClose))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Guild.GuildVoter value)
        {
            Write(msg, value.VoteId);
            Write(msg, value.AccountId);
            Write(msg, value.TimeVoted);
            Write(msg, value.TimeVotingClose);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Guild.GuildVoter> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Guild.GuildVoter>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Guild.GuildVoter val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Guild.GuildVoter> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildVoteMasterImpeachRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildVoteMasterImpeachRes();
                
            if (!Read(msg, out value.Result))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildVoteMasterImpeachRes value)
        {
            Write(msg, value.Result);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildVoteNoti value)
        {
            value = new NetProtocol.Packet.G2C.GuildVoteNoti();
                
            if (!Read(msg, out value.VoteInfo))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildVoteNoti value)
        {
            Write(msg, value.VoteInfo);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildVoteRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildVoteRes();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.VoteId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildVoteRes value)
        {
            Write(msg, value.Result);
            Write(msg, value.VoteId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildWarehouseChangeSizeV2Res value)
        {
            value = new NetProtocol.Packet.G2C.GuildWarehouseChangeSizeV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Size))
                return false;
            if (!Read(msg, out value.ExtendCount))
                return false;
            if (!Read(msg, out value.GuildCron))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildWarehouseChangeSizeV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Type);
            Write(msg, value.Size);
            Write(msg, value.ExtendCount);
            Write(msg, value.GuildCron);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildWarehouseInfoV2Res value)
        {
            value = new NetProtocol.Packet.G2C.GuildWarehouseInfoV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.GuildWarehouseExtendCount))
                return false;
            if (!Read(msg, out value.GuildWarehouseSize))
                return false;
            if (!Read(msg, out value.GuildWarehouseItems))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildWarehouseInfoV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.GuildWarehouseExtendCount);
            Write(msg, value.GuildWarehouseSize);
            Write(msg, value.GuildWarehouseItems);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Item.ItemV2> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Item.ItemV2>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Item.ItemV2 val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Item.ItemV2> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildWarehouseItemMoveV2Res value)
        {
            value = new NetProtocol.Packet.G2C.GuildWarehouseItemMoveV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Flag))
                return false;
            if (!Read(msg, out value.WarehouseAddItems))
                return false;
            if (!Read(msg, out value.WarehouseSetItems))
                return false;
            if (!Read(msg, out value.WarehouseDelItemIds))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildWarehouseItemMoveV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Type);
            Write(msg, value.Flag);
            Write(msg, value.WarehouseAddItems);
            Write(msg, value.WarehouseSetItems);
            Write(msg, value.WarehouseDelItemIds);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildWarehouseWalletMoveV2Res value)
        {
            value = new NetProtocol.Packet.G2C.GuildWarehouseWalletMoveV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Flag))
                return false;
            if (!Read(msg, out value.GuildWalletType))
                return false;
            if (!Read(msg, out value.GuildWalletCountNow))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildWarehouseWalletMoveV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Flag);
            Write(msg, value.GuildWalletType);
            Write(msg, value.GuildWalletCountNow);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.WorldBossLastAttackNoti value)
        {
            value = new NetProtocol.Packet.G2C.WorldBossLastAttackNoti();
                
            if (!Read(msg, out value.LastAttackActorId))
                return false;
            if (!Read(msg, out value.WorldBossIndex))
                return false;
            if (!Read(msg, out value.WorldBossActorId))
                return false;
            if (!Read(msg, out value.ZoneIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.WorldBossLastAttackNoti value)
        {
            Write(msg, value.LastAttackActorId);
            Write(msg, value.WorldBossIndex);
            Write(msg, value.WorldBossActorId);
            Write(msg, value.ZoneIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.WorldTerritoryOverviewRes value)
        {
            value = new NetProtocol.Packet.G2C.WorldTerritoryOverviewRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Infos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.WorldTerritoryOverviewRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Infos);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Guild.GuildTerritoryInfo value)
        {
            value = new NetProtocol.Models.Guild.GuildTerritoryInfo();
                
            if (!Read(msg, out value.GuildInfo))
                return false;
            if (!Read(msg, out value.Territory))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Guild.GuildTerritoryInfo value)
        {
            Write(msg, value.GuildInfo);
            Write(msg, value.Territory);
        }
        public static bool Read(Message msg, out Dictionary<System.UInt32, NetProtocol.Models.Guild.GuildTerritoryInfo> value)
        {
            value = new();

            int count = 0;
            Read(msg, out count);

            for (int i = 0; i < count; ++i)
            {
                if (!Read(msg, out System.UInt32 key))
                    return false;
                if (!Read(msg, out NetProtocol.Models.Guild.GuildTerritoryInfo val))
                    return false;

                value.Add(key, val);
            }

            return true;
        }
        public static void Write(Message msg, Dictionary<System.UInt32, NetProtocol.Models.Guild.GuildTerritoryInfo> value)
        {
            Write(msg, value.Count);

            foreach (var pair in value)
            {
                Write(msg, pair.Key);
                Write(msg, pair.Value);
            }
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.S2CRttRes value)
        {
            value = new NetProtocol.Packet.G2C.S2CRttRes();
                
            if (!Read(msg, out value.UtcSendTime))
                return false;
            if (!Read(msg, out value.UtcRecvTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.S2CRttRes value)
        {
            Write(msg, value.UtcSendTime);
            Write(msg, value.UtcRecvTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.S2CRttReq value)
        {
            value = new NetProtocol.Packet.G2C.S2CRttReq();
                
            if (!Read(msg, out value.UtcSendTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.S2CRttReq value)
        {
            Write(msg, value.UtcSendTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.DungeonClearHistoryV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.DungeonClearHistoryV2Noti();
                
            if (!Read(msg, out value.DungeonClearInfo))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.DungeonClearHistoryV2Noti value)
        {
            Write(msg, value.DungeonClearInfo);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Dungeon.DungeonClearInfo value)
        {
            value = new NetProtocol.Models.Dungeon.DungeonClearInfo();
                
            if (!Read(msg, out value.DungeonGroupId))
                return false;
            if (!Read(msg, out value.ClearLevel))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Dungeon.DungeonClearInfo value)
        {
            Write(msg, value.DungeonGroupId);
            Write(msg, value.ClearLevel);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Dungeon.DungeonClearInfo[] value)
        {
            int count = 0;
            Read(msg, out count);

            value = new NetProtocol.Models.Dungeon.DungeonClearInfo[count];

            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Dungeon.DungeonClearInfo val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Dungeon.DungeonClearInfo[] value)
        {
            Write(msg, value.Length);
            for (int i = 0; i < value.Length; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.DungeonClearV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.DungeonClearV2Noti();
                
            if (!Read(msg, out value.ClearType))
                return false;
            if (!Read(msg, out value.Error))
                return false;
            if (!Read(msg, out value.ClearLevel))
                return false;
            if (!Read(msg, out value.ClearTime))
                return false;
            if (!Read(msg, out value.ExpiredTime))
                return false;
            if (!Read(msg, out value.ClearInfo))
                return false;
            if (!Read(msg, out value.RewardInfo))
                return false;
            if (!Read(msg, out value.PersonalRewards))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.DungeonClearV2Noti value)
        {
            Write(msg, value.ClearType);
            Write(msg, value.Error);
            Write(msg, value.ClearLevel);
            Write(msg, value.ClearTime);
            Write(msg, value.ExpiredTime);
            Write(msg, value.ClearInfo);
            Write(msg, value.RewardInfo);
            Write(msg, value.PersonalRewards);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Item.DungeonRewardInfoV2 value)
        {
            value = new NetProtocol.Models.Item.DungeonRewardInfoV2();
                
            if (!Read(msg, out value.Exp))
                return false;
            if (!Read(msg, out value.Cron))
                return false;
            if (!Read(msg, out value.ItemUpdates))
                return false;
            if (!Read(msg, out value.Items))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Item.DungeonRewardInfoV2 value)
        {
            Write(msg, value.Exp);
            Write(msg, value.Cron);
            Write(msg, value.ItemUpdates);
            Write(msg, value.Items);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.ItemUpdate[] value)
        {
            int count = 0;
            Read(msg, out count);

            value = new NetProtocol.Packet.ItemUpdate[count];

            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.ItemUpdate val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.ItemUpdate[] value)
        {
            Write(msg, value.Length);
            for (int i = 0; i < value.Length; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Item.PersonalRewardInfoV2 value)
        {
            value = new NetProtocol.Models.Item.PersonalRewardInfoV2();
                
            if (!Read(msg, out value.player_id))
                return false;
            if (!Read(msg, out value.ItemUpdates))
                return false;
            if (!Read(msg, out value.Items))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Item.PersonalRewardInfoV2 value)
        {
            Write(msg, value.player_id);
            Write(msg, value.ItemUpdates);
            Write(msg, value.Items);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Item.PersonalRewardInfoV2[] value)
        {
            int count = 0;
            Read(msg, out count);

            value = new NetProtocol.Models.Item.PersonalRewardInfoV2[count];

            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Item.PersonalRewardInfoV2 val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Item.PersonalRewardInfoV2[] value)
        {
            Write(msg, value.Length);
            for (int i = 0; i < value.Length; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.DungeonCronUpdateV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.DungeonCronUpdateV2Noti();
                
            if (!Read(msg, out value.RemainCron))
                return false;
            if (!Read(msg, out value.RemoveCron))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.DungeonCronUpdateV2Noti value)
        {
            Write(msg, value.RemainCron);
            Write(msg, value.RemoveCron);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.DungeonEnterV2Res value)
        {
            value = new NetProtocol.Packet.G2C.DungeonEnterV2Res();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.DungeonIndex))
                return false;
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.Changes))
                return false;
            if (!Read(msg, out value.TicketChangeInfo))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.DungeonEnterV2Res value)
        {
            Write(msg, value.Status);
            Write(msg, value.DungeonIndex);
            Write(msg, value.Level);
            Write(msg, value.Changes);
            Write(msg, value.TicketChangeInfo);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Item.ChangeItemInfoV2 value)
        {
            value = new NetProtocol.Models.Item.ChangeItemInfoV2();
                
            if (!Read(msg, out value.Deletes))
                return false;
            if (!Read(msg, out value.Updates))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Item.ChangeItemInfoV2 value)
        {
            Write(msg, value.Deletes);
            Write(msg, value.Updates);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.DungeonExpUpdateV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.DungeonExpUpdateV2Noti();
                
            if (!Read(msg, out value.RemainGateHp))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.DungeonExpUpdateV2Noti value)
        {
            Write(msg, value.RemainGateHp);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.DungeonGiveUpV2Res value)
        {
            value = new NetProtocol.Packet.G2C.DungeonGiveUpV2Res();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.DungeonGiveUpV2Res value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.DungeonLeaveV2Res value)
        {
            value = new NetProtocol.Packet.G2C.DungeonLeaveV2Res();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.DungeonLeaveV2Res value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.DungeonLoadingCompleteAllV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.DungeonLoadingCompleteAllV2Noti();
                
            if (!Read(msg, out value.StartTime))
                return false;
            if (!Read(msg, out value.EndTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.DungeonLoadingCompleteAllV2Noti value)
        {
            Write(msg, value.StartTime);
            Write(msg, value.EndTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.DungeonLoadingCompleteV2Res value)
        {
            value = new NetProtocol.Packet.G2C.DungeonLoadingCompleteV2Res();
                
            if (!Read(msg, out value.Error))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.DungeonLoadingCompleteV2Res value)
        {
            Write(msg, value.Error);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.EquipDungeonClearNoti value)
        {
            value = new NetProtocol.Packet.G2C.EquipDungeonClearNoti();
                
            if (!Read(msg, out value.ClearType))
                return false;
            if (!Read(msg, out value.ClearLevel))
                return false;
            if (!Read(msg, out value.ClearTime))
                return false;
            if (!Read(msg, out value.ExpiredTime))
                return false;
            if (!Read(msg, out value.ClearInfo))
                return false;
            if (!Read(msg, out value.MonsterDropItems))
                return false;
            if (!Read(msg, out value.ClearBonusItems))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.EquipDungeonClearNoti value)
        {
            Write(msg, value.ClearType);
            Write(msg, value.ClearLevel);
            Write(msg, value.ClearTime);
            Write(msg, value.ExpiredTime);
            Write(msg, value.ClearInfo);
            Write(msg, value.MonsterDropItems);
            Write(msg, value.ClearBonusItems);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ExpDungeonClearNoti value)
        {
            value = new NetProtocol.Packet.G2C.ExpDungeonClearNoti();
                
            if (!Read(msg, out value.ClearType))
                return false;
            if (!Read(msg, out value.ClearLevel))
                return false;
            if (!Read(msg, out value.ClearTime))
                return false;
            if (!Read(msg, out value.ExpiredTime))
                return false;
            if (!Read(msg, out value.ClearInfo))
                return false;
            if (!Read(msg, out value.MonstersExp))
                return false;
            if (!Read(msg, out value.GateBonusExp))
                return false;
            if (!Read(msg, out value.GateHpPercent))
                return false;
            if (!Read(msg, out value.Multiple))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ExpDungeonClearNoti value)
        {
            Write(msg, value.ClearType);
            Write(msg, value.ClearLevel);
            Write(msg, value.ClearTime);
            Write(msg, value.ExpiredTime);
            Write(msg, value.ClearInfo);
            Write(msg, value.MonstersExp);
            Write(msg, value.GateBonusExp);
            Write(msg, value.GateHpPercent);
            Write(msg, value.Multiple);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.MineralDungeonClearNoti value)
        {
            value = new NetProtocol.Packet.G2C.MineralDungeonClearNoti();
                
            if (!Read(msg, out value.ClearType))
                return false;
            if (!Read(msg, out value.ClearLevel))
                return false;
            if (!Read(msg, out value.ClearTime))
                return false;
            if (!Read(msg, out value.ExpiredTime))
                return false;
            if (!Read(msg, out value.ClearInfo))
                return false;
            if (!Read(msg, out value.Items))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.MineralDungeonClearNoti value)
        {
            Write(msg, value.ClearType);
            Write(msg, value.ClearLevel);
            Write(msg, value.ClearTime);
            Write(msg, value.ExpiredTime);
            Write(msg, value.ClearInfo);
            Write(msg, value.Items);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyDungeonClearNoti value)
        {
            value = new NetProtocol.Packet.G2C.PartyDungeonClearNoti();
                
            if (!Read(msg, out value.ClearType))
                return false;
            if (!Read(msg, out value.ClearLevel))
                return false;
            if (!Read(msg, out value.ClearTime))
                return false;
            if (!Read(msg, out value.ExpiredTime))
                return false;
            if (!Read(msg, out value.ClearInfo))
                return false;
            if (!Read(msg, out value.Rewards))
                return false;
            if (!Read(msg, out value.PersonalRewards))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyDungeonClearNoti value)
        {
            Write(msg, value.ClearType);
            Write(msg, value.ClearLevel);
            Write(msg, value.ClearTime);
            Write(msg, value.ExpiredTime);
            Write(msg, value.ClearInfo);
            Write(msg, value.Rewards);
            Write(msg, value.PersonalRewards);
        }
        public static bool Read(Message msg, out Dictionary<System.Int64, NetProtocol.Models.Item.ItemV2> value)
        {
            value = new();

            int count = 0;
            Read(msg, out count);

            for (int i = 0; i < count; ++i)
            {
                if (!Read(msg, out System.Int64 key))
                    return false;
                if (!Read(msg, out NetProtocol.Models.Item.ItemV2 val))
                    return false;

                value.Add(key, val);
            }

            return true;
        }
        public static void Write(Message msg, Dictionary<System.Int64, NetProtocol.Models.Item.ItemV2> value)
        {
            Write(msg, value.Count);

            foreach (var pair in value)
            {
                Write(msg, pair.Key);
                Write(msg, pair.Value);
            }
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.InteractCancelRes value)
        {
            value = new NetProtocol.Packet.G2C.InteractCancelRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.InteractCancelRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.TargetActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.InteractEndRes value)
        {
            value = new NetProtocol.Packet.G2C.InteractEndRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.InteractEndRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.TargetActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.InteractNoti value)
        {
            value = new NetProtocol.Packet.G2C.InteractNoti();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            if (!Read(msg, out value.State))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.InteractNoti value)
        {
            Write(msg, value.Status);
            Write(msg, value.ActorId);
            Write(msg, value.TargetActorId);
            Write(msg, value.State);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.InteractStartRes value)
        {
            value = new NetProtocol.Packet.G2C.InteractStartRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            if (!Read(msg, out value.EndTimeAt))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.InteractStartRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.TargetActorId);
            Write(msg, value.EndTimeAt);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.EquipmentVisibleV2Res value)
        {
            value = new NetProtocol.Packet.G2C.EquipmentVisibleV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.EquipSlot))
                return false;
            if (!Read(msg, out value.IsVisible))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.EquipmentVisibleV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.EquipSlot);
            Write(msg, value.IsVisible);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.InventoryChangeSizeV2Res value)
        {
            value = new NetProtocol.Packet.G2C.InventoryChangeSizeV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.InventoryExtendCount))
                return false;
            if (!Read(msg, out value.InventorySize))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.InventoryChangeSizeV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.InventoryExtendCount);
            Write(msg, value.InventorySize);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemAddOptionV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ItemAddOptionV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Item))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemAddOptionV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Item);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemAddV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ItemAddV2Noti();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Items))
                return false;
            if (!Read(msg, out value.From))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemAddV2Noti value)
        {
            Write(msg, value.Err);
            Write(msg, value.Items);
            Write(msg, value.From);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemChangeOptionV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ItemChangeOptionV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Item))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemChangeOptionV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Item);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemCollectionBookmarksRegisterV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ItemCollectionBookmarksRegisterV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.ItemCollectIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemCollectionBookmarksRegisterV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.ItemCollectIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemCollectionBookmarksUnregisterV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ItemCollectionBookmarksUnregisterV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.ItemCollectIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemCollectionBookmarksUnregisterV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.ItemCollectIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemCollectionListV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ItemCollectionListV2Noti();
                
            if (!Read(msg, out value.ItemCollects))
                return false;
            if (!Read(msg, out value.Bookmarks))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemCollectionListV2Noti value)
        {
            Write(msg, value.ItemCollects);
            Write(msg, value.Bookmarks);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.ItemCollect[] value)
        {
            int count = 0;
            Read(msg, out count);

            value = new NetProtocol.Packet.ItemCollect[count];

            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.ItemCollect val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.ItemCollect[] value)
        {
            Write(msg, value.Length);
            for (int i = 0; i < value.Length; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemCollectionRegisterV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ItemCollectionRegisterV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.ItemCollectIndex))
                return false;
            if (!Read(msg, out value.ItemId))
                return false;
            if (!Read(msg, out value.ItemTableIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemCollectionRegisterV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.ItemCollectIndex);
            Write(msg, value.ItemId);
            Write(msg, value.ItemTableIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemCombineV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ItemCombineV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.TargetItem))
                return false;
            if (!Read(msg, out value.Success))
                return false;
            if (!Read(msg, out value.GetItemIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemCombineV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.TargetItem);
            Write(msg, value.Success);
            Write(msg, value.GetItemIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemDeleteV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ItemDeleteV2Noti();
                
            if (!Read(msg, out value.ItemId))
                return false;
            if (!Read(msg, out value.From))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemDeleteV2Noti value)
        {
            Write(msg, value.ItemId);
            Write(msg, value.From);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemDeleteV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ItemDeleteV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.ItemIds))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemDeleteV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.ItemIds);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemDisassembleV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ItemDisassembleV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.resultItems))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemDisassembleV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.resultItems);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Item.Features.SimpleItem> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Item.Features.SimpleItem>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Item.Features.SimpleItem val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Item.Features.SimpleItem> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemEnchantV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ItemEnchantV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.ProtectCount))
                return false;
            if (!Read(msg, out value.TargetItem))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemEnchantV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Result);
            Write(msg, value.ProtectCount);
            Write(msg, value.TargetItem);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemEquipV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ItemEquipV2Noti();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.EquipInfo))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemEquipV2Noti value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.EquipInfo);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemEquipV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ItemEquipV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.EquipSlot))
                return false;
            if (!Read(msg, out value.EquipItemId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemEquipV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.EquipSlot);
            Write(msg, value.EquipItemId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemInheritRes value)
        {
            value = new NetProtocol.Packet.G2C.ItemInheritRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.IsSuccess))
                return false;
            if (!Read(msg, out value.ResultItem))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemInheritRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.IsSuccess);
            Write(msg, value.ResultItem);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemIntensionV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ItemIntensionV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.TargetItem))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemIntensionV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Result);
            Write(msg, value.TargetItem);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemIntentionSucceedNoti value)
        {
            value = new NetProtocol.Packet.G2C.ItemIntentionSucceedNoti();
                
            if (!Read(msg, out value.Who))
                return false;
            if (!Read(msg, out value.ItemIndex))
                return false;
            if (!Read(msg, out value.Enchant))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemIntentionSucceedNoti value)
        {
            Write(msg, value.Who);
            Write(msg, value.ItemIndex);
            Write(msg, value.Enchant);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemMarketPriceRes value)
        {
            value = new NetProtocol.Packet.G2C.ItemMarketPriceRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Infos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemMarketPriceRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.Infos);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Item.ItemMarketPriceInfo value)
        {
            value = new NetProtocol.Models.Item.ItemMarketPriceInfo();
                
            if (!Read(msg, out value.Day))
                return false;
            if (!Read(msg, out value.ItemIndex))
                return false;
            if (!Read(msg, out value.PriceSum))
                return false;
            if (!Read(msg, out value.CountSum))
                return false;
            if (!Read(msg, out value.LowestPrice))
                return false;
            if (!Read(msg, out value.HighestPrice))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Item.ItemMarketPriceInfo value)
        {
            Write(msg, value.Day);
            Write(msg, value.ItemIndex);
            Write(msg, value.PriceSum);
            Write(msg, value.CountSum);
            Write(msg, value.LowestPrice);
            Write(msg, value.HighestPrice);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Item.ItemMarketPriceInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Item.ItemMarketPriceInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Item.ItemMarketPriceInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Item.ItemMarketPriceInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemMixOptionV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ItemMixOptionV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.GetItemIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemMixOptionV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.GetItemIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemPackageUseV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ItemPackageUseV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.UseItemId))
                return false;
            if (!Read(msg, out value.UseItemIndex))
                return false;
            if (!Read(msg, out value.ResultIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemPackageUseV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.UseItemId);
            Write(msg, value.UseItemIndex);
            Write(msg, value.ResultIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemProductionV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ItemProductionV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.SuccessCount))
                return false;
            if (!Read(msg, out value.GreatSuccessCount))
                return false;
            if (!Read(msg, out value.FailCount))
                return false;
            if (!Read(msg, out value.GainItems))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemProductionV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.SuccessCount);
            Write(msg, value.GreatSuccessCount);
            Write(msg, value.FailCount);
            Write(msg, value.GainItems);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemSelectUseV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ItemSelectUseV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.UseItemId))
                return false;
            if (!Read(msg, out value.SelectIndex))
                return false;
            if (!Read(msg, out value.DataId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemSelectUseV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.UseItemId);
            Write(msg, value.SelectIndex);
            Write(msg, value.DataId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemSetLockRes value)
        {
            value = new NetProtocol.Packet.G2C.ItemSetLockRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.ItemId))
                return false;
            if (!Read(msg, out value.IsLocked))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemSetLockRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.ItemId);
            Write(msg, value.IsLocked);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemUpdateV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ItemUpdateV2Noti();
                
            if (!Read(msg, out value.Items))
                return false;
            if (!Read(msg, out value.From))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemUpdateV2Noti value)
        {
            Write(msg, value.Items);
            Write(msg, value.From);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemUpgradeV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ItemUpgradeV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.TargetItem))
                return false;
            if (!Read(msg, out value.Success))
                return false;
            if (!Read(msg, out value.GetItem))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemUpgradeV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.TargetItem);
            Write(msg, value.Success);
            Write(msg, value.GetItem);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ItemUseV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ItemUseV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.UseItemId))
                return false;
            if (!Read(msg, out value.DataId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ItemUseV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.UseItemId);
            Write(msg, value.DataId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PkLootingAddV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PkLootingAddV2Noti();
                
            if (!Read(msg, out value.Item))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PkLootingAddV2Noti value)
        {
            Write(msg, value.Item);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Item.PkLootingItemV2 value)
        {
            value = new NetProtocol.Models.Item.PkLootingItemV2();
                
            if (!Read(msg, out value.Id))
                return false;
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.PlayerName))
                return false;
            if (!Read(msg, out value.PlayerIndex))
                return false;
            if (!Read(msg, out value.PlayerLv))
                return false;
            if (!Read(msg, out value.MapIndex))
                return false;
            if (!Read(msg, out value.GainEndTime))
                return false;
            if (!Read(msg, out value.Items))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Item.PkLootingItemV2 value)
        {
            Write(msg, value.Id);
            Write(msg, value.PlayerId);
            Write(msg, value.PlayerName);
            Write(msg, value.PlayerIndex);
            Write(msg, value.PlayerLv);
            Write(msg, value.MapIndex);
            Write(msg, value.GainEndTime);
            Write(msg, value.Items);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PkLootingItemV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PkLootingItemV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.PkLootingIds))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PkLootingItemV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.PkLootingIds);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PkLootingListV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PkLootingListV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.GainItems))
                return false;
            if (!Read(msg, out value.LostItems))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PkLootingListV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.GainItems);
            Write(msg, value.LostItems);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Item.PkLootingItemV2> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Item.PkLootingItemV2>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Item.PkLootingItemV2 val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Item.PkLootingItemV2> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PkLootingV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PkLootingV2Noti();
                
            if (!Read(msg, out value.Items))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PkLootingV2Noti value)
        {
            Write(msg, value.Items);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerInventoryExtendInfoNoti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerInventoryExtendInfoNoti();
                
            if (!Read(msg, out value.InventoryExtendCount))
                return false;
            if (!Read(msg, out value.InventorySize))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerInventoryExtendInfoNoti value)
        {
            Write(msg, value.InventoryExtendCount);
            Write(msg, value.InventorySize);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerInventoryInfoV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerInventoryInfoV2Noti();
                
            if (!Read(msg, out value.isEnd))
                return false;
            if (!Read(msg, out value.Items))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerInventoryInfoV2Noti value)
        {
            Write(msg, value.isEnd);
            Write(msg, value.Items);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.WarehouseChangeSizeV2Res value)
        {
            value = new NetProtocol.Packet.G2C.WarehouseChangeSizeV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Size))
                return false;
            if (!Read(msg, out value.ExtendCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.WarehouseChangeSizeV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Type);
            Write(msg, value.Size);
            Write(msg, value.ExtendCount);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.WarehouseInfoV2Res value)
        {
            value = new NetProtocol.Packet.G2C.WarehouseInfoV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.PrivateWarehouseExtendCount))
                return false;
            if (!Read(msg, out value.PrivateWarehouseSize))
                return false;
            if (!Read(msg, out value.AccountWarehouseExtendCount))
                return false;
            if (!Read(msg, out value.AccountWarehouseSize))
                return false;
            if (!Read(msg, out value.PrivateWarehouseItems))
                return false;
            if (!Read(msg, out value.AccountWarehouseItems))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.WarehouseInfoV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.PrivateWarehouseExtendCount);
            Write(msg, value.PrivateWarehouseSize);
            Write(msg, value.AccountWarehouseExtendCount);
            Write(msg, value.AccountWarehouseSize);
            Write(msg, value.PrivateWarehouseItems);
            Write(msg, value.AccountWarehouseItems);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.WarehouseItemMoveV2Res value)
        {
            value = new NetProtocol.Packet.G2C.WarehouseItemMoveV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Flag))
                return false;
            if (!Read(msg, out value.WarehouseAddItems))
                return false;
            if (!Read(msg, out value.WarehouseSetItems))
                return false;
            if (!Read(msg, out value.WarehouseDelItemIds))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.WarehouseItemMoveV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Type);
            Write(msg, value.Flag);
            Write(msg, value.WarehouseAddItems);
            Write(msg, value.WarehouseSetItems);
            Write(msg, value.WarehouseDelItemIds);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.MailListV2Res value)
        {
            value = new NetProtocol.Packet.G2C.MailListV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Page))
                return false;
            if (!Read(msg, out value.TotalCount))
                return false;
            if (!Read(msg, out value.Mails))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.MailListV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Type);
            Write(msg, value.Page);
            Write(msg, value.TotalCount);
            Write(msg, value.Mails);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Mail.MailInfoV2 value)
        {
            value = new NetProtocol.Models.Mail.MailInfoV2();
                
            if (!Read(msg, out value.Id))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.SubType))
                return false;
            if (!Read(msg, out value.Title))
                return false;
            if (!Read(msg, out value.Body))
                return false;
            if (!Read(msg, out value.Items))
                return false;
            if (!Read(msg, out value.ExpiredAt))
                return false;
            if (!Read(msg, out value.CreatedAt))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Mail.MailInfoV2 value)
        {
            Write(msg, value.Id);
            Write(msg, value.Type);
            Write(msg, value.SubType);
            Write(msg, value.Title);
            Write(msg, value.Body);
            Write(msg, value.Items);
            Write(msg, value.ExpiredAt);
            Write(msg, value.CreatedAt);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Mail.MailInfoV2[] value)
        {
            int count = 0;
            Read(msg, out count);

            value = new NetProtocol.Models.Mail.MailInfoV2[count];

            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Mail.MailInfoV2 val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Mail.MailInfoV2[] value)
        {
            Write(msg, value.Length);
            for (int i = 0; i < value.Length; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.MailReadAllV2Res value)
        {
            value = new NetProtocol.Packet.G2C.MailReadAllV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.MailIds))
                return false;
            if (!Read(msg, out value.Items))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.MailReadAllV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Type);
            Write(msg, value.MailIds);
            Write(msg, value.Items);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.MailReadV2Res value)
        {
            value = new NetProtocol.Packet.G2C.MailReadV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.MailId))
                return false;
            if (!Read(msg, out value.Items))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.MailReadV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Type);
            Write(msg, value.MailId);
            Write(msg, value.Items);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.MatchingApplyRes value)
        {
            value = new NetProtocol.Packet.G2C.MatchingApplyRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.MatchingApplyRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.MatchingCancelRes value)
        {
            value = new NetProtocol.Packet.G2C.MatchingCancelRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.ZoneDataId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.MatchingCancelRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.ZoneDataId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.MatchingCompleteNoti value)
        {
            value = new NetProtocol.Packet.G2C.MatchingCompleteNoti();
                
            if (!Read(msg, out value.MatchingId))
                return false;
            if (!Read(msg, out value.ZoneDataId))
                return false;
            if (!Read(msg, out value.PartyId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.MatchingCompleteNoti value)
        {
            Write(msg, value.MatchingId);
            Write(msg, value.ZoneDataId);
            Write(msg, value.PartyId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.MatchingIncompleteNoti value)
        {
            value = new NetProtocol.Packet.G2C.MatchingIncompleteNoti();
                
            if (!Read(msg, out value.MatchingId))
                return false;
            if (!Read(msg, out value.ZoneDataId))
                return false;
            if (!Read(msg, out value.ActorIds))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.MatchingIncompleteNoti value)
        {
            Write(msg, value.MatchingId);
            Write(msg, value.ZoneDataId);
            Write(msg, value.ActorIds);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.MatchingMatchedNoti value)
        {
            value = new NetProtocol.Packet.G2C.MatchingMatchedNoti();
                
            if (!Read(msg, out value.MatchingId))
                return false;
            if (!Read(msg, out value.ZoneDataId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.MatchingMatchedNoti value)
        {
            Write(msg, value.MatchingId);
            Write(msg, value.ZoneDataId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.MatchingRejectReplyNoti value)
        {
            value = new NetProtocol.Packet.G2C.MatchingRejectReplyNoti();
                
            if (!Read(msg, out value.MatchingId))
                return false;
            if (!Read(msg, out value.RejectActorId))
                return false;
            if (!Read(msg, out value.Reply))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.MatchingRejectReplyNoti value)
        {
            Write(msg, value.MatchingId);
            Write(msg, value.RejectActorId);
            Write(msg, value.Reply);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.MatchingReplyNoti value)
        {
            value = new NetProtocol.Packet.G2C.MatchingReplyNoti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.MatchingId))
                return false;
            if (!Read(msg, out value.Reply))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.MatchingReplyNoti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.MatchingId);
            Write(msg, value.Reply);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.MatchingReplyRes value)
        {
            value = new NetProtocol.Packet.G2C.MatchingReplyRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Reply))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.MatchingReplyRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Reply);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.AuthenticatePlayerCredentialRes value)
        {
            value = new NetProtocol.Packet.G2C.AuthenticatePlayerCredentialRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.WorldAccount))
                return false;
            if (!Read(msg, out value.Players))
                return false;
            if (!Read(msg, out value.Profile))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.AuthenticatePlayerCredentialRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.WorldAccount);
            Write(msg, value.Players);
            Write(msg, value.Profile);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Player.LobbyPlayerV2 value)
        {
            value = new NetProtocol.Models.Player.LobbyPlayerV2();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.ClassId))
                return false;
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.SlotNumber))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Face))
                return false;
            if (!Read(msg, out value.Customize))
                return false;
            if (!Read(msg, out value.GuildName))
                return false;
            if (!Read(msg, out value.MapId))
                return false;
            if (!Read(msg, out value.Position))
                return false;
            if (!Read(msg, out value.Equipments))
                return false;
            if (!Read(msg, out value.Info))
                return false;
            if (!Read(msg, out value.Costume))
                return false;
            if (!Read(msg, out value.CombatCapability))
                return false;
            if (!Read(msg, out value.LastPlayedAt))
                return false;
            if (!Read(msg, out value.CreatedAt))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Player.LobbyPlayerV2 value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.ClassId);
            Write(msg, value.Level);
            Write(msg, value.SlotNumber);
            Write(msg, value.Name);
            Write(msg, value.Face);
            Write(msg, value.Customize);
            Write(msg, value.GuildName);
            Write(msg, value.MapId);
            Write(msg, value.Position);
            Write(msg, value.Equipments);
            Write(msg, value.Info);
            Write(msg, value.Costume);
            Write(msg, value.CombatCapability);
            Write(msg, value.LastPlayedAt);
            Write(msg, value.CreatedAt);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Player.LobbyPlayerV2> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Player.LobbyPlayerV2>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Player.LobbyPlayerV2 val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Player.LobbyPlayerV2> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Player.Features.PlayerEquipment value)
        {
            value = new NetProtocol.Models.Player.Features.PlayerEquipment();
                
            if (!Read(msg, out value.EquipInfo))
                return false;
            if (!Read(msg, out value.ItemId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Player.Features.PlayerEquipment value)
        {
            Write(msg, value.EquipInfo);
            Write(msg, value.ItemId);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Player.Features.PlayerEquipment> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Player.Features.PlayerEquipment>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Player.Features.PlayerEquipment val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Player.Features.PlayerEquipment> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Account.AccountProfile value)
        {
            value = new NetProtocol.Models.Account.AccountProfile();
                
            if (!Read(msg, out value.AccountName))
                return false;
            if (!Read(msg, out value.Slot))
                return false;
            if (!Read(msg, out value.PrimaryPlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Account.AccountProfile value)
        {
            Write(msg, value.AccountName);
            Write(msg, value.Slot);
            Write(msg, value.PrimaryPlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BindStonesNoti value)
        {
            value = new NetProtocol.Packet.G2C.BindStonesNoti();
                
            if (!Read(msg, out value.DesignatedBindStoneIndex))
                return false;
            if (!Read(msg, out value.BindStones))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BindStonesNoti value)
        {
            Write(msg, value.DesignatedBindStoneIndex);
            Write(msg, value.BindStones);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.BindStone> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.BindStone>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.BindStone val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.BindStone> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BossDamagedInfoNoti value)
        {
            value = new NetProtocol.Packet.G2C.BossDamagedInfoNoti();
                
            if (!Read(msg, out value.BossMonsterIndex))
                return false;
            if (!Read(msg, out value.Infos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BossDamagedInfoNoti value)
        {
            Write(msg, value.BossMonsterIndex);
            Write(msg, value.Infos);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.BossDamagedInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.BossDamagedInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.BossDamagedInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.BossDamagedInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BossDamagedInfoRes value)
        {
            value = new NetProtocol.Packet.G2C.BossDamagedInfoRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BossDamagedInfoRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BossFirstDamagedNoti value)
        {
            value = new NetProtocol.Packet.G2C.BossFirstDamagedNoti();
                
            if (!Read(msg, out value.FirstDamagedInfo))
                return false;
            if (!Read(msg, out value.MonsterDataId))
                return false;
            if (!Read(msg, out value.ZoneDataId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BossFirstDamagedNoti value)
        {
            Write(msg, value.FirstDamagedInfo);
            Write(msg, value.MonsterDataId);
            Write(msg, value.ZoneDataId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BossKilledNoti value)
        {
            value = new NetProtocol.Packet.G2C.BossKilledNoti();
                
            if (!Read(msg, out value.KillerInfo))
                return false;
            if (!Read(msg, out value.MonsterDataId))
                return false;
            if (!Read(msg, out value.ZoneDataId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BossKilledNoti value)
        {
            Write(msg, value.KillerInfo);
            Write(msg, value.MonsterDataId);
            Write(msg, value.ZoneDataId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BossKilledRewardNoti value)
        {
            value = new NetProtocol.Packet.G2C.BossKilledRewardNoti();
                
            if (!Read(msg, out value.Infos))
                return false;
            if (!Read(msg, out value.LastDamagedActorInfo))
                return false;
            if (!Read(msg, out value.MonsterDataId))
                return false;
            if (!Read(msg, out value.TopPlayerRewardItemIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BossKilledRewardNoti value)
        {
            Write(msg, value.Infos);
            Write(msg, value.LastDamagedActorInfo);
            Write(msg, value.MonsterDataId);
            Write(msg, value.TopPlayerRewardItemIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BossTakenDamageOnPlayerKillNoti value)
        {
            value = new NetProtocol.Packet.G2C.BossTakenDamageOnPlayerKillNoti();
                
            if (!Read(msg, out value.MonsterDataId))
                return false;
            if (!Read(msg, out value.ZoneDataId))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            if (!Read(msg, out value.TargetActorGuild))
                return false;
            if (!Read(msg, out value.TakenDamage))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BossTakenDamageOnPlayerKillNoti value)
        {
            Write(msg, value.MonsterDataId);
            Write(msg, value.ZoneDataId);
            Write(msg, value.TargetActorId);
            Write(msg, value.TargetActorGuild);
            Write(msg, value.TakenDamage);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BroadCastContextNoti value)
        {
            value = new NetProtocol.Packet.G2C.BroadCastContextNoti();
                
            if (!Read(msg, out value.Contexts))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BroadCastContextNoti value)
        {
            Write(msg, value.Contexts);
        }
        public static bool Read(Message msg, out List<System.Byte> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<System.Byte>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out System.Byte val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<System.Byte> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BroadCastContextRes value)
        {
            value = new NetProtocol.Packet.G2C.BroadCastContextRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BroadCastContextRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CutSceneEndV2Res value)
        {
            value = new NetProtocol.Packet.G2C.CutSceneEndV2Res();
                
            if (!Read(msg, out value.Error))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CutSceneEndV2Res value)
        {
            Write(msg, value.Error);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CutSceneStartV2Res value)
        {
            value = new NetProtocol.Packet.G2C.CutSceneStartV2Res();
                
            if (!Read(msg, out value.Error))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CutSceneStartV2Res value)
        {
            Write(msg, value.Error);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CutSceneStateV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.CutSceneStateV2Noti();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.IsCutScene))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CutSceneStateV2Noti value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.IsCutScene);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.DebugPlayerStateV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.DebugPlayerStateV2Noti();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.PlayerState))
                return false;
            if (!Read(msg, out value.CurrentPos))
                return false;
            if (!Read(msg, out value.CurrentDir))
                return false;
            if (!Read(msg, out value.TimeStamp))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.DebugPlayerStateV2Noti value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.PlayerState);
            Write(msg, value.CurrentPos);
            Write(msg, value.CurrentDir);
            Write(msg, value.TimeStamp);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GainMessageNoti value)
        {
            value = new NetProtocol.Packet.G2C.GainMessageNoti();
                
            if (!Read(msg, out value.MessageType))
                return false;
            if (!Read(msg, out value.Message))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GainMessageNoti value)
        {
            Write(msg, value.MessageType);
            Write(msg, value.Message);
        }
        public static bool Read(Message msg, out NetProtocol.Models.etc.GainMessageInfo value)
        {
            value = new NetProtocol.Models.etc.GainMessageInfo();
                
            if (!Read(msg, out value.WhereType))
                return false;
            if (!Read(msg, out value.Where))
                return false;
            if (!Read(msg, out value.Who))
                return false;
            if (!Read(msg, out value.WhatType))
                return false;
            if (!Read(msg, out value.What))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.etc.GainMessageInfo value)
        {
            Write(msg, value.WhereType);
            Write(msg, value.Where);
            Write(msg, value.Who);
            Write(msg, value.WhatType);
            Write(msg, value.What);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.LogOutRes value)
        {
            value = new NetProtocol.Packet.G2C.LogOutRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.LogOutRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PortalV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PortalV2Res();
                
            if (!Read(msg, out value.Error))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PortalV2Res value)
        {
            Write(msg, value.Error);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ReturnToLobbyRes value)
        {
            value = new NetProtocol.Packet.G2C.ReturnToLobbyRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Players))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ReturnToLobbyRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Players);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ServerTimeV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ServerTimeV2Res();
                
            if (!Read(msg, out value.Time))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ServerTimeV2Res value)
        {
            Write(msg, value.Time);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.SystemMessageV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.SystemMessageV2Noti();
                
            if (!Read(msg, out value.Message))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.SystemMessageV2Noti value)
        {
            Write(msg, value.Message);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TemporalFluxZoneEnterNoti value)
        {
            value = new NetProtocol.Packet.G2C.TemporalFluxZoneEnterNoti();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.ZoneIndex))
                return false;
            if (!Read(msg, out value.TemporalFluxZoneIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TemporalFluxZoneEnterNoti value)
        {
            Write(msg, value.Index);
            Write(msg, value.ZoneIndex);
            Write(msg, value.TemporalFluxZoneIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TemporalFluxZoneExitNoti value)
        {
            value = new NetProtocol.Packet.G2C.TemporalFluxZoneExitNoti();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.ZoneIndex))
                return false;
            if (!Read(msg, out value.TemporalFluxZoneIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TemporalFluxZoneExitNoti value)
        {
            Write(msg, value.Index);
            Write(msg, value.ZoneIndex);
            Write(msg, value.TemporalFluxZoneIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TestPacketV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.TestPacketV2Noti();
                
            if (!Read(msg, out value.SendMessage))
                return false;
            if (!Read(msg, out value.FrontCpu))
                return false;
            if (!Read(msg, out value.FrontMem))
                return false;
            if (!Read(msg, out value.FrontGcCount1))
                return false;
            if (!Read(msg, out value.FrontGcCount0))
                return false;
            if (!Read(msg, out value.FrontGcCount2))
                return false;
            if (!Read(msg, out value.FrontHandleCount))
                return false;
            if (!Read(msg, out value.FrontThreadCount))
                return false;
            if (!Read(msg, out value.GameCpu))
                return false;
            if (!Read(msg, out value.GameMem))
                return false;
            if (!Read(msg, out value.GameGcCount0))
                return false;
            if (!Read(msg, out value.GameGcCount1))
                return false;
            if (!Read(msg, out value.GameGcCount2))
                return false;
            if (!Read(msg, out value.GameHandleCount))
                return false;
            if (!Read(msg, out value.GameThreadCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TestPacketV2Noti value)
        {
            Write(msg, value.SendMessage);
            Write(msg, value.FrontCpu);
            Write(msg, value.FrontMem);
            Write(msg, value.FrontGcCount1);
            Write(msg, value.FrontGcCount0);
            Write(msg, value.FrontGcCount2);
            Write(msg, value.FrontHandleCount);
            Write(msg, value.FrontThreadCount);
            Write(msg, value.GameCpu);
            Write(msg, value.GameMem);
            Write(msg, value.GameGcCount0);
            Write(msg, value.GameGcCount1);
            Write(msg, value.GameGcCount2);
            Write(msg, value.GameHandleCount);
            Write(msg, value.GameThreadCount);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TestPacketV2Res value)
        {
            value = new NetProtocol.Packet.G2C.TestPacketV2Res();
                
            if (!Read(msg, out value.IsEcho))
                return false;
            if (!Read(msg, out value.SendMessage))
                return false;
            if (!Read(msg, out value.ElapsedTimeMs))
                return false;
            if (!Read(msg, out value.F2GStartTimeMs))
                return false;
            if (!Read(msg, out value.GameLogicTimeMs))
                return false;
            if (!Read(msg, out value.FrontCpu))
                return false;
            if (!Read(msg, out value.FrontMem))
                return false;
            if (!Read(msg, out value.FrontGcCount1))
                return false;
            if (!Read(msg, out value.FrontGcCount0))
                return false;
            if (!Read(msg, out value.FrontGcCount2))
                return false;
            if (!Read(msg, out value.FrontHandleCount))
                return false;
            if (!Read(msg, out value.FrontThreadCount))
                return false;
            if (!Read(msg, out value.GameCpu))
                return false;
            if (!Read(msg, out value.GameMem))
                return false;
            if (!Read(msg, out value.GameGcCount0))
                return false;
            if (!Read(msg, out value.GameGcCount1))
                return false;
            if (!Read(msg, out value.GameGcCount2))
                return false;
            if (!Read(msg, out value.GameHandleCount))
                return false;
            if (!Read(msg, out value.GameThreadCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TestPacketV2Res value)
        {
            Write(msg, value.IsEcho);
            Write(msg, value.SendMessage);
            Write(msg, value.ElapsedTimeMs);
            Write(msg, value.F2GStartTimeMs);
            Write(msg, value.GameLogicTimeMs);
            Write(msg, value.FrontCpu);
            Write(msg, value.FrontMem);
            Write(msg, value.FrontGcCount1);
            Write(msg, value.FrontGcCount0);
            Write(msg, value.FrontGcCount2);
            Write(msg, value.FrontHandleCount);
            Write(msg, value.FrontThreadCount);
            Write(msg, value.GameCpu);
            Write(msg, value.GameMem);
            Write(msg, value.GameGcCount0);
            Write(msg, value.GameGcCount1);
            Write(msg, value.GameGcCount2);
            Write(msg, value.GameHandleCount);
            Write(msg, value.GameThreadCount);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TicketInfoV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.TicketInfoV2Noti();
                
            if (!Read(msg, out value.TicketInfos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TicketInfoV2Noti value)
        {
            Write(msg, value.TicketInfos);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.TicketInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.TicketInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.TicketInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.TicketInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TicketUpdateNoti value)
        {
            value = new NetProtocol.Packet.G2C.TicketUpdateNoti();
                
            if (!Read(msg, out value.Ticket))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TicketUpdateNoti value)
        {
            Write(msg, value.Ticket);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TriggerActivateMapMoveV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.TriggerActivateMapMoveV2Noti();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.Pos))
                return false;
            if (!Read(msg, out value.Dir))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TriggerActivateMapMoveV2Noti value)
        {
            Write(msg, value.Err);
            Write(msg, value.Index);
            Write(msg, value.Pos);
            Write(msg, value.Dir);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TriggerActivateV2Res value)
        {
            value = new NetProtocol.Packet.G2C.TriggerActivateV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.ConditionIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TriggerActivateV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Index);
            Write(msg, value.ConditionIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.UnionV2Res value)
        {
            value = new NetProtocol.Packet.G2C.UnionV2Res();
                
            if (!Read(msg, out value.Bytes))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.UnionV2Res value)
        {
            Write(msg, value.Bytes);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.WorldBossDamagedInfoNoti value)
        {
            value = new NetProtocol.Packet.G2C.WorldBossDamagedInfoNoti();
                
            if (!Read(msg, out value.WorldBossMonsterIndex))
                return false;
            if (!Read(msg, out value.Infos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.WorldBossDamagedInfoNoti value)
        {
            Write(msg, value.WorldBossMonsterIndex);
            Write(msg, value.Infos);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.WorldBossDamagedInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.WorldBossDamagedInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.WorldBossDamagedInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.WorldBossDamagedInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ZoneLoadingCompletedRes value)
        {
            value = new NetProtocol.Packet.G2C.ZoneLoadingCompletedRes();
                
            if (!Read(msg, out value.Err))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ZoneLoadingCompletedRes value)
        {
            Write(msg, value.Err);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyChangeLootingNoti value)
        {
            value = new NetProtocol.Packet.G2C.PartyChangeLootingNoti();
                
            if (!Read(msg, out value.PreviousLootingType))
                return false;
            if (!Read(msg, out value.ChangedLootingType))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyChangeLootingNoti value)
        {
            Write(msg, value.PreviousLootingType);
            Write(msg, value.ChangedLootingType);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyChangeLootingRes value)
        {
            value = new NetProtocol.Packet.G2C.PartyChangeLootingRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.LootingType))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyChangeLootingRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.LootingType);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyCreateRes value)
        {
            value = new NetProtocol.Packet.G2C.PartyCreateRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Party))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyCreateRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Party);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Party.PartyInfo value)
        {
            value = new NetProtocol.Models.Party.PartyInfo();
                
            if (!Read(msg, out value.PartyId))
                return false;
            if (!Read(msg, out value.PartyLeaderId))
                return false;
            if (!Read(msg, out value.LootingType))
                return false;
            if (!Read(msg, out value.LootingItemGrade))
                return false;
            if (!Read(msg, out value.Members))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Party.PartyInfo value)
        {
            Write(msg, value.PartyId);
            Write(msg, value.PartyLeaderId);
            Write(msg, value.LootingType);
            Write(msg, value.LootingItemGrade);
            Write(msg, value.Members);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Party.PartyMemberInfo value)
        {
            value = new NetProtocol.Models.Party.PartyMemberInfo();
                
            if (!Read(msg, out value.PartyEnterAt))
                return false;
            if (!Read(msg, out value.Member))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Party.PartyMemberInfo value)
        {
            Write(msg, value.PartyEnterAt);
            Write(msg, value.Member);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Party.PartyMemberInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Party.PartyMemberInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Party.PartyMemberInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Party.PartyMemberInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Actor.DPlayerActorForGroup value)
        {
            value = new NetProtocol.Models.Actor.DPlayerActorForGroup();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.Face))
                return false;
            if (!Read(msg, out value.Customize))
                return false;
            if (!Read(msg, out value.Property))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.Transform))
                return false;
            if (!Read(msg, out value.Guild))
                return false;
            if (!Read(msg, out value.ZoneId))
                return false;
            if (!Read(msg, out value.ZoneDataId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Actor.DPlayerActorForGroup value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.Name);
            Write(msg, value.Level);
            Write(msg, value.Face);
            Write(msg, value.Customize);
            Write(msg, value.Property);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
            Write(msg, value.Transform);
            Write(msg, value.Guild);
            Write(msg, value.ZoneId);
            Write(msg, value.ZoneDataId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyDisbandNoti value)
        {
            value = new NetProtocol.Packet.G2C.PartyDisbandNoti();
                
            if (!Read(msg, out value.LeaderActorId))
                return false;
            if (!Read(msg, out value.LeaderActorName))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyDisbandNoti value)
        {
            Write(msg, value.LeaderActorId);
            Write(msg, value.LeaderActorName);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyDisbandRes value)
        {
            value = new NetProtocol.Packet.G2C.PartyDisbandRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyDisbandRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyDungeonEntranceInquiryRes value)
        {
            value = new NetProtocol.Packet.G2C.PartyDungeonEntranceInquiryRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyDungeonEntranceInquiryRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyEnterDungeonCanceledNoti value)
        {
            value = new NetProtocol.Packet.G2C.PartyEnterDungeonCanceledNoti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyEnterDungeonCanceledNoti value)
        {
            Write(msg, value.ActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyEnterDungeonCanceledRes value)
        {
            value = new NetProtocol.Packet.G2C.PartyEnterDungeonCanceledRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyEnterDungeonCanceledRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyEnterDungeonNoti value)
        {
            value = new NetProtocol.Packet.G2C.PartyEnterDungeonNoti();
                
            if (!Read(msg, out value.DungeonIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyEnterDungeonNoti value)
        {
            Write(msg, value.DungeonIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyEnterDungeonReplyNoti value)
        {
            value = new NetProtocol.Packet.G2C.PartyEnterDungeonReplyNoti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.Reply))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyEnterDungeonReplyNoti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.Reply);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyEnterDungeonReplyRes value)
        {
            value = new NetProtocol.Packet.G2C.PartyEnterDungeonReplyRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyEnterDungeonReplyRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyEnterDungeonRes value)
        {
            value = new NetProtocol.Packet.G2C.PartyEnterDungeonRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.DungeonIndex))
                return false;
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.TicketChangeInfo))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyEnterDungeonRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.DungeonIndex);
            Write(msg, value.Level);
            Write(msg, value.TicketChangeInfo);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyEnterNoti value)
        {
            value = new NetProtocol.Packet.G2C.PartyEnterNoti();
                
            if (!Read(msg, out value.Member))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyEnterNoti value)
        {
            Write(msg, value.Member);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyInfoNoti value)
        {
            value = new NetProtocol.Packet.G2C.PartyInfoNoti();
                
            if (!Read(msg, out value.Party))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyInfoNoti value)
        {
            Write(msg, value.Party);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyInfoRes value)
        {
            value = new NetProtocol.Packet.G2C.PartyInfoRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyInfoRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyInviteNoti value)
        {
            value = new NetProtocol.Packet.G2C.PartyInviteNoti();
                
            if (!Read(msg, out value.PartyId))
                return false;
            if (!Read(msg, out value.InviterName))
                return false;
            if (!Read(msg, out value.InviterActorId))
                return false;
            if (!Read(msg, out value.ExpireAt))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyInviteNoti value)
        {
            Write(msg, value.PartyId);
            Write(msg, value.InviterName);
            Write(msg, value.InviterActorId);
            Write(msg, value.ExpireAt);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyInviteReplyNoti value)
        {
            value = new NetProtocol.Packet.G2C.PartyInviteReplyNoti();
                
            if (!Read(msg, out value.RefuseActorId))
                return false;
            if (!Read(msg, out value.RefusePlayerName))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyInviteReplyNoti value)
        {
            Write(msg, value.RefuseActorId);
            Write(msg, value.RefusePlayerName);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyInviteReplyRes value)
        {
            value = new NetProtocol.Packet.G2C.PartyInviteReplyRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Party))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyInviteReplyRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Party);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyInviteRes value)
        {
            value = new NetProtocol.Packet.G2C.PartyInviteRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.ExpireAt))
                return false;
            if (!Read(msg, out value.InvitedActorId))
                return false;
            if (!Read(msg, out value.InvitedActorName))
                return false;
            if (!Read(msg, out value.InvitedActorLevel))
                return false;
            if (!Read(msg, out value.ClassId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyInviteRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.ExpireAt);
            Write(msg, value.InvitedActorId);
            Write(msg, value.InvitedActorName);
            Write(msg, value.InvitedActorLevel);
            Write(msg, value.ClassId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyKickedNoti value)
        {
            value = new NetProtocol.Packet.G2C.PartyKickedNoti();
                
            if (!Read(msg, out value.KickActorId))
                return false;
            if (!Read(msg, out value.KickActorName))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyKickedNoti value)
        {
            Write(msg, value.KickActorId);
            Write(msg, value.KickActorName);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyLeaderChangeNoti value)
        {
            value = new NetProtocol.Packet.G2C.PartyLeaderChangeNoti();
                
            if (!Read(msg, out value.LeaderActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyLeaderChangeNoti value)
        {
            Write(msg, value.LeaderActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyLeaderChangeRes value)
        {
            value = new NetProtocol.Packet.G2C.PartyLeaderChangeRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.LeaderActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyLeaderChangeRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.LeaderActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyLeaveNoti value)
        {
            value = new NetProtocol.Packet.G2C.PartyLeaveNoti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyLeaveNoti value)
        {
            Write(msg, value.ActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyLeaveRes value)
        {
            value = new NetProtocol.Packet.G2C.PartyLeaveRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyLeaveRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyMemberKickNoti value)
        {
            value = new NetProtocol.Packet.G2C.PartyMemberKickNoti();
                
            if (!Read(msg, out value.KickedActorId))
                return false;
            if (!Read(msg, out value.KickedActorName))
                return false;
            if (!Read(msg, out value.Party))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyMemberKickNoti value)
        {
            Write(msg, value.KickedActorId);
            Write(msg, value.KickedActorName);
            Write(msg, value.Party);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyMemberKickRes value)
        {
            value = new NetProtocol.Packet.G2C.PartyMemberKickRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.KickedActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyMemberKickRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.KickedActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartyMemberUpdateNoti value)
        {
            value = new NetProtocol.Packet.G2C.PartyMemberUpdateNoti();
                
            if (!Read(msg, out value.Member))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartyMemberUpdateNoti value)
        {
            Write(msg, value.Member);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PartySuggestionPlayersRes value)
        {
            value = new NetProtocol.Packet.G2C.PartySuggestionPlayersRes();
                
            if (!Read(msg, out value.SuggestionPlayers))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PartySuggestionPlayersRes value)
        {
            Write(msg, value.SuggestionPlayers);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Party.PartySuggestionPlayer value)
        {
            value = new NetProtocol.Models.Party.PartySuggestionPlayer();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.ClassId))
                return false;
            if (!Read(msg, out value.GuildInfo))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Party.PartySuggestionPlayer value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.Name);
            Write(msg, value.Level);
            Write(msg, value.ClassId);
            Write(msg, value.GuildInfo);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Party.PartySuggestionPlayer> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Party.PartySuggestionPlayer>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Party.PartySuggestionPlayer val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Party.PartySuggestionPlayer> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PetCollectInfoV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PetCollectInfoV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.PetCollects))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PetCollectInfoV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.PetCollects);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.PetCollect[] value)
        {
            int count = 0;
            Read(msg, out count);

            value = new NetProtocol.Packet.PetCollect[count];

            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.PetCollect val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.PetCollect[] value)
        {
            Write(msg, value.Length);
            for (int i = 0; i < value.Length; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PetEquipOffV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PetEquipOffV2Noti();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.PetIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PetEquipOffV2Noti value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.PetIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PetEquipOffV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PetEquipOffV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PetEquipOffV2Res value)
        {
            Write(msg, value.Result);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PetEquipV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PetEquipV2Noti();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.PetIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PetEquipV2Noti value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.PetIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PetEquipV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PetEquipV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.PetIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PetEquipV2Res value)
        {
            Write(msg, value.Result);
            Write(msg, value.PetIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PetFeedUseV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PetFeedUseV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Pet))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PetFeedUseV2Res value)
        {
            Write(msg, value.Result);
            Write(msg, value.Pet);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PetGachaV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PetGachaV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Pets))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PetGachaV2Res value)
        {
            Write(msg, value.Result);
            Write(msg, value.Pets);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PetInActiveBuffRes value)
        {
            value = new NetProtocol.Packet.G2C.PetInActiveBuffRes();
                
            if (!Read(msg, out value.Err))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PetInActiveBuffRes value)
        {
            Write(msg, value.Err);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PetInfoV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PetInfoV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.EquipPetIndex))
                return false;
            if (!Read(msg, out value.Pets))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PetInfoV2Res value)
        {
            Write(msg, value.Result);
            Write(msg, value.EquipPetIndex);
            Write(msg, value.Pets);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.PetData> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.PetData>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.PetData val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.PetData> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PetMixV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PetMixV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Mixes))
                return false;
            if (!Read(msg, out value.Pets))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PetMixV2Res value)
        {
            Write(msg, value.Result);
            Write(msg, value.Mixes);
            Write(msg, value.Pets);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.PetMixData> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.PetMixData>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.PetMixData val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.PetMixData> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PetUpgradeV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PetUpgradeV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Pet))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PetUpgradeV2Res value)
        {
            Write(msg, value.Result);
            Write(msg, value.Pet);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PhaseFieldEndV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PhaseFieldEndV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.Pos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PhaseFieldEndV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Index);
            Write(msg, value.State);
            Write(msg, value.Pos);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PhaseFieldStartV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PhaseFieldStartV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PhaseFieldStartV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Index);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.AuthenticateBotCredentialRes value)
        {
            value = new NetProtocol.Packet.G2C.AuthenticateBotCredentialRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.WorldAccount))
                return false;
            if (!Read(msg, out value.Players))
                return false;
            if (!Read(msg, out value.Profile))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.AuthenticateBotCredentialRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.WorldAccount);
            Write(msg, value.Players);
            Write(msg, value.Profile);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerEnterStageFifthRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerEnterStageFifthRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerEnterStageFifthRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerEnterStageFirstRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerEnterStageFirstRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerEnterStageFirstRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerEnterStageFourthRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerEnterStageFourthRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerEnterStageFourthRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerEnterStageSecondRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerEnterStageSecondRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerEnterStageSecondRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerEnterStageThirdRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerEnterStageThirdRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerEnterStageThirdRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerGameEnterRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerGameEnterRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Actor))
                return false;
            if (!Read(msg, out value.AlarmInfo))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerGameEnterRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Actor);
            Write(msg, value.AlarmInfo);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Actor.DPlayerActor value)
        {
            value = new NetProtocol.Models.Actor.DPlayerActor();
                
            if (!Read(msg, out value.Name))
                return false;
            if (!Read(msg, out value.Level))
                return false;
            if (!Read(msg, out value.Exp))
                return false;
            if (!Read(msg, out value.Title))
                return false;
            if (!Read(msg, out value.ZoneDataId))
                return false;
            if (!Read(msg, out value.Face))
                return false;
            if (!Read(msg, out value.Customize))
                return false;
            if (!Read(msg, out value.Stats))
                return false;
            if (!Read(msg, out value.StatPoints))
                return false;
            if (!Read(msg, out value.Property))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.Transform))
                return false;
            if (!Read(msg, out value.Guild))
                return false;
            if (!Read(msg, out value.Equipment))
                return false;
            if (!Read(msg, out value.EquipPet))
                return false;
            if (!Read(msg, out value.Ride))
                return false;
            if (!Read(msg, out value.Costume))
                return false;
            if (!Read(msg, out value.Skills))
                return false;
            if (!Read(msg, out value.Quests))
                return false;
            if (!Read(msg, out value.AcceptedDailyQuestCount))
                return false;
            if (!Read(msg, out value.RerollCount))
                return false;
            if (!Read(msg, out value.IsOpenDailyQuest))
                return false;
            if (!Read(msg, out value.KarmaPoint))
                return false;
            if (!Read(msg, out value.ZoneState))
                return false;
            if (!Read(msg, out value.CombatCapability))
                return false;
            if (!Read(msg, out value.SyncStat))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Actor.DPlayerActor value)
        {
            Write(msg, value.Name);
            Write(msg, value.Level);
            Write(msg, value.Exp);
            Write(msg, value.Title);
            Write(msg, value.ZoneDataId);
            Write(msg, value.Face);
            Write(msg, value.Customize);
            Write(msg, value.Stats);
            Write(msg, value.StatPoints);
            Write(msg, value.Property);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
            Write(msg, value.Transform);
            Write(msg, value.Guild);
            Write(msg, value.Equipment);
            Write(msg, value.EquipPet);
            Write(msg, value.Ride);
            Write(msg, value.Costume);
            Write(msg, value.Skills);
            Write(msg, value.Quests);
            Write(msg, value.AcceptedDailyQuestCount);
            Write(msg, value.RerollCount);
            Write(msg, value.IsOpenDailyQuest);
            Write(msg, value.KarmaPoint);
            Write(msg, value.ZoneState);
            Write(msg, value.CombatCapability);
            Write(msg, value.SyncStat);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Actor.Features.DActorSkill value)
        {
            value = new NetProtocol.Models.Actor.Features.DActorSkill();
                
            if (!Read(msg, out value.Skills))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Actor.Features.DActorSkill value)
        {
            Write(msg, value.Skills);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Skill.Features.PlayerSkillInfo value)
        {
            value = new NetProtocol.Models.Skill.Features.PlayerSkillInfo();
                
            if (!Read(msg, out value.SkillCharacterId))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.SkillSerial))
                return false;
            if (!Read(msg, out value.SkillGrade))
                return false;
            if (!Read(msg, out value.SkillLevel))
                return false;
            if (!Read(msg, out value.IsAuto))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Skill.Features.PlayerSkillInfo value)
        {
            Write(msg, value.SkillCharacterId);
            Write(msg, value.Index);
            Write(msg, value.SkillSerial);
            Write(msg, value.SkillGrade);
            Write(msg, value.SkillLevel);
            Write(msg, value.IsAuto);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Skill.Features.PlayerSkillInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Skill.Features.PlayerSkillInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Skill.Features.PlayerSkillInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Skill.Features.PlayerSkillInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerSelectRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerSelectRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.ServerTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerSelectRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.ServerTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.MembershipAddNoti value)
        {
            value = new NetProtocol.Packet.G2C.MembershipAddNoti();
                
            if (!Read(msg, out value.Info))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.MembershipAddNoti value)
        {
            Write(msg, value.Info);
        }
        public static bool Read(Message msg, out NetProtocol.Models.etc.MembershipInfo value)
        {
            value = new NetProtocol.Models.etc.MembershipInfo();
                
            if (!Read(msg, out value.MembershipIndex))
                return false;
            if (!Read(msg, out value.ExpireTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.etc.MembershipInfo value)
        {
            Write(msg, value.MembershipIndex);
            Write(msg, value.ExpireTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.MembershipListNoti value)
        {
            value = new NetProtocol.Packet.G2C.MembershipListNoti();
                
            if (!Read(msg, out value.Memberships))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.MembershipListNoti value)
        {
            Write(msg, value.Memberships);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.etc.MembershipInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.etc.MembershipInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.etc.MembershipInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.etc.MembershipInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.MembershipUpdateNoti value)
        {
            value = new NetProtocol.Packet.G2C.MembershipUpdateNoti();
                
            if (!Read(msg, out value.Info))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.MembershipUpdateNoti value)
        {
            Write(msg, value.Info);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerClassUpV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PlayerClassUpV2Res();
                
            if (!Read(msg, out value.ClassType))
                return false;
            if (!Read(msg, out value.EquipSlot))
                return false;
            if (!Read(msg, out value.EquipItemId))
                return false;
            if (!Read(msg, out value.ErrorCode))
                return false;
            if (!Read(msg, out value.Skills))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerClassUpV2Res value)
        {
            Write(msg, value.ClassType);
            Write(msg, value.EquipSlot);
            Write(msg, value.EquipItemId);
            Write(msg, value.ErrorCode);
            Write(msg, value.Skills);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerCombatCapabilityNoti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerCombatCapabilityNoti();
                
            if (!Read(msg, out value.CombatCapability))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerCombatCapabilityNoti value)
        {
            Write(msg, value.CombatCapability);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerCrimeV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerCrimeV2Noti();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.IsCriminal))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerCrimeV2Noti value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.IsCriminal);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerDeathInfoRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerDeathInfoRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.DeathInfo))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerDeathInfoRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.DeathInfo);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerDeleteRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerDeleteRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerDeleteRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerEventV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerEventV2Noti();
                
            if (!Read(msg, out value.Events))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerEventV2Noti value)
        {
            Write(msg, value.Events);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.PlayerEvent> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.PlayerEvent>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.PlayerEvent val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.PlayerEvent> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerExpChangeV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerExpChangeV2Noti();
                
            if (!Read(msg, out value.Exp))
                return false;
            if (!Read(msg, out value.GainExp))
                return false;
            if (!Read(msg, out value.From))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerExpChangeV2Noti value)
        {
            Write(msg, value.Exp);
            Write(msg, value.GainExp);
            Write(msg, value.From);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerExpRecoveryPopupRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerExpRecoveryPopupRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.DailyRecoveryCount))
                return false;
            if (!Read(msg, out value.ExpRecoveryHistory))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerExpRecoveryPopupRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.DailyRecoveryCount);
            Write(msg, value.ExpRecoveryHistory);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.PlayerExpRecoveryInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.PlayerExpRecoveryInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.PlayerExpRecoveryInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.PlayerExpRecoveryInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerGetMacroRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerGetMacroRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Macros))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerGetMacroRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Macros);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Player.PlayerMacroInfo value)
        {
            value = new NetProtocol.Models.Player.PlayerMacroInfo();
                
            if (!Read(msg, out value.Number))
                return false;
            if (!Read(msg, out value.Message))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Player.PlayerMacroInfo value)
        {
            Write(msg, value.Number);
            Write(msg, value.Message);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Player.PlayerMacroInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Player.PlayerMacroInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Player.PlayerMacroInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Player.PlayerMacroInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerLootingV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerLootingV2Noti();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.NpcId))
                return false;
            if (!Read(msg, out value.ItemTypes))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerLootingV2Noti value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.NpcId);
            Write(msg, value.ItemTypes);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerMapMoveV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PlayerMapMoveV2Res();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerMapMoveV2Res value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerMoveV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerMoveV2Noti();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.CurrentPos))
                return false;
            if (!Read(msg, out value.Dir))
                return false;
            if (!Read(msg, out value.PerformTime))
                return false;
            if (!Read(msg, out value.ServerSendTick))
                return false;
            if (!Read(msg, out value.MoveState))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerMoveV2Noti value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.CurrentPos);
            Write(msg, value.Dir);
            Write(msg, value.PerformTime);
            Write(msg, value.ServerSendTick);
            Write(msg, value.MoveState);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerMoveV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PlayerMoveV2Res();
                
            if (!Read(msg, out value.Error))
                return false;
            if (!Read(msg, out value.CurrentPos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerMoveV2Res value)
        {
            Write(msg, value.Error);
            Write(msg, value.CurrentPos);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RTTPlayerMoveV2Res value)
        {
            value = new NetProtocol.Packet.G2C.RTTPlayerMoveV2Res();
                
            if (!Read(msg, out value.Error))
                return false;
            if (!Read(msg, out value.CurrentPos))
                return false;
            if (!Read(msg, out value.UtcSendTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RTTPlayerMoveV2Res value)
        {
            Write(msg, value.Error);
            Write(msg, value.CurrentPos);
            Write(msg, value.UtcSendTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerPvpValueNoti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerPvpValueNoti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.Value))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerPvpValueNoti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.Value);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerResurrectionV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerResurrectionV2Noti();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.CurruntPos))
                return false;
            if (!Read(msg, out value.Dir))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerResurrectionV2Noti value)
        {
            Write(msg, value.Err);
            Write(msg, value.PlayerId);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
            Write(msg, value.CurruntPos);
            Write(msg, value.Dir);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerResurrectionV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PlayerResurrectionV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.MapIndex))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.Currencies))
                return false;
            if (!Read(msg, out value.CurruntPos))
                return false;
            if (!Read(msg, out value.Dir))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerResurrectionV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.MapIndex);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
            Write(msg, value.Currencies);
            Write(msg, value.CurruntPos);
            Write(msg, value.Dir);
        }
        public static bool Read(Message msg, out Dictionary<System.UInt32, System.UInt32> value)
        {
            value = new();

            int count = 0;
            Read(msg, out count);

            for (int i = 0; i < count; ++i)
            {
                if (!Read(msg, out System.UInt32 key))
                    return false;
                if (!Read(msg, out System.UInt32 val))
                    return false;

                value.Add(key, val);
            }

            return true;
        }
        public static void Write(Message msg, Dictionary<System.UInt32, System.UInt32> value)
        {
            Write(msg, value.Count);

            foreach (var pair in value)
            {
                Write(msg, pair.Key);
                Write(msg, pair.Value);
            }
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerSetMacroRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerSetMacroRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerSetMacroRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerStatChangeV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerStatChangeV2Noti();
                
            if (!Read(msg, out value.Stats))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerStatChangeV2Noti value)
        {
            Write(msg, value.Stats);
        }
        public static bool Read(Message msg, out System.ValueTuple<System.Int32, System.Double> value)
        {
            value = new(default(System.Int32), default(System.Double));
            if (!Read(msg, out value.Item1))
                return false;
            if (!Read(msg, out value.Item2))
                return false;
            return true;
        }
        public static void Write(Message msg, System.ValueTuple<System.Int32, System.Double> value)
        {
            Write(msg, value.Item1);
            Write(msg, value.Item2);
        }
        public static bool Read(Message msg, out List<System.ValueTuple<System.Int32, System.Double>> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<System.ValueTuple<System.Int32, System.Double>>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out System.ValueTuple<System.Int32, System.Double> val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<System.ValueTuple<System.Int32, System.Double>> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerStatPointChangeV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerStatPointChangeV2Noti();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.MaxHp))
                return false;
            if (!Read(msg, out value.MaxMp))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerStatPointChangeV2Noti value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
            Write(msg, value.MaxHp);
            Write(msg, value.MaxMp);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerStatPointChangeV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PlayerStatPointChangeV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.StatPoint))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.MaxHp))
                return false;
            if (!Read(msg, out value.MaxMp))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerStatPointChangeV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.StatPoint);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
            Write(msg, value.MaxHp);
            Write(msg, value.MaxMp);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerStatPointInitV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PlayerStatPointInitV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.StatPoint))
                return false;
            if (!Read(msg, out value.Hp))
                return false;
            if (!Read(msg, out value.Mp))
                return false;
            if (!Read(msg, out value.MaxHp))
                return false;
            if (!Read(msg, out value.MaxMp))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerStatPointInitV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.StatPoint);
            Write(msg, value.Hp);
            Write(msg, value.Mp);
            Write(msg, value.MaxHp);
            Write(msg, value.MaxMp);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerStatV2Res value)
        {
            value = new NetProtocol.Packet.G2C.PlayerStatV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.BaseValues))
                return false;
            if (!Read(msg, out value.BaseRates))
                return false;
            if (!Read(msg, out value.ExtendValues))
                return false;
            if (!Read(msg, out value.ExtendRates))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerStatV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.BaseValues);
            Write(msg, value.BaseRates);
            Write(msg, value.ExtendValues);
            Write(msg, value.ExtendRates);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerTendencyNoti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerTendencyNoti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.KarmaPoint))
                return false;
            if (!Read(msg, out value.PurpleActive))
                return false;
            if (!Read(msg, out value.PurpleExpireAt))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerTendencyNoti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.KarmaPoint);
            Write(msg, value.PurpleActive);
            Write(msg, value.PurpleExpireAt);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerWalletUpdateV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerWalletUpdateV2Noti();
                
            if (!Read(msg, out value.WalletInfo))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerWalletUpdateV2Noti value)
        {
            Write(msg, value.WalletInfo);
        }
        public static bool Read(Message msg, out NetProtocol.Models.etc.WalletUpdateInfoV2 value)
        {
            value = new NetProtocol.Models.etc.WalletUpdateInfoV2();
                
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Previous))
                return false;
            if (!Read(msg, out value.Current))
                return false;
            if (!Read(msg, out value.Variance))
                return false;
            if (!Read(msg, out value.FromTrace))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.etc.WalletUpdateInfoV2 value)
        {
            Write(msg, value.Type);
            Write(msg, value.Previous);
            Write(msg, value.Current);
            Write(msg, value.Variance);
            Write(msg, value.FromTrace);
        }
        public static bool Read(Message msg, out NetProtocol.Models.etc.WalletInfoV2 value)
        {
            value = new NetProtocol.Models.etc.WalletInfoV2();
                
            if (!Read(msg, out value.Free))
                return false;
            if (!Read(msg, out value.Paid))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.etc.WalletInfoV2 value)
        {
            Write(msg, value.Free);
            Write(msg, value.Paid);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerWalletV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerWalletV2Noti();
                
            if (!Read(msg, out value.WalletList))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerWalletV2Noti value)
        {
            Write(msg, value.WalletList);
        }
        public static bool Read(Message msg, out Dictionary<NetProtocol.Packet.WalletType, NetProtocol.Models.etc.WalletInfoV2> value)
        {
            value = new();

            int count = 0;
            Read(msg, out count);

            for (int i = 0; i < count; ++i)
            {
                if (!Read(msg, out NetProtocol.Packet.WalletType key))
                    return false;
                if (!Read(msg, out NetProtocol.Models.etc.WalletInfoV2 val))
                    return false;

                value.Add(key, val);
            }

            return true;
        }
        public static void Write(Message msg, Dictionary<NetProtocol.Packet.WalletType, NetProtocol.Models.etc.WalletInfoV2> value)
        {
            Write(msg, value.Count);

            foreach (var pair in value)
            {
                Write(msg, pair.Key);
                Write(msg, pair.Value);
            }
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerWantedV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerWantedV2Noti();
                
            if (!Read(msg, out value.Wanted))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerWantedV2Noti value)
        {
            Write(msg, value.Wanted);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.QuickslotListNoti value)
        {
            value = new NetProtocol.Packet.G2C.QuickslotListNoti();
                
            if (!Read(msg, out value.Infos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.QuickslotListNoti value)
        {
            Write(msg, value.Infos);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Player.QuickslotInfo value)
        {
            value = new NetProtocol.Models.Player.QuickslotInfo();
                
            if (!Read(msg, out value.SlotIndex))
                return false;
            if (!Read(msg, out value.ItemIndex))
                return false;
            if (!Read(msg, out value.IsAutoUse))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Player.QuickslotInfo value)
        {
            Write(msg, value.SlotIndex);
            Write(msg, value.ItemIndex);
            Write(msg, value.IsAutoUse);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Player.QuickslotInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Player.QuickslotInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Player.QuickslotInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Player.QuickslotInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.QuickslotSetRes value)
        {
            value = new NetProtocol.Packet.G2C.QuickslotSetRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.QuickslotInfo))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.QuickslotSetRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.QuickslotInfo);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RecoverPlayerExpRes value)
        {
            value = new NetProtocol.Packet.G2C.RecoverPlayerExpRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.UniqueId))
                return false;
            if (!Read(msg, out value.RecoverExp))
                return false;
            if (!Read(msg, out value.CurrentExp))
                return false;
            if (!Read(msg, out value.DailyRecoverCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RecoverPlayerExpRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.UniqueId);
            Write(msg, value.RecoverExp);
            Write(msg, value.CurrentExp);
            Write(msg, value.DailyRecoverCount);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CheatGetQuestV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.CheatGetQuestV2Noti();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.AcceptQuest))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CheatGetQuestV2Noti value)
        {
            Write(msg, value.Err);
            Write(msg, value.AcceptQuest);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.DailyQuestOpenV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.DailyQuestOpenV2Noti();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.AddedQuests))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.DailyQuestOpenV2Noti value)
        {
            Write(msg, value.Err);
            Write(msg, value.AddedQuests);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerQuestProgressV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.PlayerQuestProgressV2Noti();
                
            if (!Read(msg, out value.GroupId))
                return false;
            if (!Read(msg, out value.DetailId))
                return false;
            if (!Read(msg, out value.QuestObjectiveId))
                return false;
            if (!Read(msg, out value.QuestObjectiveCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerQuestProgressV2Noti value)
        {
            Write(msg, value.GroupId);
            Write(msg, value.DetailId);
            Write(msg, value.QuestObjectiveId);
            Write(msg, value.QuestObjectiveCount);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.QuestAbandonV2Res value)
        {
            value = new NetProtocol.Packet.G2C.QuestAbandonV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.QuestId))
                return false;
            if (!Read(msg, out value.AcceptedDailyQuestCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.QuestAbandonV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.QuestId);
            Write(msg, value.AcceptedDailyQuestCount);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.QuestAcceptV2Res value)
        {
            value = new NetProtocol.Packet.G2C.QuestAcceptV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.QuestInfo))
                return false;
            if (!Read(msg, out value.AcceptedDailyQuestCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.QuestAcceptV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.QuestInfo);
            Write(msg, value.AcceptedDailyQuestCount);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.QuestCompleteV2Res value)
        {
            value = new NetProtocol.Packet.G2C.QuestCompleteV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.QuestId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.QuestCompleteV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.QuestId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.QuestConditionCompleteV2Res value)
        {
            value = new NetProtocol.Packet.G2C.QuestConditionCompleteV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Quest))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.QuestConditionCompleteV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Quest);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.QuestListV2Res value)
        {
            value = new NetProtocol.Packet.G2C.QuestListV2Res();
                
            if (!Read(msg, out value.Quests))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.QuestListV2Res value)
        {
            Write(msg, value.Quests);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.QuestPortalV2Res value)
        {
            value = new NetProtocol.Packet.G2C.QuestPortalV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.QuestPortalV2Res value)
        {
            Write(msg, value.Err);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.QuestRegisterV2Res value)
        {
            value = new NetProtocol.Packet.G2C.QuestRegisterV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Quest))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.QuestRegisterV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Quest);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.QuestRerollV2Res value)
        {
            value = new NetProtocol.Packet.G2C.QuestRerollV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.RerollCount))
                return false;
            if (!Read(msg, out value.AddedDailyQuests))
                return false;
            if (!Read(msg, out value.DeletedDailyQuests))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.QuestRerollV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.RerollCount);
            Write(msg, value.AddedDailyQuests);
            Write(msg, value.DeletedDailyQuests);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.QuestResetCheatV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.QuestResetCheatV2Noti();
                
            if (!Read(msg, out value.Err))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.QuestResetCheatV2Noti value)
        {
            Write(msg, value.Err);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.QuestRewardV2Res value)
        {
            value = new NetProtocol.Packet.G2C.QuestRewardV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.QuestId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.QuestRewardV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.QuestId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.QuestTalkCompleteV2Res value)
        {
            value = new NetProtocol.Packet.G2C.QuestTalkCompleteV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.QuestTalkCompleteV2Res value)
        {
            Write(msg, value.Err);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ResetDailyQuestV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ResetDailyQuestV2Noti();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.DeletedQuestIds))
                return false;
            if (!Read(msg, out value.AddedQuests))
                return false;
            if (!Read(msg, out value.AcceptedCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ResetDailyQuestV2Noti value)
        {
            Write(msg, value.Err);
            Write(msg, value.DeletedQuestIds);
            Write(msg, value.AddedQuests);
            Write(msg, value.AcceptedCount);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TutorialSkipV2Res value)
        {
            value = new NetProtocol.Packet.G2C.TutorialSkipV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TutorialSkipV2Res value)
        {
            Write(msg, value.Err);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GuildRelationRes value)
        {
            value = new NetProtocol.Packet.G2C.GuildRelationRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Info))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GuildRelationRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Info);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.PlayerRelationRes value)
        {
            value = new NetProtocol.Packet.G2C.PlayerRelationRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Info))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.PlayerRelationRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Info);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RelationsNoti value)
        {
            value = new NetProtocol.Packet.G2C.RelationsNoti();
                
            if (!Read(msg, out value.Relations))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RelationsNoti value)
        {
            Write(msg, value.Relations);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.RelationInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.RelationInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.RelationInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.RelationInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RideAttachDeleteV2Res value)
        {
            value = new NetProtocol.Packet.G2C.RideAttachDeleteV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.AttachIDs))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RideAttachDeleteV2Res value)
        {
            Write(msg, value.Result);
            Write(msg, value.AttachIDs);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RideAttachDisassembleV2Res value)
        {
            value = new NetProtocol.Packet.G2C.RideAttachDisassembleV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.AttachIDs))
                return false;
            if (!Read(msg, out value.Items))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RideAttachDisassembleV2Res value)
        {
            Write(msg, value.Result);
            Write(msg, value.AttachIDs);
            Write(msg, value.Items);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RideAttachEquipOffV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.RideAttachEquipOffV2Noti();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.AttachPart))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RideAttachEquipOffV2Noti value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.AttachPart);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RideAttachEquipOffV2Res value)
        {
            value = new NetProtocol.Packet.G2C.RideAttachEquipOffV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.RideIndex))
                return false;
            if (!Read(msg, out value.AttachPart))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RideAttachEquipOffV2Res value)
        {
            Write(msg, value.Result);
            Write(msg, value.RideIndex);
            Write(msg, value.AttachPart);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RideAttachEquipV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.RideAttachEquipV2Noti();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.RideIndex))
                return false;
            if (!Read(msg, out value.AttachPart))
                return false;
            if (!Read(msg, out value.AttachIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RideAttachEquipV2Noti value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.RideIndex);
            Write(msg, value.AttachPart);
            Write(msg, value.AttachIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RideAttachEquipV2Res value)
        {
            value = new NetProtocol.Packet.G2C.RideAttachEquipV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.RideIndex))
                return false;
            if (!Read(msg, out value.AttachID))
                return false;
            if (!Read(msg, out value.AttachPart))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RideAttachEquipV2Res value)
        {
            Write(msg, value.Result);
            Write(msg, value.RideIndex);
            Write(msg, value.AttachID);
            Write(msg, value.AttachPart);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RideAttachGachaV2Res value)
        {
            value = new NetProtocol.Packet.G2C.RideAttachGachaV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.RideAttaches))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RideAttachGachaV2Res value)
        {
            Write(msg, value.Result);
            Write(msg, value.RideAttaches);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.RideAttachData> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.RideAttachData>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.RideAttachData val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.RideAttachData> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RideAttachInvenExtendV2Res value)
        {
            value = new NetProtocol.Packet.G2C.RideAttachInvenExtendV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.ItemIndex))
                return false;
            if (!Read(msg, out value.ItemCount))
                return false;
            if (!Read(msg, out value.AttachInvenSize))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RideAttachInvenExtendV2Res value)
        {
            Write(msg, value.Result);
            Write(msg, value.ItemIndex);
            Write(msg, value.ItemCount);
            Write(msg, value.AttachInvenSize);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RideCollectInfosNoti value)
        {
            value = new NetProtocol.Packet.G2C.RideCollectInfosNoti();
                
            if (!Read(msg, out value.CompleteCollectIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RideCollectInfosNoti value)
        {
            Write(msg, value.CompleteCollectIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RideEquipOffV2Res value)
        {
            value = new NetProtocol.Packet.G2C.RideEquipOffV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RideEquipOffV2Res value)
        {
            Write(msg, value.Result);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RideEquipV2Res value)
        {
            value = new NetProtocol.Packet.G2C.RideEquipV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.RideIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RideEquipV2Res value)
        {
            Write(msg, value.Result);
            Write(msg, value.RideIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RideGachaV2Res value)
        {
            value = new NetProtocol.Packet.G2C.RideGachaV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Rides))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RideGachaV2Res value)
        {
            Write(msg, value.Result);
            Write(msg, value.Rides);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RideInfosNoti value)
        {
            value = new NetProtocol.Packet.G2C.RideInfosNoti();
                
            if (!Read(msg, out value.EquipRideIndex))
                return false;
            if (!Read(msg, out value.EquipRideSit))
                return false;
            if (!Read(msg, out value.AttachInvenSize))
                return false;
            if (!Read(msg, out value.Rides))
                return false;
            if (!Read(msg, out value.RideAttaches))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RideInfosNoti value)
        {
            Write(msg, value.EquipRideIndex);
            Write(msg, value.EquipRideSit);
            Write(msg, value.AttachInvenSize);
            Write(msg, value.Rides);
            Write(msg, value.RideAttaches);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.RideData> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.RideData>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.RideData val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.RideData> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RideMixV2Res value)
        {
            value = new NetProtocol.Packet.G2C.RideMixV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            if (!Read(msg, out value.Mixes))
                return false;
            if (!Read(msg, out value.Rides))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RideMixV2Res value)
        {
            Write(msg, value.Result);
            Write(msg, value.Mixes);
            Write(msg, value.Rides);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.RideMixData> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.RideMixData>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.RideMixData val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.RideMixData> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RideSitOffV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.RideSitOffV2Noti();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RideSitOffV2Noti value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RideSitOffV2Res value)
        {
            value = new NetProtocol.Packet.G2C.RideSitOffV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RideSitOffV2Res value)
        {
            Write(msg, value.Result);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RideSitV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.RideSitV2Noti();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.RideIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RideSitV2Noti value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.RideIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RideSitV2Res value)
        {
            value = new NetProtocol.Packet.G2C.RideSitV2Res();
                
            if (!Read(msg, out value.Result))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RideSitV2Res value)
        {
            Write(msg, value.Result);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BuyCashShopItemV2Res value)
        {
            value = new NetProtocol.Packet.G2C.BuyCashShopItemV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.CashShopInfo))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BuyCashShopItemV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.CashShopInfo);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BuyGameShopItemV2Res value)
        {
            value = new NetProtocol.Packet.G2C.BuyGameShopItemV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BuyGameShopItemV2Res value)
        {
            Write(msg, value.Err);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GameShopSellItemV2Res value)
        {
            value = new NetProtocol.Packet.G2C.GameShopSellItemV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GameShopSellItemV2Res value)
        {
            Write(msg, value.Err);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ShopBuyCountListNoti value)
        {
            value = new NetProtocol.Packet.G2C.ShopBuyCountListNoti();
                
            if (!Read(msg, out value.CashShopInfos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ShopBuyCountListNoti value)
        {
            Write(msg, value.CashShopInfos);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.ShopInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.ShopInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.ShopInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.ShopInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ChangedSiegeWarMatchInfoV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ChangedSiegeWarMatchInfoV2Noti();
                
            if (!Read(msg, out value.MatchInfo))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ChangedSiegeWarMatchInfoV2Noti value)
        {
            Write(msg, value.MatchInfo);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ChangeSiegeModeV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ChangeSiegeModeV2Res();
                
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.Error))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ChangeSiegeModeV2Res value)
        {
            Write(msg, value.State);
            Write(msg, value.Error);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ChangeSiegeWarInfoV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ChangeSiegeWarInfoV2Noti();
                
            if (!Read(msg, out value.Info))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ChangeSiegeWarInfoV2Noti value)
        {
            Write(msg, value.Info);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ChangeSiegeWarObjectInfoV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ChangeSiegeWarObjectInfoV2Noti();
                
            if (!Read(msg, out value.Object))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ChangeSiegeWarObjectInfoV2Noti value)
        {
            Write(msg, value.Object);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ChoiceSiegeWarFactionV2Res value)
        {
            value = new NetProtocol.Packet.G2C.ChoiceSiegeWarFactionV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.ChoiceMatchInfo))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ChoiceSiegeWarFactionV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.ChoiceMatchInfo);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.CreatedDungeonSiegeWarV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.CreatedDungeonSiegeWarV2Noti();
                
            if (!Read(msg, out value.DungeonIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.CreatedDungeonSiegeWarV2Noti value)
        {
            Write(msg, value.DungeonIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.DungeonSiegeWarClearV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.DungeonSiegeWarClearV2Noti();
                
            if (!Read(msg, out value.ClearType))
                return false;
            if (!Read(msg, out value.Error))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.DungeonSiegeWarClearV2Noti value)
        {
            Write(msg, value.ClearType);
            Write(msg, value.Error);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GetSiegeWarInfoV2Res value)
        {
            value = new NetProtocol.Packet.G2C.GetSiegeWarInfoV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Info))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GetSiegeWarInfoV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Info);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.GetSiegeWarMatchInfoV2Res value)
        {
            value = new NetProtocol.Packet.G2C.GetSiegeWarMatchInfoV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.MatchInfos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.GetSiegeWarMatchInfoV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.MatchInfos);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.SiegeWarMatchInfo[] value)
        {
            int count = 0;
            Read(msg, out count);

            value = new NetProtocol.Packet.SiegeWarMatchInfo[count];

            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.SiegeWarMatchInfo val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.SiegeWarMatchInfo[] value)
        {
            Write(msg, value.Length);
            for (int i = 0; i < value.Length; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ShowLocalizationV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ShowLocalizationV2Noti();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.Args))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ShowLocalizationV2Noti value)
        {
            Write(msg, value.Index);
            Write(msg, value.Args);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ActorChangeBattleModeV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.ActorChangeBattleModeV2Noti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.IsBattleMode))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ActorChangeBattleModeV2Noti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.IsBattleMode);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.BuffListInfoV2Res value)
        {
            value = new NetProtocol.Packet.G2C.BuffListInfoV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Buffs))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.BuffListInfoV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Buffs);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.SkillChangeAutoUseV2Res value)
        {
            value = new NetProtocol.Packet.G2C.SkillChangeAutoUseV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Skills))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.SkillChangeAutoUseV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.Skills);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.OwnSkill> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.OwnSkill>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.OwnSkill val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.OwnSkill> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.SkillChangePresetV2Res value)
        {
            value = new NetProtocol.Packet.G2C.SkillChangePresetV2Res();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.PresetNumber))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.SkillChangePresetV2Res value)
        {
            Write(msg, value.Status);
            Write(msg, value.PresetNumber);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.SkillDotEffectV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.SkillDotEffectV2Noti();
                
            if (!Read(msg, out value.CasterActorId))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            if (!Read(msg, out value.SkillLinkId))
                return false;
            if (!Read(msg, out value.Damage))
                return false;
            if (!Read(msg, out value.Judgment))
                return false;
            if (!Read(msg, out value.BarrierValue))
                return false;
            if (!Read(msg, out value.BarrierStack))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.SkillDotEffectV2Noti value)
        {
            Write(msg, value.CasterActorId);
            Write(msg, value.TargetActorId);
            Write(msg, value.SkillLinkId);
            Write(msg, value.Damage);
            Write(msg, value.Judgment);
            Write(msg, value.BarrierValue);
            Write(msg, value.BarrierStack);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.SkillDotHealEffectV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.SkillDotHealEffectV2Noti();
                
            if (!Read(msg, out value.CasterActorId))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            if (!Read(msg, out value.SkillLinkId))
                return false;
            if (!Read(msg, out value.Amount))
                return false;
            if (!Read(msg, out value.IsHp))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.SkillDotHealEffectV2Noti value)
        {
            Write(msg, value.CasterActorId);
            Write(msg, value.TargetActorId);
            Write(msg, value.SkillLinkId);
            Write(msg, value.Amount);
            Write(msg, value.IsHp);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.SkillEquipV2Res value)
        {
            value = new NetProtocol.Packet.G2C.SkillEquipV2Res();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.PresetNumber))
                return false;
            if (!Read(msg, out value.SlotNumber))
                return false;
            if (!Read(msg, out value.SkillSerial))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.SkillEquipV2Res value)
        {
            Write(msg, value.Status);
            Write(msg, value.PresetNumber);
            Write(msg, value.SlotNumber);
            Write(msg, value.SkillSerial);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.SkillHitEffectV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.SkillHitEffectV2Noti();
                
            if (!Read(msg, out value.AttackerActorId))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            if (!Read(msg, out value.SkillLinkId))
                return false;
            if (!Read(msg, out value.PreviousPosition))
                return false;
            if (!Read(msg, out value.ResultPosition))
                return false;
            if (!Read(msg, out value.BuffId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.SkillHitEffectV2Noti value)
        {
            Write(msg, value.AttackerActorId);
            Write(msg, value.TargetActorId);
            Write(msg, value.SkillLinkId);
            Write(msg, value.PreviousPosition);
            Write(msg, value.ResultPosition);
            Write(msg, value.BuffId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.SkillHitV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.SkillHitV2Noti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            if (!Read(msg, out value.SkillIndex))
                return false;
            if (!Read(msg, out value.SkillLinkId))
                return false;
            if (!Read(msg, out value.Damage))
                return false;
            if (!Read(msg, out value.Judgment))
                return false;
            if (!Read(msg, out value.BarrierValue))
                return false;
            if (!Read(msg, out value.BarrierStack))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.SkillHitV2Noti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.TargetActorId);
            Write(msg, value.SkillIndex);
            Write(msg, value.SkillLinkId);
            Write(msg, value.Damage);
            Write(msg, value.Judgment);
            Write(msg, value.BarrierValue);
            Write(msg, value.BarrierStack);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.SkillHitV2Res value)
        {
            value = new NetProtocol.Packet.G2C.SkillHitV2Res();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.SkillHitV2Res value)
        {
            Write(msg, value.Status);
            Write(msg, value.TargetActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RTTSkillHitV2Res value)
        {
            value = new NetProtocol.Packet.G2C.RTTSkillHitV2Res();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            if (!Read(msg, out value.UtcSendTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RTTSkillHitV2Res value)
        {
            Write(msg, value.Status);
            Write(msg, value.TargetActorId);
            Write(msg, value.UtcSendTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.SkillLearnV2Res value)
        {
            value = new NetProtocol.Packet.G2C.SkillLearnV2Res();
                
            if (!Read(msg, out value.Error))
                return false;
            if (!Read(msg, out value.Skill))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.SkillLearnV2Res value)
        {
            Write(msg, value.Error);
            Write(msg, value.Skill);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.SkillLevelUpV2Res value)
        {
            value = new NetProtocol.Packet.G2C.SkillLevelUpV2Res();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Skill))
                return false;
            if (!Read(msg, out value.PreviousSkillIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.SkillLevelUpV2Res value)
        {
            Write(msg, value.Status);
            Write(msg, value.Skill);
            Write(msg, value.PreviousSkillIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.SkillListInfoV2Res value)
        {
            value = new NetProtocol.Packet.G2C.SkillListInfoV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.SkillListInfoV2Res value)
        {
            Write(msg, value.Err);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.SkillPreActionEndV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.SkillPreActionEndV2Noti();
                
            if (!Read(msg, out value.ObjId))
                return false;
            if (!Read(msg, out value.IsCancel))
                return false;
            if (!Read(msg, out value.SkillIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.SkillPreActionEndV2Noti value)
        {
            Write(msg, value.ObjId);
            Write(msg, value.IsCancel);
            Write(msg, value.SkillIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.SkillPresetInfosNoti value)
        {
            value = new NetProtocol.Packet.G2C.SkillPresetInfosNoti();
                
            if (!Read(msg, out value.SkillPresets))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.SkillPresetInfosNoti value)
        {
            Write(msg, value.SkillPresets);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Skill.Features.SkillPreset value)
        {
            value = new NetProtocol.Models.Skill.Features.SkillPreset();
                
            if (!Read(msg, out value.PresetNum))
                return false;
            if (!Read(msg, out value.IsSelected))
                return false;
            if (!Read(msg, out value.EquipSkills))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Skill.Features.SkillPreset value)
        {
            Write(msg, value.PresetNum);
            Write(msg, value.IsSelected);
            Write(msg, value.EquipSkills);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Skill.Features.SkillPreset> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Skill.Features.SkillPreset>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Skill.Features.SkillPreset val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Skill.Features.SkillPreset> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Skill.Features.SkillInfo value)
        {
            value = new NetProtocol.Models.Skill.Features.SkillInfo();
                
            if (!Read(msg, out value.Serial))
                return false;
            if (!Read(msg, out value.Slot))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Skill.Features.SkillInfo value)
        {
            Write(msg, value.Serial);
            Write(msg, value.Slot);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Skill.Features.SkillInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Skill.Features.SkillInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Skill.Features.SkillInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Skill.Features.SkillInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.SkillUnEquipV2Res value)
        {
            value = new NetProtocol.Packet.G2C.SkillUnEquipV2Res();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.PresetNumber))
                return false;
            if (!Read(msg, out value.SlotNumber))
                return false;
            if (!Read(msg, out value.IsAll))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.SkillUnEquipV2Res value)
        {
            Write(msg, value.Status);
            Write(msg, value.PresetNumber);
            Write(msg, value.SlotNumber);
            Write(msg, value.IsAll);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.SkillUpgradeV2Res value)
        {
            value = new NetProtocol.Packet.G2C.SkillUpgradeV2Res();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Skill))
                return false;
            if (!Read(msg, out value.PreviousSkillIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.SkillUpgradeV2Res value)
        {
            Write(msg, value.Status);
            Write(msg, value.Skill);
            Write(msg, value.PreviousSkillIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.SkillUseV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.SkillUseV2Noti();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            if (!Read(msg, out value.SkillIndex))
                return false;
            if (!Read(msg, out value.CastingTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.SkillUseV2Noti value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.TargetActorId);
            Write(msg, value.SkillIndex);
            Write(msg, value.CastingTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.SkillUseV2Res value)
        {
            value = new NetProtocol.Packet.G2C.SkillUseV2Res();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.SkillUseV2Res value)
        {
            Write(msg, value.Status);
            Write(msg, value.TargetActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.RTTSkillUseV2Res value)
        {
            value = new NetProtocol.Packet.G2C.RTTSkillUseV2Res();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            if (!Read(msg, out value.UtcSendTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.RTTSkillUseV2Res value)
        {
            Write(msg, value.Status);
            Write(msg, value.TargetActorId);
            Write(msg, value.UtcSendTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TitleAddV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.TitleAddV2Noti();
                
            if (!Read(msg, out value.TitleIndexList))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TitleAddV2Noti value)
        {
            Write(msg, value.TitleIndexList);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TitleChangeV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.TitleChangeV2Noti();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.TitleIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TitleChangeV2Noti value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.TitleIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TitleChangeV2Res value)
        {
            value = new NetProtocol.Packet.G2C.TitleChangeV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.TitleIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TitleChangeV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.TitleIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TitleConditionUpdateV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.TitleConditionUpdateV2Noti();
                
            if (!Read(msg, out value.TitleConditions))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TitleConditionUpdateV2Noti value)
        {
            Write(msg, value.TitleConditions);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.TitleConditionInfo[] value)
        {
            int count = 0;
            Read(msg, out count);

            value = new NetProtocol.Packet.TitleConditionInfo[count];

            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.TitleConditionInfo val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.TitleConditionInfo[] value)
        {
            Write(msg, value.Length);
            for (int i = 0; i < value.Length; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TitleListV2Res value)
        {
            value = new NetProtocol.Packet.G2C.TitleListV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.TitleConditionInfoList))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TitleListV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.TitleConditionInfoList);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeCronAverageBalanceRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeCronAverageBalanceRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.PreviousDayAverageBalance))
                return false;
            if (!Read(msg, out value.WeeklyAverageBalance))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeCronAverageBalanceRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.PreviousDayAverageBalance);
            Write(msg, value.WeeklyAverageBalance);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeCronBalanceRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeCronBalanceRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Balance))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeCronBalanceRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Balance);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeCronBuyRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeCronBuyRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.PurchasedTradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeCronBuyRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.PurchasedTradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeCronCancelRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeCronCancelRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeCronCancelRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeCronInfoRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeCronInfoRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Balance))
                return false;
            if (!Read(msg, out value.TimeSpanTicks))
                return false;
            if (!Read(msg, out value.Infos))
                return false;
            if (!Read(msg, out value.PreviousDayBalanceInfos))
                return false;
            if (!Read(msg, out value.WeeklyBalanceInfos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeCronInfoRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Balance);
            Write(msg, value.TimeSpanTicks);
            Write(msg, value.Infos);
            Write(msg, value.PreviousDayBalanceInfos);
            Write(msg, value.WeeklyBalanceInfos);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Trade.TradeCronInfo value)
        {
            value = new NetProtocol.Models.Trade.TradeCronInfo();
                
            if (!Read(msg, out value.TradeId))
                return false;
            if (!Read(msg, out value.Amount))
                return false;
            if (!Read(msg, out value.Price))
                return false;
            if (!Read(msg, out value.At))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Trade.TradeCronInfo value)
        {
            Write(msg, value.TradeId);
            Write(msg, value.Amount);
            Write(msg, value.Price);
            Write(msg, value.At);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Trade.TradeCronInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Trade.TradeCronInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Trade.TradeCronInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Trade.TradeCronInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Trade.CronBalanceInfo value)
        {
            value = new NetProtocol.Models.Trade.CronBalanceInfo();
                
            if (!Read(msg, out value.Balance))
                return false;
            if (!Read(msg, out value.At))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Trade.CronBalanceInfo value)
        {
            Write(msg, value.Balance);
            Write(msg, value.At);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Trade.CronBalanceInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Trade.CronBalanceInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Trade.CronBalanceInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Trade.CronBalanceInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeCronListRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeCronListRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Infos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeCronListRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Infos);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeCronMyListRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeCronMyListRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Infos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeCronMyListRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Infos);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Trade.TradeCronMyInfo value)
        {
            value = new NetProtocol.Models.Trade.TradeCronMyInfo();
                
            if (!Read(msg, out value.TradeId))
                return false;
            if (!Read(msg, out value.Amount))
                return false;
            if (!Read(msg, out value.Price))
                return false;
            if (!Read(msg, out value.SettledPrice))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.At))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Trade.TradeCronMyInfo value)
        {
            Write(msg, value.TradeId);
            Write(msg, value.Amount);
            Write(msg, value.Price);
            Write(msg, value.SettledPrice);
            Write(msg, value.State);
            Write(msg, value.At);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Trade.TradeCronMyInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Trade.TradeCronMyInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Trade.TradeCronMyInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Trade.TradeCronMyInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeCronPreviousDayBalanceRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeCronPreviousDayBalanceRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Infos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeCronPreviousDayBalanceRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Infos);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeCronReclaimExpiredRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeCronReclaimExpiredRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeCronReclaimExpiredRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeCronRemainingCanceledPenaltyTimeRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeCronRemainingCanceledPenaltyTimeRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.RemainingCanceledPenaltyTimeSpanTicks))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeCronRemainingCanceledPenaltyTimeRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.RemainingCanceledPenaltyTimeSpanTicks);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeCronSellRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeCronSellRes();
                
            if (!Read(msg, out value.Status))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeCronSellRes value)
        {
            Write(msg, value.Status);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeCronSettleRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeCronSettleRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeCronSettleRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeCronTimeToNextChangeBalanceRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeCronTimeToNextChangeBalanceRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.TimeSpanTicks))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeCronTimeToNextChangeBalanceRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.TimeSpanTicks);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeCronTradesRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeCronTradesRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Infos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeCronTradesRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Infos);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Trade.TradeCronTradeInfo value)
        {
            value = new NetProtocol.Models.Trade.TradeCronTradeInfo();
                
            if (!Read(msg, out value.TradeId))
                return false;
            if (!Read(msg, out value.Amount))
                return false;
            if (!Read(msg, out value.Price))
                return false;
            if (!Read(msg, out value.SettledPrice))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.At))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Trade.TradeCronTradeInfo value)
        {
            Write(msg, value.TradeId);
            Write(msg, value.Amount);
            Write(msg, value.Price);
            Write(msg, value.SettledPrice);
            Write(msg, value.State);
            Write(msg, value.At);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Trade.TradeCronTradeInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Trade.TradeCronTradeInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Trade.TradeCronTradeInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Trade.TradeCronTradeInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeCronWeeklyBalanceRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeCronWeeklyBalanceRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.Infos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeCronWeeklyBalanceRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.Infos);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeItemBookmarkAddRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeItemBookmarkAddRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.ItemIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeItemBookmarkAddRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.ItemIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeItemBookmarkDeleteRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeItemBookmarkDeleteRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.ItemIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeItemBookmarkDeleteRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.ItemIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeItemBookmarkListNoti value)
        {
            value = new NetProtocol.Packet.G2C.TradeItemBookmarkListNoti();
                
            if (!Read(msg, out value.BookmarkList))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeItemBookmarkListNoti value)
        {
            Write(msg, value.BookmarkList);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeItemBuyRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeItemBuyRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeItemBuyRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeItemCancelRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeItemCancelRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeItemCancelRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeItemDeleteNoti value)
        {
            value = new NetProtocol.Packet.G2C.TradeItemDeleteNoti();
                
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeItemDeleteNoti value)
        {
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeItemFinishRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeItemFinishRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeItemFinishRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeItemHistoryRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeItemHistoryRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.TradeHistorys))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeItemHistoryRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.TradeHistorys);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Trade.TradeItemHistoryInfo value)
        {
            value = new NetProtocol.Models.Trade.TradeItemHistoryInfo();
                
            if (!Read(msg, out value.TradeId))
                return false;
            if (!Read(msg, out value.TradeAt))
                return false;
            if (!Read(msg, out value.SellerId))
                return false;
            if (!Read(msg, out value.BuyerId))
                return false;
            if (!Read(msg, out value.Price))
                return false;
            if (!Read(msg, out value.Tax))
                return false;
            if (!Read(msg, out value.Item))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Trade.TradeItemHistoryInfo value)
        {
            Write(msg, value.TradeId);
            Write(msg, value.TradeAt);
            Write(msg, value.SellerId);
            Write(msg, value.BuyerId);
            Write(msg, value.Price);
            Write(msg, value.Tax);
            Write(msg, value.Item);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Trade.TradeItemHistoryInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Trade.TradeItemHistoryInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Trade.TradeItemHistoryInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Trade.TradeItemHistoryInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Trade.TradeItem value)
        {
            value = new NetProtocol.Models.Trade.TradeItem();
                
            if (!Read(msg, out value.ItemId))
                return false;
            if (!Read(msg, out value.DataId))
                return false;
            if (!Read(msg, out value.Belong))
                return false;
            if (!Read(msg, out value.Qty))
                return false;
            if (!Read(msg, out value.DownLevel))
                return false;
            if (!Read(msg, out value.Enchant))
                return false;
            if (!Read(msg, out value.SocketCount))
                return false;
            if (!Read(msg, out value.OptionList))
                return false;
            if (!Read(msg, out value.SkillCount))
                return false;
            if (!Read(msg, out value.SkillList))
                return false;
            if (!Read(msg, out value.SubStatList))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Trade.TradeItem value)
        {
            Write(msg, value.ItemId);
            Write(msg, value.DataId);
            Write(msg, value.Belong);
            Write(msg, value.Qty);
            Write(msg, value.DownLevel);
            Write(msg, value.Enchant);
            Write(msg, value.SocketCount);
            Write(msg, value.OptionList);
            Write(msg, value.SkillCount);
            Write(msg, value.SkillList);
            Write(msg, value.SubStatList);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeItemRegistRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeItemRegistRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Trade))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeItemRegistRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.Trade);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Trade.TradeItemInfo value)
        {
            value = new NetProtocol.Models.Trade.TradeItemInfo();
                
            if (!Read(msg, out value.TradeId))
                return false;
            if (!Read(msg, out value.SellerId))
                return false;
            if (!Read(msg, out value.BuyerId))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.Price))
                return false;
            if (!Read(msg, out value.Tax))
                return false;
            if (!Read(msg, out value.MainCategory))
                return false;
            if (!Read(msg, out value.SubCategory))
                return false;
            if (!Read(msg, out value.Item))
                return false;
            if (!Read(msg, out value.ResistedAt))
                return false;
            if (!Read(msg, out value.ExpireTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Trade.TradeItemInfo value)
        {
            Write(msg, value.TradeId);
            Write(msg, value.SellerId);
            Write(msg, value.BuyerId);
            Write(msg, value.State);
            Write(msg, value.Price);
            Write(msg, value.Tax);
            Write(msg, value.MainCategory);
            Write(msg, value.SubCategory);
            Write(msg, value.Item);
            Write(msg, value.ResistedAt);
            Write(msg, value.ExpireTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeItemSearchCategoryRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeItemSearchCategoryRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.MainCategory))
                return false;
            if (!Read(msg, out value.SubCategory))
                return false;
            if (!Read(msg, out value.TradeCategorys))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeItemSearchCategoryRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.MainCategory);
            Write(msg, value.SubCategory);
            Write(msg, value.TradeCategorys);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Trade.TradeItemCategoryData value)
        {
            value = new NetProtocol.Models.Trade.TradeItemCategoryData();
                
            if (!Read(msg, out value.ItemIndex))
                return false;
            if (!Read(msg, out value.Count))
                return false;
            if (!Read(msg, out value.MinPrice))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Trade.TradeItemCategoryData value)
        {
            Write(msg, value.ItemIndex);
            Write(msg, value.Count);
            Write(msg, value.MinPrice);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Trade.TradeItemCategoryData> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Trade.TradeItemCategoryData>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Trade.TradeItemCategoryData val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Trade.TradeItemCategoryData> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeItemSearchItemIndexRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeItemSearchItemIndexRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.ItemIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeItemSearchItemIndexRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.ItemIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeItemSearchListNoti value)
        {
            value = new NetProtocol.Packet.G2C.TradeItemSearchListNoti();
                
            if (!Read(msg, out value.IsEnd))
                return false;
            if (!Read(msg, out value.TradeItemInfos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeItemSearchListNoti value)
        {
            Write(msg, value.IsEnd);
            Write(msg, value.TradeItemInfos);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Trade.TradeItemInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Trade.TradeItemInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Trade.TradeItemInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Trade.TradeItemInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeItemSellListNoti value)
        {
            value = new NetProtocol.Packet.G2C.TradeItemSellListNoti();
                
            if (!Read(msg, out value.SellTrades))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeItemSellListNoti value)
        {
            Write(msg, value.SellTrades);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeItemUpdateNoti value)
        {
            value = new NetProtocol.Packet.G2C.TradeItemUpdateNoti();
                
            if (!Read(msg, out value.Trade))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeItemUpdateNoti value)
        {
            Write(msg, value.Trade);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradeItemWithdrawRes value)
        {
            value = new NetProtocol.Packet.G2C.TradeItemWithdrawRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradeItemWithdrawRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradePersonalAcceptRes value)
        {
            value = new NetProtocol.Packet.G2C.TradePersonalAcceptRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradePersonalAcceptRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradePersonalAddNoti value)
        {
            value = new NetProtocol.Packet.G2C.TradePersonalAddNoti();
                
            if (!Read(msg, out value.Trade))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradePersonalAddNoti value)
        {
            Write(msg, value.Trade);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Trade.TradePersonalInfo value)
        {
            value = new NetProtocol.Models.Trade.TradePersonalInfo();
                
            if (!Read(msg, out value.TradeId))
                return false;
            if (!Read(msg, out value.SellerId))
                return false;
            if (!Read(msg, out value.SellerName))
                return false;
            if (!Read(msg, out value.BuyerId))
                return false;
            if (!Read(msg, out value.BuyerName))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.Price))
                return false;
            if (!Read(msg, out value.Tax))
                return false;
            if (!Read(msg, out value.Item))
                return false;
            if (!Read(msg, out value.ResistedAt))
                return false;
            if (!Read(msg, out value.ExpireTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Trade.TradePersonalInfo value)
        {
            Write(msg, value.TradeId);
            Write(msg, value.SellerId);
            Write(msg, value.SellerName);
            Write(msg, value.BuyerId);
            Write(msg, value.BuyerName);
            Write(msg, value.State);
            Write(msg, value.Price);
            Write(msg, value.Tax);
            Write(msg, value.Item);
            Write(msg, value.ResistedAt);
            Write(msg, value.ExpireTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradePersonalCancelRes value)
        {
            value = new NetProtocol.Packet.G2C.TradePersonalCancelRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradePersonalCancelRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradePersonalDeleteNoti value)
        {
            value = new NetProtocol.Packet.G2C.TradePersonalDeleteNoti();
                
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradePersonalDeleteNoti value)
        {
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradePersonalFinishRes value)
        {
            value = new NetProtocol.Packet.G2C.TradePersonalFinishRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradePersonalFinishRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradePersonalHistoryRes value)
        {
            value = new NetProtocol.Packet.G2C.TradePersonalHistoryRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.TradeHistorys))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradePersonalHistoryRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.TradeHistorys);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Trade.TradePersonalHistoryInfo value)
        {
            value = new NetProtocol.Models.Trade.TradePersonalHistoryInfo();
                
            if (!Read(msg, out value.TradeId))
                return false;
            if (!Read(msg, out value.TradeAt))
                return false;
            if (!Read(msg, out value.SellerId))
                return false;
            if (!Read(msg, out value.SellerName))
                return false;
            if (!Read(msg, out value.BuyerId))
                return false;
            if (!Read(msg, out value.BuyerName))
                return false;
            if (!Read(msg, out value.Price))
                return false;
            if (!Read(msg, out value.Tax))
                return false;
            if (!Read(msg, out value.Item))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Trade.TradePersonalHistoryInfo value)
        {
            Write(msg, value.TradeId);
            Write(msg, value.TradeAt);
            Write(msg, value.SellerId);
            Write(msg, value.SellerName);
            Write(msg, value.BuyerId);
            Write(msg, value.BuyerName);
            Write(msg, value.Price);
            Write(msg, value.Tax);
            Write(msg, value.Item);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Trade.TradePersonalHistoryInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Trade.TradePersonalHistoryInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Trade.TradePersonalHistoryInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Trade.TradePersonalHistoryInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradePersonalListNoti value)
        {
            value = new NetProtocol.Packet.G2C.TradePersonalListNoti();
                
            if (!Read(msg, out value.SellTrades))
                return false;
            if (!Read(msg, out value.BuyTrades))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradePersonalListNoti value)
        {
            Write(msg, value.SellTrades);
            Write(msg, value.BuyTrades);
        }
        public static bool Read(Message msg, out List<NetProtocol.Models.Trade.TradePersonalInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Models.Trade.TradePersonalInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Models.Trade.TradePersonalInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Models.Trade.TradePersonalInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradePersonalRefuseRes value)
        {
            value = new NetProtocol.Packet.G2C.TradePersonalRefuseRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradePersonalRefuseRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradePersonalRequestRes value)
        {
            value = new NetProtocol.Packet.G2C.TradePersonalRequestRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.Trade))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradePersonalRequestRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.Trade);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradePersonalUpdateNoti value)
        {
            value = new NetProtocol.Packet.G2C.TradePersonalUpdateNoti();
                
            if (!Read(msg, out value.Trade))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradePersonalUpdateNoti value)
        {
            Write(msg, value.Trade);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.TradePersonalWithdrawRes value)
        {
            value = new NetProtocol.Packet.G2C.TradePersonalWithdrawRes();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.TradePersonalWithdrawRes value)
        {
            Write(msg, value.Err);
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.WeaponAppearanceCollectListV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.WeaponAppearanceCollectListV2Noti();
                
            if (!Read(msg, out value.ItemCollects))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.WeaponAppearanceCollectListV2Noti value)
        {
            Write(msg, value.ItemCollects);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.WeaponAppearanceCollectListV2Res value)
        {
            value = new NetProtocol.Packet.G2C.WeaponAppearanceCollectListV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.ItemCollects))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.WeaponAppearanceCollectListV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.ItemCollects);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.WeaponAppearanceEquipV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.WeaponAppearanceEquipV2Noti();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.ItemDataId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.WeaponAppearanceEquipV2Noti value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.ItemDataId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.WeaponAppearanceEquipV2Res value)
        {
            value = new NetProtocol.Packet.G2C.WeaponAppearanceEquipV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.WeaponAppearance))
                return false;
            if (!Read(msg, out value.ItemIndex))
                return false;
            if (!Read(msg, out value.UnequipItemIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.WeaponAppearanceEquipV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.WeaponAppearance);
            Write(msg, value.ItemIndex);
            Write(msg, value.UnequipItemIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.WeaponAppearanceExtractFromItemV2Res value)
        {
            value = new NetProtocol.Packet.G2C.WeaponAppearanceExtractFromItemV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.ItemCollects))
                return false;
            if (!Read(msg, out value.WeaponAppearances))
                return false;
            if (!Read(msg, out value.InvenSetItems))
                return false;
            if (!Read(msg, out value.ExtractItems))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.WeaponAppearanceExtractFromItemV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.ItemCollects);
            Write(msg, value.WeaponAppearances);
            Write(msg, value.InvenSetItems);
            Write(msg, value.ExtractItems);
        }
        public static bool Read(Message msg, out List<NetProtocol.Packet.WeaponAppearanceInfo> value)
        {
            int count = 0;
            Read(msg, out count);
            
            value = new List<NetProtocol.Packet.WeaponAppearanceInfo>(count);
            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.WeaponAppearanceInfo val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<NetProtocol.Packet.WeaponAppearanceInfo> value)
        {
            Write(msg, value.Count);
            for (int i = 0; i < value.Count; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.WeaponAppearanceGachaV2Res value)
        {
            value = new NetProtocol.Packet.G2C.WeaponAppearanceGachaV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.ItemCollects))
                return false;
            if (!Read(msg, out value.WeaponAppearances))
                return false;
            if (!Read(msg, out value.InvenSetItems))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.WeaponAppearanceGachaV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.ItemCollects);
            Write(msg, value.WeaponAppearances);
            Write(msg, value.InvenSetItems);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.WeaponAppearanceHiddenV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.WeaponAppearanceHiddenV2Noti();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.ItemIndex))
                return false;
            if (!Read(msg, out value.IsHidden))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.WeaponAppearanceHiddenV2Noti value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.ItemIndex);
            Write(msg, value.IsHidden);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.WeaponAppearanceHiddenV2Res value)
        {
            value = new NetProtocol.Packet.G2C.WeaponAppearanceHiddenV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.ItemIndex))
                return false;
            if (!Read(msg, out value.IsHidden))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.WeaponAppearanceHiddenV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.ItemIndex);
            Write(msg, value.IsHidden);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.WeaponAppearanceListV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.WeaponAppearanceListV2Noti();
                
            if (!Read(msg, out value.WeaponAppearanceInfos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.WeaponAppearanceListV2Noti value)
        {
            Write(msg, value.WeaponAppearanceInfos);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.WeaponAppearanceInfo[] value)
        {
            int count = 0;
            Read(msg, out count);

            value = new NetProtocol.Packet.WeaponAppearanceInfo[count];

            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out NetProtocol.Packet.WeaponAppearanceInfo val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.WeaponAppearanceInfo[] value)
        {
            Write(msg, value.Length);
            for (int i = 0; i < value.Length; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.WeaponAppearanceListV2Res value)
        {
            value = new NetProtocol.Packet.G2C.WeaponAppearanceListV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.WeaponAppearanceInfos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.WeaponAppearanceListV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.WeaponAppearanceInfos);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.WeaponAppearanceUnequipV2Noti value)
        {
            value = new NetProtocol.Packet.G2C.WeaponAppearanceUnequipV2Noti();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.ItemDataId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.WeaponAppearanceUnequipV2Noti value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.ItemDataId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.WeaponAppearanceUnequipV2Res value)
        {
            value = new NetProtocol.Packet.G2C.WeaponAppearanceUnequipV2Res();
                
            if (!Read(msg, out value.Err))
                return false;
            if (!Read(msg, out value.ItemDataId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.WeaponAppearanceUnequipV2Res value)
        {
            Write(msg, value.Err);
            Write(msg, value.ItemDataId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ZoneStatusNoti value)
        {
            value = new NetProtocol.Packet.G2C.ZoneStatusNoti();
                
            if (!Read(msg, out value.ZoneOverview))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ZoneStatusNoti value)
        {
            Write(msg, value.ZoneOverview);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Zone.DZoneOverview value)
        {
            value = new NetProtocol.Models.Zone.DZoneOverview();
                
            if (!Read(msg, out value.OccupyingGuild))
                return false;
            if (!Read(msg, out value.BloodFogIndexes))
                return false;
            if (!Read(msg, out value.DarkPortalIndexes))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Zone.DZoneOverview value)
        {
            Write(msg, value.OccupyingGuild);
            Write(msg, value.BloodFogIndexes);
            Write(msg, value.DarkPortalIndexes);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.G2C.ZoneStatusRes value)
        {
            value = new NetProtocol.Packet.G2C.ZoneStatusRes();
                
            if (!Read(msg, out value.Status))
                return false;
            if (!Read(msg, out value.ZoneOverview))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.G2C.ZoneStatusRes value)
        {
            Write(msg, value.Status);
            Write(msg, value.ZoneOverview);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.AccountCreateNameReq value)
        {
            value = new NetProtocol.Packet.C2G.AccountCreateNameReq();
                
            if (!Read(msg, out value.AccountId))
                return false;
            if (!Read(msg, out value.AccountName))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.AccountCreateNameReq value)
        {
            Write(msg, value.AccountId);
            Write(msg, value.AccountName);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.DesignateBindStoneReq value)
        {
            value = new NetProtocol.Packet.C2G.DesignateBindStoneReq();
                
            if (!Read(msg, out value.BindStoneIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.DesignateBindStoneReq value)
        {
            Write(msg, value.BindStoneIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PortalByBindStoneReq value)
        {
            value = new NetProtocol.Packet.C2G.PortalByBindStoneReq();
                
            if (!Read(msg, out value.FromBindStoneIndex))
                return false;
            if (!Read(msg, out value.ToBindStoneIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PortalByBindStoneReq value)
        {
            Write(msg, value.FromBindStoneIndex);
            Write(msg, value.ToBindStoneIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerBlackRosterGetPreferenceReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerBlackRosterGetPreferenceReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerBlackRosterGetPreferenceReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerBlackRosterLastWeekRankReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerBlackRosterLastWeekRankReq();
                
            if (!Read(msg, out value.RankType))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerBlackRosterLastWeekRankReq value)
        {
            Write(msg, value.RankType);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerBlackRosterObservingReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerBlackRosterObservingReq();
                
            if (!Read(msg, out value.UniqueId))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerBlackRosterObservingReq value)
        {
            Write(msg, value.UniqueId);
            Write(msg, value.TargetActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerBlackRosterProvocationReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerBlackRosterProvocationReq();
                
            if (!Read(msg, out value.UniqueId))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            if (!Read(msg, out value.Message))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerBlackRosterProvocationReq value)
        {
            Write(msg, value.UniqueId);
            Write(msg, value.TargetActorId);
            Write(msg, value.Message);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerBlackRosterRankReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerBlackRosterRankReq();
                
            if (!Read(msg, out value.RankType))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerBlackRosterRankReq value)
        {
            Write(msg, value.RankType);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerBlackRosterRevengeReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerBlackRosterRevengeReq();
                
            if (!Read(msg, out value.UniqueId))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerBlackRosterRevengeReq value)
        {
            Write(msg, value.UniqueId);
            Write(msg, value.TargetActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerBlackRosterSetPreferenceReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerBlackRosterSetPreferenceReq();
                
            if (!Read(msg, out value.IsAuto))
                return false;
            if (!Read(msg, out value.KillMessage))
                return false;
            if (!Read(msg, out value.DeathMessage))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerBlackRosterSetPreferenceReq value)
        {
            Write(msg, value.IsAuto);
            Write(msg, value.KillMessage);
            Write(msg, value.DeathMessage);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerBlackRostersReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerBlackRostersReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerBlackRostersReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.BloodFogEnterReq value)
        {
            value = new NetProtocol.Packet.C2G.BloodFogEnterReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.BloodFogEnterReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.BloodFogLeaveReq value)
        {
            value = new NetProtocol.Packet.C2G.BloodFogLeaveReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.BloodFogLeaveReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.BloodFogUseBuffReq value)
        {
            value = new NetProtocol.Packet.C2G.BloodFogUseBuffReq();
                
            if (!Read(msg, out value.BuffIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.BloodFogUseBuffReq value)
        {
            Write(msg, value.BuffIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.CheatMessageV2Req value)
        {
            value = new NetProtocol.Packet.C2G.CheatMessageV2Req();
                
            if (!Read(msg, out value.CheatMsg))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.CheatMessageV2Req value)
        {
            Write(msg, value.CheatMsg);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.AccountBlockPlayerAddReq value)
        {
            value = new NetProtocol.Packet.C2G.AccountBlockPlayerAddReq();
                
            if (!Read(msg, out value.BlockActorId))
                return false;
            if (!Read(msg, out value.BlockReason))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.AccountBlockPlayerAddReq value)
        {
            Write(msg, value.BlockActorId);
            Write(msg, value.BlockReason);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.AccountBlockPlayerDeleteReq value)
        {
            value = new NetProtocol.Packet.C2G.AccountBlockPlayerDeleteReq();
                
            if (!Read(msg, out value.BlockAccountId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.AccountBlockPlayerDeleteReq value)
        {
            Write(msg, value.BlockAccountId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.AccountBlockPlayerReasonEditReq value)
        {
            value = new NetProtocol.Packet.C2G.AccountBlockPlayerReasonEditReq();
                
            if (!Read(msg, out value.BlockAccountId))
                return false;
            if (!Read(msg, out value.BlockReason))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.AccountBlockPlayerReasonEditReq value)
        {
            Write(msg, value.BlockAccountId);
            Write(msg, value.BlockReason);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.AccountBlockPlayersReq value)
        {
            value = new NetProtocol.Packet.C2G.AccountBlockPlayersReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.AccountBlockPlayersReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ChatMessageV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ChatMessageV2Req();
                
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.TargetId))
                return false;
            if (!Read(msg, out value.TargetName))
                return false;
            if (!Read(msg, out value.Message))
                return false;
            if (!Read(msg, out value.LinkItems))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ChatMessageV2Req value)
        {
            Write(msg, value.Type);
            Write(msg, value.TargetId);
            Write(msg, value.TargetName);
            Write(msg, value.Message);
            Write(msg, value.LinkItems);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.LinkItemInfoReq value)
        {
            value = new NetProtocol.Packet.C2G.LinkItemInfoReq();
                
            if (!Read(msg, out value.LinkedItemUniqueId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.LinkItemInfoReq value)
        {
            Write(msg, value.LinkedItemUniqueId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerSearchV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PlayerSearchV2Req();
                
            if (!Read(msg, out value.SearchName))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerSearchV2Req value)
        {
            Write(msg, value.SearchName);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.CostumeCardBuildReq value)
        {
            value = new NetProtocol.Packet.C2G.CostumeCardBuildReq();
                
            if (!Read(msg, out value.CardIndex))
                return false;
            if (!Read(msg, out value.CostumeIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.CostumeCardBuildReq value)
        {
            Write(msg, value.CardIndex);
            Write(msg, value.CostumeIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.CostumeCardGachaReq value)
        {
            value = new NetProtocol.Packet.C2G.CostumeCardGachaReq();
                
            if (!Read(msg, out value.ItemId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.CostumeCardGachaReq value)
        {
            Write(msg, value.ItemId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.CostumeCardInfoReq value)
        {
            value = new NetProtocol.Packet.C2G.CostumeCardInfoReq();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.CostumeCardInfoReq value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.CostumeCardMixReq value)
        {
            value = new NetProtocol.Packet.C2G.CostumeCardMixReq();
                
            if (!Read(msg, out value.Mixes))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.CostumeCardMixReq value)
        {
            Write(msg, value.Mixes);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.CostumeCollectReq value)
        {
            value = new NetProtocol.Packet.C2G.CostumeCollectReq();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.CostumeCollectReq value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.CostumeConfirmAcceptReq value)
        {
            value = new NetProtocol.Packet.C2G.CostumeConfirmAcceptReq();
                
            if (!Read(msg, out value.ConfirmID))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.CostumeConfirmAcceptReq value)
        {
            Write(msg, value.ConfirmID);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.CostumeConfirmChangeReq value)
        {
            value = new NetProtocol.Packet.C2G.CostumeConfirmChangeReq();
                
            if (!Read(msg, out value.ConfirmID))
                return false;
            if (!Read(msg, out value.ReRollNow))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.CostumeConfirmChangeReq value)
        {
            Write(msg, value.ConfirmID);
            Write(msg, value.ReRollNow);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.CostumeConfirmInfoReq value)
        {
            value = new NetProtocol.Packet.C2G.CostumeConfirmInfoReq();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.CostumeConfirmInfoReq value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.CostumeEquipBodyReq value)
        {
            value = new NetProtocol.Packet.C2G.CostumeEquipBodyReq();
                
            if (!Read(msg, out value.CostumeIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.CostumeEquipBodyReq value)
        {
            Write(msg, value.CostumeIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.CostumeEquipBodyShowReq value)
        {
            value = new NetProtocol.Packet.C2G.CostumeEquipBodyShowReq();
                
            if (!Read(msg, out value.IsShow))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.CostumeEquipBodyShowReq value)
        {
            Write(msg, value.IsShow);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.CostumeEquipHeadReq value)
        {
            value = new NetProtocol.Packet.C2G.CostumeEquipHeadReq();
                
            if (!Read(msg, out value.CostumeIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.CostumeEquipHeadReq value)
        {
            Write(msg, value.CostumeIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.CostumeEquipHeadShowReq value)
        {
            value = new NetProtocol.Packet.C2G.CostumeEquipHeadShowReq();
                
            if (!Read(msg, out value.IsShow))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.CostumeEquipHeadShowReq value)
        {
            Write(msg, value.IsShow);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.CostumeInfoReq value)
        {
            value = new NetProtocol.Packet.C2G.CostumeInfoReq();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.CostumeInfoReq value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PortalEffectReq value)
        {
            value = new NetProtocol.Packet.C2G.PortalEffectReq();
                
            if (!Read(msg, out value.FromTrace))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PortalEffectReq value)
        {
            Write(msg, value.FromTrace);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.AttainmentDailyRewardV2Req value)
        {
            value = new NetProtocol.Packet.C2G.AttainmentDailyRewardV2Req();
                
            if (!Read(msg, out value.EventIndex))
                return false;
            if (!Read(msg, out value.Day))
                return false;
            if (!Read(msg, out value.AchieveConditionIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.AttainmentDailyRewardV2Req value)
        {
            Write(msg, value.EventIndex);
            Write(msg, value.Day);
            Write(msg, value.AchieveConditionIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.AttainmentNormalRewardV2Req value)
        {
            value = new NetProtocol.Packet.C2G.AttainmentNormalRewardV2Req();
                
            if (!Read(msg, out value.EventIndex))
                return false;
            if (!Read(msg, out value.AchieveConditionIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.AttainmentNormalRewardV2Req value)
        {
            Write(msg, value.EventIndex);
            Write(msg, value.AchieveConditionIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.AttendanceRewardV2Req value)
        {
            value = new NetProtocol.Packet.C2G.AttendanceRewardV2Req();
                
            if (!Read(msg, out value.EventIndex))
                return false;
            if (!Read(msg, out value.Day))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.AttendanceRewardV2Req value)
        {
            Write(msg, value.EventIndex);
            Write(msg, value.Day);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.BossScheduleReq value)
        {
            value = new NetProtocol.Packet.C2G.BossScheduleReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.BossScheduleReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.EventExchangeRewardV2Req value)
        {
            value = new NetProtocol.Packet.C2G.EventExchangeRewardV2Req();
                
            if (!Read(msg, out value.EventIndex))
                return false;
            if (!Read(msg, out value.Priority))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.EventExchangeRewardV2Req value)
        {
            Write(msg, value.EventIndex);
            Write(msg, value.Priority);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildAdminBuffActiveReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildAdminBuffActiveReq();
                
            if (!Read(msg, out value.BuffIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildAdminBuffActiveReq value)
        {
            Write(msg, value.BuffIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildAdminBuffBuyReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildAdminBuffBuyReq();
                
            if (!Read(msg, out value.BuffIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildAdminBuffBuyReq value)
        {
            Write(msg, value.BuffIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildAdminInfoReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildAdminInfoReq();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildAdminInfoReq value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildAdminLevelUpReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildAdminLevelUpReq();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.MemberType))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildAdminLevelUpReq value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.MemberType);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildAdminMasterChangeReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildAdminMasterChangeReq();
                
            if (!Read(msg, out value.AccountId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildAdminMasterChangeReq value)
        {
            Write(msg, value.AccountId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildAdminMemberBanishReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildAdminMemberBanishReq();
                
            if (!Read(msg, out value.AccountId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildAdminMemberBanishReq value)
        {
            Write(msg, value.AccountId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildAdminMemberUpdateReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildAdminMemberUpdateReq();
                
            if (!Read(msg, out value.AccountId))
                return false;
            if (!Read(msg, out value.MemberType))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildAdminMemberUpdateReq value)
        {
            Write(msg, value.AccountId);
            Write(msg, value.MemberType);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildAdminUpdateBaseReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildAdminUpdateBaseReq();
                
            if (!Read(msg, out value.CrestImage))
                return false;
            if (!Read(msg, out value.CrestFrame))
                return false;
            if (!Read(msg, out value.Tendency))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildAdminUpdateBaseReq value)
        {
            Write(msg, value.CrestImage);
            Write(msg, value.CrestFrame);
            Write(msg, value.Tendency);
            Write(msg, value.Type);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildAdminUpdateIntroReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildAdminUpdateIntroReq();
                
            if (!Read(msg, out value.Intro))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildAdminUpdateIntroReq value)
        {
            Write(msg, value.Intro);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildAdminUpdateNoticeReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildAdminUpdateNoticeReq();
                
            if (!Read(msg, out value.Notice))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildAdminUpdateNoticeReq value)
        {
            Write(msg, value.Notice);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildAdminUpdateTendencyReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildAdminUpdateTendencyReq();
                
            if (!Read(msg, out value.Tendency))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildAdminUpdateTendencyReq value)
        {
            Write(msg, value.Tendency);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildAdminUpdateTypeReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildAdminUpdateTypeReq();
                
            if (!Read(msg, out value.Type))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildAdminUpdateTypeReq value)
        {
            Write(msg, value.Type);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildAttendReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildAttendReq();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildAttendReq value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildBuffInfoReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildBuffInfoReq();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildBuffInfoReq value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildCreateReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildCreateReq();
                
            if (!Read(msg, out value.CrestImage))
                return false;
            if (!Read(msg, out value.CrestFrame))
                return false;
            if (!Read(msg, out value.GuildName))
                return false;
            if (!Read(msg, out value.Tendency))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Intro))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildCreateReq value)
        {
            Write(msg, value.CrestImage);
            Write(msg, value.CrestFrame);
            Write(msg, value.GuildName);
            Write(msg, value.Tendency);
            Write(msg, value.Type);
            Write(msg, value.Intro);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildDeleteReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildDeleteReq();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildDeleteReq value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildDonateReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildDonateReq();
                
            if (!Read(msg, out value.DonateType))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildDonateReq value)
        {
            Write(msg, value.DonateType);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildDonationByCronV2Req value)
        {
            value = new NetProtocol.Packet.C2G.GuildDonationByCronV2Req();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildDonationByCronV2Req value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildFindReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildFindReq();
                
            if (!Read(msg, out value.GuildType))
                return false;
            if (!Read(msg, out value.FindType))
                return false;
            if (!Read(msg, out value.FindCount))
                return false;
            if (!Read(msg, out value.FindPage))
                return false;
            if (!Read(msg, out value.GuildName))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildFindReq value)
        {
            Write(msg, value.GuildType);
            Write(msg, value.FindType);
            Write(msg, value.FindCount);
            Write(msg, value.FindPage);
            Write(msg, value.GuildName);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildHistroyReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildHistroyReq();
                
            if (!Read(msg, out value.FindCount))
                return false;
            if (!Read(msg, out value.FindPage))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildHistroyReq value)
        {
            Write(msg, value.FindCount);
            Write(msg, value.FindPage);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildInfoCallReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildInfoCallReq();
                
            if (!Read(msg, out value.GuildIds))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildInfoCallReq value)
        {
            Write(msg, value.GuildIds);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildInfoReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildInfoReq();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildInfoReq value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildJoinRequestConfirmReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildJoinRequestConfirmReq();
                
            if (!Read(msg, out value.AccountId))
                return false;
            if (!Read(msg, out value.Confirm))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildJoinRequestConfirmReq value)
        {
            Write(msg, value.AccountId);
            Write(msg, value.Confirm);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildJoinRequestListReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildJoinRequestListReq();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildJoinRequestListReq value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildLeaveReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildLeaveReq();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildLeaveReq value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildLiveInviteConfirmReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildLiveInviteConfirmReq();
                
            if (!Read(msg, out value.InviterName))
                return false;
            if (!Read(msg, out value.GuildId))
                return false;
            if (!Read(msg, out value.Confirm))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildLiveInviteConfirmReq value)
        {
            Write(msg, value.InviterName);
            Write(msg, value.GuildId);
            Write(msg, value.Confirm);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildLiveInviteReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildLiveInviteReq();
                
            if (!Read(msg, out value.PlayerName))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildLiveInviteReq value)
        {
            Write(msg, value.PlayerName);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildMemberInfoReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildMemberInfoReq();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildMemberInfoReq value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildSignRequestCancelReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildSignRequestCancelReq();
                
            if (!Read(msg, out value.GuildId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildSignRequestCancelReq value)
        {
            Write(msg, value.GuildId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildSignRequestListReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildSignRequestListReq();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildSignRequestListReq value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildSignRequestReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildSignRequestReq();
                
            if (!Read(msg, out value.GuildId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildSignRequestReq value)
        {
            Write(msg, value.GuildId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildTerritoryInfoReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildTerritoryInfoReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildTerritoryInfoReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildTerritorySetReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildTerritorySetReq();
                
            if (!Read(msg, out value.Info))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildTerritorySetReq value)
        {
            Write(msg, value.Info);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildVoteInfoReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildVoteInfoReq();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildVoteInfoReq value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildVoteMasterImpeachReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildVoteMasterImpeachReq();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildVoteMasterImpeachReq value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildVoteReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildVoteReq();
                
            if (!Read(msg, out value.VoteId))
                return false;
            if (!Read(msg, out value.Vote))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildVoteReq value)
        {
            Write(msg, value.VoteId);
            Write(msg, value.Vote);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildWaitingMemberListV2Req value)
        {
            value = new NetProtocol.Packet.C2G.GuildWaitingMemberListV2Req();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildWaitingMemberListV2Req value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildWarehouseChangeSizeV2Req value)
        {
            value = new NetProtocol.Packet.C2G.GuildWarehouseChangeSizeV2Req();
                
            if (!Read(msg, out value.Type))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildWarehouseChangeSizeV2Req value)
        {
            Write(msg, value.Type);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildWarehouseInfoV2Req value)
        {
            value = new NetProtocol.Packet.C2G.GuildWarehouseInfoV2Req();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildWarehouseInfoV2Req value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildWarehouseItemMoveV2Req value)
        {
            value = new NetProtocol.Packet.C2G.GuildWarehouseItemMoveV2Req();
                
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Flag))
                return false;
            if (!Read(msg, out value.Items))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildWarehouseItemMoveV2Req value)
        {
            Write(msg, value.Type);
            Write(msg, value.Flag);
            Write(msg, value.Items);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildWarehouseWalletMoveV2Req value)
        {
            value = new NetProtocol.Packet.C2G.GuildWarehouseWalletMoveV2Req();
                
            if (!Read(msg, out value.Flag))
                return false;
            if (!Read(msg, out value.WalletType))
                return false;
            if (!Read(msg, out value.WalletCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildWarehouseWalletMoveV2Req value)
        {
            Write(msg, value.Flag);
            Write(msg, value.WalletType);
            Write(msg, value.WalletCount);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.WorldTerritoryOverviewReq value)
        {
            value = new NetProtocol.Packet.C2G.WorldTerritoryOverviewReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.WorldTerritoryOverviewReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.C2SRttReq value)
        {
            value = new NetProtocol.Packet.C2G.C2SRttReq();
                
            if (!Read(msg, out value.UtcSendTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.C2SRttReq value)
        {
            Write(msg, value.UtcSendTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.C2SRttRes value)
        {
            value = new NetProtocol.Packet.C2G.C2SRttRes();
                
            if (!Read(msg, out value.UtcSendTime))
                return false;
            if (!Read(msg, out value.UtcRecvTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.C2SRttRes value)
        {
            Write(msg, value.UtcSendTime);
            Write(msg, value.UtcRecvTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.DungeonEnterV2Req value)
        {
            value = new NetProtocol.Packet.C2G.DungeonEnterV2Req();
                
            if (!Read(msg, out value.DungeonIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.DungeonEnterV2Req value)
        {
            Write(msg, value.DungeonIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.DungeonGiveUpV2Req value)
        {
            value = new NetProtocol.Packet.C2G.DungeonGiveUpV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.DungeonGiveUpV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.DungeonLeaveV2Req value)
        {
            value = new NetProtocol.Packet.C2G.DungeonLeaveV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.DungeonLeaveV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.DungeonLoadingCompleteV2Req value)
        {
            value = new NetProtocol.Packet.C2G.DungeonLoadingCompleteV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.DungeonLoadingCompleteV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.InteractCancelReq value)
        {
            value = new NetProtocol.Packet.C2G.InteractCancelReq();
                
            if (!Read(msg, out value.TargetActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.InteractCancelReq value)
        {
            Write(msg, value.TargetActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.InteractEndReq value)
        {
            value = new NetProtocol.Packet.C2G.InteractEndReq();
                
            if (!Read(msg, out value.TargetActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.InteractEndReq value)
        {
            Write(msg, value.TargetActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.InteractStartReq value)
        {
            value = new NetProtocol.Packet.C2G.InteractStartReq();
                
            if (!Read(msg, out value.TargetActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.InteractStartReq value)
        {
            Write(msg, value.TargetActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.EquipmentVisibleV2Req value)
        {
            value = new NetProtocol.Packet.C2G.EquipmentVisibleV2Req();
                
            if (!Read(msg, out value.EquipSlot))
                return false;
            if (!Read(msg, out value.IsVisible))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.EquipmentVisibleV2Req value)
        {
            Write(msg, value.EquipSlot);
            Write(msg, value.IsVisible);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.InventoryChangeSizeV2Req value)
        {
            value = new NetProtocol.Packet.C2G.InventoryChangeSizeV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.InventoryChangeSizeV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemAddOptionV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ItemAddOptionV2Req();
                
            if (!Read(msg, out value.ItemId))
                return false;
            if (!Read(msg, out value.OptionStoneId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemAddOptionV2Req value)
        {
            Write(msg, value.ItemId);
            Write(msg, value.OptionStoneId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemChangeOptionV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ItemChangeOptionV2Req();
                
            if (!Read(msg, out value.ItemId))
                return false;
            if (!Read(msg, out value.OptionStoneId))
                return false;
            if (!Read(msg, out value.SlotIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemChangeOptionV2Req value)
        {
            Write(msg, value.ItemId);
            Write(msg, value.OptionStoneId);
            Write(msg, value.SlotIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemCollectionBookmarksRegisterV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ItemCollectionBookmarksRegisterV2Req();
                
            if (!Read(msg, out value.ItemCollectIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemCollectionBookmarksRegisterV2Req value)
        {
            Write(msg, value.ItemCollectIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemCollectionBookmarksUnregisterV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ItemCollectionBookmarksUnregisterV2Req();
                
            if (!Read(msg, out value.ItemCollectIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemCollectionBookmarksUnregisterV2Req value)
        {
            Write(msg, value.ItemCollectIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemCollectionRegisterV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ItemCollectionRegisterV2Req();
                
            if (!Read(msg, out value.ItemCollectIndex))
                return false;
            if (!Read(msg, out value.ItemId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemCollectionRegisterV2Req value)
        {
            Write(msg, value.ItemCollectIndex);
            Write(msg, value.ItemId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemCombineV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ItemCombineV2Req();
                
            if (!Read(msg, out value.ItemId))
                return false;
            if (!Read(msg, out value.ResourceItemIds))
                return false;
            if (!Read(msg, out value.CombineItemId))
                return false;
            if (!Read(msg, out value.PercentItemId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemCombineV2Req value)
        {
            Write(msg, value.ItemId);
            Write(msg, value.ResourceItemIds);
            Write(msg, value.CombineItemId);
            Write(msg, value.PercentItemId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemDeleteV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ItemDeleteV2Req();
                
            if (!Read(msg, out value.ItemId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemDeleteV2Req value)
        {
            Write(msg, value.ItemId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemDisassembleV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ItemDisassembleV2Req();
                
            if (!Read(msg, out value.ItemIds))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemDisassembleV2Req value)
        {
            Write(msg, value.ItemIds);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemEnchantV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ItemEnchantV2Req();
                
            if (!Read(msg, out value.ItemId))
                return false;
            if (!Read(msg, out value.EnchantCount))
                return false;
            if (!Read(msg, out value.EnchantStoneIndex))
                return false;
            if (!Read(msg, out value.PercentStoneIndex))
                return false;
            if (!Read(msg, out value.ProtectStoneIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemEnchantV2Req value)
        {
            Write(msg, value.ItemId);
            Write(msg, value.EnchantCount);
            Write(msg, value.EnchantStoneIndex);
            Write(msg, value.PercentStoneIndex);
            Write(msg, value.ProtectStoneIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemEquipV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ItemEquipV2Req();
                
            if (!Read(msg, out value.EquipSlot))
                return false;
            if (!Read(msg, out value.ItemId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemEquipV2Req value)
        {
            Write(msg, value.EquipSlot);
            Write(msg, value.ItemId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemInheritReq value)
        {
            value = new NetProtocol.Packet.C2G.ItemInheritReq();
                
            if (!Read(msg, out value.TargetItemId))
                return false;
            if (!Read(msg, out value.TargetStatList))
                return false;
            if (!Read(msg, out value.SubItemId))
                return false;
            if (!Read(msg, out value.SubStatList))
                return false;
            if (!Read(msg, out value.StoneItemId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemInheritReq value)
        {
            Write(msg, value.TargetItemId);
            Write(msg, value.TargetStatList);
            Write(msg, value.SubItemId);
            Write(msg, value.SubStatList);
            Write(msg, value.StoneItemId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemIntensionV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ItemIntensionV2Req();
                
            if (!Read(msg, out value.ItemId))
                return false;
            if (!Read(msg, out value.IntensionStoneIndex))
                return false;
            if (!Read(msg, out value.PercentStoneIndex))
                return false;
            if (!Read(msg, out value.ProtectStoneIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemIntensionV2Req value)
        {
            Write(msg, value.ItemId);
            Write(msg, value.IntensionStoneIndex);
            Write(msg, value.PercentStoneIndex);
            Write(msg, value.ProtectStoneIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemMarketPriceReq value)
        {
            value = new NetProtocol.Packet.C2G.ItemMarketPriceReq();
                
            if (!Read(msg, out value.ItemIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemMarketPriceReq value)
        {
            Write(msg, value.ItemIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemMixOptionV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ItemMixOptionV2Req();
                
            if (!Read(msg, out value.OptionStoneId1))
                return false;
            if (!Read(msg, out value.OptionStoneId2))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemMixOptionV2Req value)
        {
            Write(msg, value.OptionStoneId1);
            Write(msg, value.OptionStoneId2);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemPackageUseV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ItemPackageUseV2Req();
                
            if (!Read(msg, out value.ItemId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemPackageUseV2Req value)
        {
            Write(msg, value.ItemId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemProductionV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ItemProductionV2Req();
                
            if (!Read(msg, out value.ProductIndex))
                return false;
            if (!Read(msg, out value.Count))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemProductionV2Req value)
        {
            Write(msg, value.ProductIndex);
            Write(msg, value.Count);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemSelectUseV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ItemSelectUseV2Req();
                
            if (!Read(msg, out value.ItemId))
                return false;
            if (!Read(msg, out value.SelectIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemSelectUseV2Req value)
        {
            Write(msg, value.ItemId);
            Write(msg, value.SelectIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemSetLockReq value)
        {
            value = new NetProtocol.Packet.C2G.ItemSetLockReq();
                
            if (!Read(msg, out value.ItemId))
                return false;
            if (!Read(msg, out value.IsLocked))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemSetLockReq value)
        {
            Write(msg, value.ItemId);
            Write(msg, value.IsLocked);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemUpgradeV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ItemUpgradeV2Req();
                
            if (!Read(msg, out value.ItemId))
                return false;
            if (!Read(msg, out value.ResourceItemIds))
                return false;
            if (!Read(msg, out value.UpgradeItemId))
                return false;
            if (!Read(msg, out value.PercentItemId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemUpgradeV2Req value)
        {
            Write(msg, value.ItemId);
            Write(msg, value.ResourceItemIds);
            Write(msg, value.UpgradeItemId);
            Write(msg, value.PercentItemId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ItemUseV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ItemUseV2Req();
                
            if (!Read(msg, out value.ItemId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ItemUseV2Req value)
        {
            Write(msg, value.ItemId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PkLootingItemV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PkLootingItemV2Req();
                
            if (!Read(msg, out value.PkLootingIds))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PkLootingItemV2Req value)
        {
            Write(msg, value.PkLootingIds);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PkLootingListV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PkLootingListV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PkLootingListV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.WarehouseChangeSizeV2Req value)
        {
            value = new NetProtocol.Packet.C2G.WarehouseChangeSizeV2Req();
                
            if (!Read(msg, out value.Type))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.WarehouseChangeSizeV2Req value)
        {
            Write(msg, value.Type);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.WarehouseInfoV2Req value)
        {
            value = new NetProtocol.Packet.C2G.WarehouseInfoV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.WarehouseInfoV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.WarehouseItemMoveV2Req value)
        {
            value = new NetProtocol.Packet.C2G.WarehouseItemMoveV2Req();
                
            if (!Read(msg, out value.Type))
                return false;
            if (!Read(msg, out value.Flag))
                return false;
            if (!Read(msg, out value.Items))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.WarehouseItemMoveV2Req value)
        {
            Write(msg, value.Type);
            Write(msg, value.Flag);
            Write(msg, value.Items);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.MailListV2Req value)
        {
            value = new NetProtocol.Packet.C2G.MailListV2Req();
                
            if (!Read(msg, out value.Page))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.MailListV2Req value)
        {
            Write(msg, value.Page);
            Write(msg, value.Type);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.MailReadAllV2Req value)
        {
            value = new NetProtocol.Packet.C2G.MailReadAllV2Req();
                
            if (!Read(msg, out value.Type))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.MailReadAllV2Req value)
        {
            Write(msg, value.Type);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.MailReadV2Req value)
        {
            value = new NetProtocol.Packet.C2G.MailReadV2Req();
                
            if (!Read(msg, out value.MailId))
                return false;
            if (!Read(msg, out value.Type))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.MailReadV2Req value)
        {
            Write(msg, value.MailId);
            Write(msg, value.Type);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.MatchingApplyReq value)
        {
            value = new NetProtocol.Packet.C2G.MatchingApplyReq();
                
            if (!Read(msg, out value.DungeonIndices))
                return false;
            if (!Read(msg, out value.IsQuick))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.MatchingApplyReq value)
        {
            Write(msg, value.DungeonIndices);
            Write(msg, value.IsQuick);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.MatchingCancelReq value)
        {
            value = new NetProtocol.Packet.C2G.MatchingCancelReq();
                
            if (!Read(msg, out value.ZoneDataId))
                return false;
            if (!Read(msg, out value.MatchingId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.MatchingCancelReq value)
        {
            Write(msg, value.ZoneDataId);
            Write(msg, value.MatchingId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.MatchingReplyReq value)
        {
            value = new NetProtocol.Packet.C2G.MatchingReplyReq();
                
            if (!Read(msg, out value.MatchingId))
                return false;
            if (!Read(msg, out value.Reply))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.MatchingReplyReq value)
        {
            Write(msg, value.MatchingId);
            Write(msg, value.Reply);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.AuthenticatePlayerCredentialReq value)
        {
            value = new NetProtocol.Packet.C2G.AuthenticatePlayerCredentialReq();
                
            if (!Read(msg, out value.Token))
                return false;
            if (!Read(msg, out value.DeviceId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.AuthenticatePlayerCredentialReq value)
        {
            Write(msg, value.Token);
            Write(msg, value.DeviceId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.BossDamagedInfoReq value)
        {
            value = new NetProtocol.Packet.C2G.BossDamagedInfoReq();
                
            if (!Read(msg, out value.BossActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.BossDamagedInfoReq value)
        {
            Write(msg, value.BossActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.BroadCastContextReq value)
        {
            value = new NetProtocol.Packet.C2G.BroadCastContextReq();
                
            if (!Read(msg, out value.IncludeMe))
                return false;
            if (!Read(msg, out value.Contexts))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.BroadCastContextReq value)
        {
            Write(msg, value.IncludeMe);
            Write(msg, value.Contexts);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.CutSceneEndV2Req value)
        {
            value = new NetProtocol.Packet.C2G.CutSceneEndV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.CutSceneEndV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.CutSceneStartV2Req value)
        {
            value = new NetProtocol.Packet.C2G.CutSceneStartV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.CutSceneStartV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.LogOutReq value)
        {
            value = new NetProtocol.Packet.C2G.LogOutReq();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.LogOutReq value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PortalV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PortalV2Req();
                
            if (!Read(msg, out value.PortalIndex))
                return false;
            if (!Read(msg, out value.PortalType))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PortalV2Req value)
        {
            Write(msg, value.PortalIndex);
            Write(msg, value.PortalType);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ReturnToLobbyReq value)
        {
            value = new NetProtocol.Packet.C2G.ReturnToLobbyReq();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ReturnToLobbyReq value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ServerTimeV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ServerTimeV2Req();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ServerTimeV2Req value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TestPacketV2Req value)
        {
            value = new NetProtocol.Packet.C2G.TestPacketV2Req();
                
            if (!Read(msg, out value.IsEcho))
                return false;
            if (!Read(msg, out value.SendMessage))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TestPacketV2Req value)
        {
            Write(msg, value.IsEcho);
            Write(msg, value.SendMessage);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TriggerActivateV2Req value)
        {
            value = new NetProtocol.Packet.C2G.TriggerActivateV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.Index))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TriggerActivateV2Req value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.Index);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.UnionV2Req value)
        {
            value = new NetProtocol.Packet.C2G.UnionV2Req();
                
            if (!Read(msg, out value.Bytes))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.UnionV2Req value)
        {
            Write(msg, value.Bytes);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ZoneLoadingCompletedReq value)
        {
            value = new NetProtocol.Packet.C2G.ZoneLoadingCompletedReq();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ZoneLoadingCompletedReq value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PartyChangeLootingReq value)
        {
            value = new NetProtocol.Packet.C2G.PartyChangeLootingReq();
                
            if (!Read(msg, out value.LootingType))
                return false;
            if (!Read(msg, out value.LootingItemGrade))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PartyChangeLootingReq value)
        {
            Write(msg, value.LootingType);
            Write(msg, value.LootingItemGrade);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PartyCreateReq value)
        {
            value = new NetProtocol.Packet.C2G.PartyCreateReq();
                
            if (!Read(msg, out value.Looting))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PartyCreateReq value)
        {
            Write(msg, value.Looting);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PartyDisbandReq value)
        {
            value = new NetProtocol.Packet.C2G.PartyDisbandReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PartyDisbandReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PartyDungeonEntranceInquiryReq value)
        {
            value = new NetProtocol.Packet.C2G.PartyDungeonEntranceInquiryReq();
                
            if (!Read(msg, out value.DungeonIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PartyDungeonEntranceInquiryReq value)
        {
            Write(msg, value.DungeonIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PartyEnterDungeonCanceledReq value)
        {
            value = new NetProtocol.Packet.C2G.PartyEnterDungeonCanceledReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PartyEnterDungeonCanceledReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PartyEnterDungeonReplyReq value)
        {
            value = new NetProtocol.Packet.C2G.PartyEnterDungeonReplyReq();
                
            if (!Read(msg, out value.Reply))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PartyEnterDungeonReplyReq value)
        {
            Write(msg, value.Reply);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PartyEnterDungeonReq value)
        {
            value = new NetProtocol.Packet.C2G.PartyEnterDungeonReq();
                
            if (!Read(msg, out value.ZoneIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PartyEnterDungeonReq value)
        {
            Write(msg, value.ZoneIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PartyInfoReq value)
        {
            value = new NetProtocol.Packet.C2G.PartyInfoReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PartyInfoReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PartyInviteReplyReq value)
        {
            value = new NetProtocol.Packet.C2G.PartyInviteReplyReq();
                
            if (!Read(msg, out value.PartyId))
                return false;
            if (!Read(msg, out value.InviterActorId))
                return false;
            if (!Read(msg, out value.Reply))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PartyInviteReplyReq value)
        {
            Write(msg, value.PartyId);
            Write(msg, value.InviterActorId);
            Write(msg, value.Reply);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PartyInviteReq value)
        {
            value = new NetProtocol.Packet.C2G.PartyInviteReq();
                
            if (!Read(msg, out value.ActorId))
                return false;
            if (!Read(msg, out value.ActorName))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PartyInviteReq value)
        {
            Write(msg, value.ActorId);
            Write(msg, value.ActorName);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PartyLeaderChangeReq value)
        {
            value = new NetProtocol.Packet.C2G.PartyLeaderChangeReq();
                
            if (!Read(msg, out value.ActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PartyLeaderChangeReq value)
        {
            Write(msg, value.ActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PartyLeaveReq value)
        {
            value = new NetProtocol.Packet.C2G.PartyLeaveReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PartyLeaveReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PartyMemberKickReq value)
        {
            value = new NetProtocol.Packet.C2G.PartyMemberKickReq();
                
            if (!Read(msg, out value.ActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PartyMemberKickReq value)
        {
            Write(msg, value.ActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PartySuggestionPlayersReq value)
        {
            value = new NetProtocol.Packet.C2G.PartySuggestionPlayersReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PartySuggestionPlayersReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PetCollectInfoV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PetCollectInfoV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PetCollectInfoV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PetEquipOffV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PetEquipOffV2Req();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PetEquipOffV2Req value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PetEquipV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PetEquipV2Req();
                
            if (!Read(msg, out value.PetIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PetEquipV2Req value)
        {
            Write(msg, value.PetIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PetFeedUseV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PetFeedUseV2Req();
                
            if (!Read(msg, out value.PetIndex))
                return false;
            if (!Read(msg, out value.ItemId))
                return false;
            if (!Read(msg, out value.ItemCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PetFeedUseV2Req value)
        {
            Write(msg, value.PetIndex);
            Write(msg, value.ItemId);
            Write(msg, value.ItemCount);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PetGachaV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PetGachaV2Req();
                
            if (!Read(msg, out value.ItemId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PetGachaV2Req value)
        {
            Write(msg, value.ItemId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PetInActiveBuffReq value)
        {
            value = new NetProtocol.Packet.C2G.PetInActiveBuffReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PetInActiveBuffReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PetInfoV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PetInfoV2Req();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PetInfoV2Req value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PetMixV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PetMixV2Req();
                
            if (!Read(msg, out value.Mixes))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PetMixV2Req value)
        {
            Write(msg, value.Mixes);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PetUpgradeV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PetUpgradeV2Req();
                
            if (!Read(msg, out value.PetIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PetUpgradeV2Req value)
        {
            Write(msg, value.PetIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PhaseFieldEndV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PhaseFieldEndV2Req();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.ConditionQuestIndex))
                return false;
            if (!Read(msg, out value.State))
                return false;
            if (!Read(msg, out value.EndPos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PhaseFieldEndV2Req value)
        {
            Write(msg, value.Index);
            Write(msg, value.ConditionQuestIndex);
            Write(msg, value.State);
            Write(msg, value.EndPos);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PhaseFieldStartV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PhaseFieldStartV2Req();
                
            if (!Read(msg, out value.Index))
                return false;
            if (!Read(msg, out value.ConditionQuestIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PhaseFieldStartV2Req value)
        {
            Write(msg, value.Index);
            Write(msg, value.ConditionQuestIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.AuthenticateBotCredentialReq value)
        {
            value = new NetProtocol.Packet.C2G.AuthenticateBotCredentialReq();
                
            if (!Read(msg, out value.Token))
                return false;
            if (!Read(msg, out value.DeviceId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.AuthenticateBotCredentialReq value)
        {
            Write(msg, value.Token);
            Write(msg, value.DeviceId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerEnterStageFifthReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerEnterStageFifthReq();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerEnterStageFifthReq value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerEnterStageFirstReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerEnterStageFirstReq();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerEnterStageFirstReq value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerEnterStageFourthReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerEnterStageFourthReq();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerEnterStageFourthReq value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerEnterStageSecondReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerEnterStageSecondReq();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerEnterStageSecondReq value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerEnterStageThirdReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerEnterStageThirdReq();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerEnterStageThirdReq value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerGameEnterReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerGameEnterReq();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerGameEnterReq value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerSelectReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerSelectReq();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerSelectReq value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerClassUpV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PlayerClassUpV2Req();
                
            if (!Read(msg, out value.ClassType))
                return false;
            if (!Read(msg, out value.ItemId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerClassUpV2Req value)
        {
            Write(msg, value.ClassType);
            Write(msg, value.ItemId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerDeathInfoReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerDeathInfoReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerDeathInfoReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerDeleteReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerDeleteReq();
                
            if (!Read(msg, out value.AccountId))
                return false;
            if (!Read(msg, out value.AccountSlot))
                return false;
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerDeleteReq value)
        {
            Write(msg, value.AccountId);
            Write(msg, value.AccountSlot);
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerExpRecoveryPopupReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerExpRecoveryPopupReq();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerExpRecoveryPopupReq value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerGetMacroReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerGetMacroReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerGetMacroReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerMapMoveV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PlayerMapMoveV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            if (!Read(msg, out value.ZoneDataId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerMapMoveV2Req value)
        {
            Write(msg, value.PlayerId);
            Write(msg, value.ZoneDataId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerMoveV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PlayerMoveV2Req();
                
            if (!Read(msg, out value.CurrentPos))
                return false;
            if (!Read(msg, out value.Dir))
                return false;
            if (!Read(msg, out value.MoveState))
                return false;
            if (!Read(msg, out value.PerformTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerMoveV2Req value)
        {
            Write(msg, value.CurrentPos);
            Write(msg, value.Dir);
            Write(msg, value.MoveState);
            Write(msg, value.PerformTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.RTTPlayerMoveV2Req value)
        {
            value = new NetProtocol.Packet.C2G.RTTPlayerMoveV2Req();
                
            if (!Read(msg, out value.CurrentPos))
                return false;
            if (!Read(msg, out value.Dir))
                return false;
            if (!Read(msg, out value.MoveState))
                return false;
            if (!Read(msg, out value.PerformTime))
                return false;
            if (!Read(msg, out value.UtcSendTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.RTTPlayerMoveV2Req value)
        {
            Write(msg, value.CurrentPos);
            Write(msg, value.Dir);
            Write(msg, value.MoveState);
            Write(msg, value.PerformTime);
            Write(msg, value.UtcSendTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerMoveZoneV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PlayerMoveZoneV2Req();
                
            if (!Read(msg, out value.ZoneDataId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerMoveZoneV2Req value)
        {
            Write(msg, value.ZoneDataId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerResurrectionV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PlayerResurrectionV2Req();
                
            if (!Read(msg, out value.ResurrectionType))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerResurrectionV2Req value)
        {
            Write(msg, value.ResurrectionType);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerSetMacroReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerSetMacroReq();
                
            if (!Read(msg, out value.Macros))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerSetMacroReq value)
        {
            Write(msg, value.Macros);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerSlotChangeV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PlayerSlotChangeV2Req();
                
            if (!Read(msg, out value.SkillId))
                return false;
            if (!Read(msg, out value.TargetInfo))
                return false;
            if (!Read(msg, out value.Time))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerSlotChangeV2Req value)
        {
            Write(msg, value.SkillId);
            Write(msg, value.TargetInfo);
            Write(msg, value.Time);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerStatPointChangeV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PlayerStatPointChangeV2Req();
                
            if (!Read(msg, out value.Stats))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerStatPointChangeV2Req value)
        {
            Write(msg, value.Stats);
        }
        public static bool Read(Message msg, out System.ValueTuple<System.Int32, System.Int32> value)
        {
            value = new(default(System.Int32), default(System.Int32));
            if (!Read(msg, out value.Item1))
                return false;
            if (!Read(msg, out value.Item2))
                return false;
            return true;
        }
        public static void Write(Message msg, System.ValueTuple<System.Int32, System.Int32> value)
        {
            Write(msg, value.Item1);
            Write(msg, value.Item2);
        }
        public static bool Read(Message msg, out System.ValueTuple<System.Int32, System.Int32>[] value)
        {
            int count = 0;
            Read(msg, out count);

            value = new System.ValueTuple<System.Int32, System.Int32>[count];

            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out System.ValueTuple<System.Int32, System.Int32> val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, System.ValueTuple<System.Int32, System.Int32>[] value)
        {
            Write(msg, value.Length);
            for (int i = 0; i < value.Length; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerStatPointInitV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PlayerStatPointInitV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerStatPointInitV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerStatV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PlayerStatV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerStatV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.QuickslotSetReq value)
        {
            value = new NetProtocol.Packet.C2G.QuickslotSetReq();
                
            if (!Read(msg, out value.QuickslotInfo))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.QuickslotSetReq value)
        {
            Write(msg, value.QuickslotInfo);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.RecoverPlayerExpReq value)
        {
            value = new NetProtocol.Packet.C2G.RecoverPlayerExpReq();
                
            if (!Read(msg, out value.UniqueId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.RecoverPlayerExpReq value)
        {
            Write(msg, value.UniqueId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.QuestAbandonV2Req value)
        {
            value = new NetProtocol.Packet.C2G.QuestAbandonV2Req();
                
            if (!Read(msg, out value.QuestId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.QuestAbandonV2Req value)
        {
            Write(msg, value.QuestId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.QuestAcceptV2Req value)
        {
            value = new NetProtocol.Packet.C2G.QuestAcceptV2Req();
                
            if (!Read(msg, out value.QuestId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.QuestAcceptV2Req value)
        {
            Write(msg, value.QuestId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.QuestCompleteV2Req value)
        {
            value = new NetProtocol.Packet.C2G.QuestCompleteV2Req();
                
            if (!Read(msg, out value.QuestId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.QuestCompleteV2Req value)
        {
            Write(msg, value.QuestId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.QuestConditionCompleteV2Req value)
        {
            value = new NetProtocol.Packet.C2G.QuestConditionCompleteV2Req();
                
            if (!Read(msg, out value.DataId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.QuestConditionCompleteV2Req value)
        {
            Write(msg, value.DataId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.QuestListV2Req value)
        {
            value = new NetProtocol.Packet.C2G.QuestListV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.QuestListV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.QuestPortalV2Req value)
        {
            value = new NetProtocol.Packet.C2G.QuestPortalV2Req();
                
            if (!Read(msg, out value.DetailId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.QuestPortalV2Req value)
        {
            Write(msg, value.DetailId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.QuestRegisterV2Req value)
        {
            value = new NetProtocol.Packet.C2G.QuestRegisterV2Req();
                
            if (!Read(msg, out value.DataId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.QuestRegisterV2Req value)
        {
            Write(msg, value.DataId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.QuestRerollV2Req value)
        {
            value = new NetProtocol.Packet.C2G.QuestRerollV2Req();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.QuestRerollV2Req value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.QuestRewardV2Req value)
        {
            value = new NetProtocol.Packet.C2G.QuestRewardV2Req();
                
            if (!Read(msg, out value.QuestId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.QuestRewardV2Req value)
        {
            Write(msg, value.QuestId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.QuestTalkCompleteV2Req value)
        {
            value = new NetProtocol.Packet.C2G.QuestTalkCompleteV2Req();
                
            if (!Read(msg, out value.QuestId))
                return false;
            if (!Read(msg, out value.NpcId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.QuestTalkCompleteV2Req value)
        {
            Write(msg, value.QuestId);
            Write(msg, value.NpcId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TutorialSkipV2Req value)
        {
            value = new NetProtocol.Packet.C2G.TutorialSkipV2Req();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TutorialSkipV2Req value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GuildRelationReq value)
        {
            value = new NetProtocol.Packet.C2G.GuildRelationReq();
                
            if (!Read(msg, out value.GuildName))
                return false;
            if (!Read(msg, out value.Info))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GuildRelationReq value)
        {
            Write(msg, value.GuildName);
            Write(msg, value.Info);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerRelationReq value)
        {
            value = new NetProtocol.Packet.C2G.PlayerRelationReq();
                
            if (!Read(msg, out value.Info))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerRelationReq value)
        {
            Write(msg, value.Info);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.RideAttachDeleteV2Req value)
        {
            value = new NetProtocol.Packet.C2G.RideAttachDeleteV2Req();
                
            if (!Read(msg, out value.AttachIDs))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.RideAttachDeleteV2Req value)
        {
            Write(msg, value.AttachIDs);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.RideAttachDisassembleV2Req value)
        {
            value = new NetProtocol.Packet.C2G.RideAttachDisassembleV2Req();
                
            if (!Read(msg, out value.AttachIDs))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.RideAttachDisassembleV2Req value)
        {
            Write(msg, value.AttachIDs);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.RideAttachEquipOffV2Req value)
        {
            value = new NetProtocol.Packet.C2G.RideAttachEquipOffV2Req();
                
            if (!Read(msg, out value.RideIndex))
                return false;
            if (!Read(msg, out value.AttachPart))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.RideAttachEquipOffV2Req value)
        {
            Write(msg, value.RideIndex);
            Write(msg, value.AttachPart);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.RideAttachEquipV2Req value)
        {
            value = new NetProtocol.Packet.C2G.RideAttachEquipV2Req();
                
            if (!Read(msg, out value.RideIndex))
                return false;
            if (!Read(msg, out value.AttachID))
                return false;
            if (!Read(msg, out value.AttachPart))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.RideAttachEquipV2Req value)
        {
            Write(msg, value.RideIndex);
            Write(msg, value.AttachID);
            Write(msg, value.AttachPart);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.RideAttachGachaV2Req value)
        {
            value = new NetProtocol.Packet.C2G.RideAttachGachaV2Req();
                
            if (!Read(msg, out value.ItemId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.RideAttachGachaV2Req value)
        {
            Write(msg, value.ItemId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.RideAttachInvenExtendV2Req value)
        {
            value = new NetProtocol.Packet.C2G.RideAttachInvenExtendV2Req();
                
            if (!Read(msg, out value.ItemIndex))
                return false;
            if (!Read(msg, out value.ItemCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.RideAttachInvenExtendV2Req value)
        {
            Write(msg, value.ItemIndex);
            Write(msg, value.ItemCount);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.RideEquipOffV2Req value)
        {
            value = new NetProtocol.Packet.C2G.RideEquipOffV2Req();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.RideEquipOffV2Req value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.RideEquipV2Req value)
        {
            value = new NetProtocol.Packet.C2G.RideEquipV2Req();
                
            if (!Read(msg, out value.RideIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.RideEquipV2Req value)
        {
            Write(msg, value.RideIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.RideGachaV2Req value)
        {
            value = new NetProtocol.Packet.C2G.RideGachaV2Req();
                
            if (!Read(msg, out value.ItemId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.RideGachaV2Req value)
        {
            Write(msg, value.ItemId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.RideMixV2Req value)
        {
            value = new NetProtocol.Packet.C2G.RideMixV2Req();
                
            if (!Read(msg, out value.Mixes))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.RideMixV2Req value)
        {
            Write(msg, value.Mixes);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.RideSitOffV2Req value)
        {
            value = new NetProtocol.Packet.C2G.RideSitOffV2Req();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.RideSitOffV2Req value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.RideSitV2Req value)
        {
            value = new NetProtocol.Packet.C2G.RideSitV2Req();
                
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.RideSitV2Req value)
        {
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.BuyCashShopItemV2Req value)
        {
            value = new NetProtocol.Packet.C2G.BuyCashShopItemV2Req();
                
            if (!Read(msg, out value.CashShopIndex))
                return false;
            if (!Read(msg, out value.BuyCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.BuyCashShopItemV2Req value)
        {
            Write(msg, value.CashShopIndex);
            Write(msg, value.BuyCount);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.BuyGameShopItemV2Req value)
        {
            value = new NetProtocol.Packet.C2G.BuyGameShopItemV2Req();
                
            if (!Read(msg, out value.GameShopIndex))
                return false;
            if (!Read(msg, out value.BuyCount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.BuyGameShopItemV2Req value)
        {
            Write(msg, value.GameShopIndex);
            Write(msg, value.BuyCount);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GameShopSellItemV2Req value)
        {
            value = new NetProtocol.Packet.C2G.GameShopSellItemV2Req();
                
            if (!Read(msg, out value.SellItemInfos))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GameShopSellItemV2Req value)
        {
            Write(msg, value.SellItemInfos);
        }
        public static bool Read(Message msg, out System.ValueTuple<System.Int64, System.UInt32> value)
        {
            value = new(default(System.Int64), default(System.UInt32));
            if (!Read(msg, out value.Item1))
                return false;
            if (!Read(msg, out value.Item2))
                return false;
            return true;
        }
        public static void Write(Message msg, System.ValueTuple<System.Int64, System.UInt32> value)
        {
            Write(msg, value.Item1);
            Write(msg, value.Item2);
        }
        public static bool Read(Message msg, out System.ValueTuple<System.Int64, System.UInt32>[] value)
        {
            int count = 0;
            Read(msg, out count);

            value = new System.ValueTuple<System.Int64, System.UInt32>[count];

            for (int i = 0; i < count; ++i)
            {
                if(!Read(msg,  out System.ValueTuple<System.Int64, System.UInt32> val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, System.ValueTuple<System.Int64, System.UInt32>[] value)
        {
            Write(msg, value.Length);
            for (int i = 0; i < value.Length; ++i)
                Write(msg, value[i]);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ChangeSiegeModeV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ChangeSiegeModeV2Req();
                
            if (!Read(msg, out value.State))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ChangeSiegeModeV2Req value)
        {
            Write(msg, value.State);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ChoiceSiegeWarFactionV2Req value)
        {
            value = new NetProtocol.Packet.C2G.ChoiceSiegeWarFactionV2Req();
                
            if (!Read(msg, out value.MatchIndex))
                return false;
            if (!Read(msg, out value.ChoiceFaction))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ChoiceSiegeWarFactionV2Req value)
        {
            Write(msg, value.MatchIndex);
            Write(msg, value.ChoiceFaction);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GetSiegeWarInfoV2Req value)
        {
            value = new NetProtocol.Packet.C2G.GetSiegeWarInfoV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GetSiegeWarInfoV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.GetSiegeWarMatchInfoV2Req value)
        {
            value = new NetProtocol.Packet.C2G.GetSiegeWarMatchInfoV2Req();
                
            if (!Read(msg, out value.MatchIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.GetSiegeWarMatchInfoV2Req value)
        {
            Write(msg, value.MatchIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.BuffListInfoV2Req value)
        {
            value = new NetProtocol.Packet.C2G.BuffListInfoV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.BuffListInfoV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.SkillChangeAutoUseV2Req value)
        {
            value = new NetProtocol.Packet.C2G.SkillChangeAutoUseV2Req();
                
            if (!Read(msg, out value.SkillSerial))
                return false;
            if (!Read(msg, out value.IsAutoUse))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.SkillChangeAutoUseV2Req value)
        {
            Write(msg, value.SkillSerial);
            Write(msg, value.IsAutoUse);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.SkillChangePresetV2Req value)
        {
            value = new NetProtocol.Packet.C2G.SkillChangePresetV2Req();
                
            if (!Read(msg, out value.PresetNumber))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.SkillChangePresetV2Req value)
        {
            Write(msg, value.PresetNumber);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.SkillEquipV2Req value)
        {
            value = new NetProtocol.Packet.C2G.SkillEquipV2Req();
                
            if (!Read(msg, out value.PresetNumber))
                return false;
            if (!Read(msg, out value.SlotNumber))
                return false;
            if (!Read(msg, out value.SkillSerial))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.SkillEquipV2Req value)
        {
            Write(msg, value.PresetNumber);
            Write(msg, value.SlotNumber);
            Write(msg, value.SkillSerial);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.SkillHitV2Req value)
        {
            value = new NetProtocol.Packet.C2G.SkillHitV2Req();
                
            if (!Read(msg, out value.SkillSerial))
                return false;
            if (!Read(msg, out value.HitId))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.SkillHitV2Req value)
        {
            Write(msg, value.SkillSerial);
            Write(msg, value.HitId);
            Write(msg, value.TargetActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.RTTSkillHitV2Req value)
        {
            value = new NetProtocol.Packet.C2G.RTTSkillHitV2Req();
                
            if (!Read(msg, out value.SkillSerial))
                return false;
            if (!Read(msg, out value.HitId))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            if (!Read(msg, out value.UtcSendTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.RTTSkillHitV2Req value)
        {
            Write(msg, value.SkillSerial);
            Write(msg, value.HitId);
            Write(msg, value.TargetActorId);
            Write(msg, value.UtcSendTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.SkillLearnV2Req value)
        {
            value = new NetProtocol.Packet.C2G.SkillLearnV2Req();
                
            if (!Read(msg, out value.SkillSerial))
                return false;
            if (!Read(msg, out value.ItemId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.SkillLearnV2Req value)
        {
            Write(msg, value.SkillSerial);
            Write(msg, value.ItemId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.SkillLevelUpV2Req value)
        {
            value = new NetProtocol.Packet.C2G.SkillLevelUpV2Req();
                
            if (!Read(msg, out value.SkillSerial))
                return false;
            if (!Read(msg, out value.ItemId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.SkillLevelUpV2Req value)
        {
            Write(msg, value.SkillSerial);
            Write(msg, value.ItemId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.SkillListInfoV2Req value)
        {
            value = new NetProtocol.Packet.C2G.SkillListInfoV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.SkillListInfoV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.SkillUnEquipV2Req value)
        {
            value = new NetProtocol.Packet.C2G.SkillUnEquipV2Req();
                
            if (!Read(msg, out value.PresetNumber))
                return false;
            if (!Read(msg, out value.SlotNumber))
                return false;
            if (!Read(msg, out value.IsAll))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.SkillUnEquipV2Req value)
        {
            Write(msg, value.PresetNumber);
            Write(msg, value.SlotNumber);
            Write(msg, value.IsAll);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.SkillUpgradeV2Req value)
        {
            value = new NetProtocol.Packet.C2G.SkillUpgradeV2Req();
                
            if (!Read(msg, out value.SkillSerial))
                return false;
            if (!Read(msg, out value.ItemId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.SkillUpgradeV2Req value)
        {
            Write(msg, value.SkillSerial);
            Write(msg, value.ItemId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.SkillUseV2Req value)
        {
            value = new NetProtocol.Packet.C2G.SkillUseV2Req();
                
            if (!Read(msg, out value.SkillSerial))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.SkillUseV2Req value)
        {
            Write(msg, value.SkillSerial);
            Write(msg, value.TargetActorId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.RTTSkillUseV2Req value)
        {
            value = new NetProtocol.Packet.C2G.RTTSkillUseV2Req();
                
            if (!Read(msg, out value.SkillSerial))
                return false;
            if (!Read(msg, out value.TargetActorId))
                return false;
            if (!Read(msg, out value.UtcSendTime))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.RTTSkillUseV2Req value)
        {
            Write(msg, value.SkillSerial);
            Write(msg, value.TargetActorId);
            Write(msg, value.UtcSendTime);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.PlayerTitleChangeV2Req value)
        {
            value = new NetProtocol.Packet.C2G.PlayerTitleChangeV2Req();
                
            if (!Read(msg, out value.SkillId))
                return false;
            if (!Read(msg, out value.TargetInfo))
                return false;
            if (!Read(msg, out value.Time))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.PlayerTitleChangeV2Req value)
        {
            Write(msg, value.SkillId);
            Write(msg, value.TargetInfo);
            Write(msg, value.Time);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TitleChangeV2Req value)
        {
            value = new NetProtocol.Packet.C2G.TitleChangeV2Req();
                
            if (!Read(msg, out value.TitleIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TitleChangeV2Req value)
        {
            Write(msg, value.TitleIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TitleListV2Req value)
        {
            value = new NetProtocol.Packet.C2G.TitleListV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TitleListV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeCronAverageBalanceReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeCronAverageBalanceReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeCronAverageBalanceReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeCronBalanceReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeCronBalanceReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeCronBalanceReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeCronBuyReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeCronBuyReq();
                
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeCronBuyReq value)
        {
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeCronCancelReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeCronCancelReq();
                
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeCronCancelReq value)
        {
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeCronInfoReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeCronInfoReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeCronInfoReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeCronListReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeCronListReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeCronListReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeCronMyListReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeCronMyListReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeCronMyListReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeCronPreviousDayBalanceReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeCronPreviousDayBalanceReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeCronPreviousDayBalanceReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeCronReclaimExpiredReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeCronReclaimExpiredReq();
                
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeCronReclaimExpiredReq value)
        {
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeCronRemainingCanceledPenaltyTimeReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeCronRemainingCanceledPenaltyTimeReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeCronRemainingCanceledPenaltyTimeReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeCronSellReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeCronSellReq();
                
            if (!Read(msg, out value.Amount))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeCronSellReq value)
        {
            Write(msg, value.Amount);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeCronSettleReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeCronSettleReq();
                
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeCronSettleReq value)
        {
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeCronTimeToNextChangeBalanceReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeCronTimeToNextChangeBalanceReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeCronTimeToNextChangeBalanceReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeCronTradesReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeCronTradesReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeCronTradesReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeCronWeeklyBalanceReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeCronWeeklyBalanceReq();
                
            if (!Read(msg, out value.Empty))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeCronWeeklyBalanceReq value)
        {
            Write(msg, value.Empty);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeItemBookmarkAddReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeItemBookmarkAddReq();
                
            if (!Read(msg, out value.ItemIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeItemBookmarkAddReq value)
        {
            Write(msg, value.ItemIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeItemBookmarkDeleteReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeItemBookmarkDeleteReq();
                
            if (!Read(msg, out value.ItemIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeItemBookmarkDeleteReq value)
        {
            Write(msg, value.ItemIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeItemBuyReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeItemBuyReq();
                
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeItemBuyReq value)
        {
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeItemCancelReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeItemCancelReq();
                
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeItemCancelReq value)
        {
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeItemFinishReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeItemFinishReq();
                
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeItemFinishReq value)
        {
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeItemHistoryReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeItemHistoryReq();
                
            if (!Read(msg, out value.AccountId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeItemHistoryReq value)
        {
            Write(msg, value.AccountId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeItemRegistReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeItemRegistReq();
                
            if (!Read(msg, out value.ItemId))
                return false;
            if (!Read(msg, out value.Count))
                return false;
            if (!Read(msg, out value.Price))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeItemRegistReq value)
        {
            Write(msg, value.ItemId);
            Write(msg, value.Count);
            Write(msg, value.Price);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeItemSearchCategoryReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeItemSearchCategoryReq();
                
            if (!Read(msg, out value.MainCategory))
                return false;
            if (!Read(msg, out value.SubCategory))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeItemSearchCategoryReq value)
        {
            Write(msg, value.MainCategory);
            Write(msg, value.SubCategory);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeItemSearchItemIndexReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeItemSearchItemIndexReq();
                
            if (!Read(msg, out value.ItemIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeItemSearchItemIndexReq value)
        {
            Write(msg, value.ItemIndex);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradeItemWithdrawReq value)
        {
            value = new NetProtocol.Packet.C2G.TradeItemWithdrawReq();
                
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradeItemWithdrawReq value)
        {
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradePersonalAcceptReq value)
        {
            value = new NetProtocol.Packet.C2G.TradePersonalAcceptReq();
                
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradePersonalAcceptReq value)
        {
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradePersonalCancelReq value)
        {
            value = new NetProtocol.Packet.C2G.TradePersonalCancelReq();
                
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradePersonalCancelReq value)
        {
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradePersonalFinishReq value)
        {
            value = new NetProtocol.Packet.C2G.TradePersonalFinishReq();
                
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradePersonalFinishReq value)
        {
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradePersonalHistoryReq value)
        {
            value = new NetProtocol.Packet.C2G.TradePersonalHistoryReq();
                
            if (!Read(msg, out value.AccountId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradePersonalHistoryReq value)
        {
            Write(msg, value.AccountId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradePersonalRefuseReq value)
        {
            value = new NetProtocol.Packet.C2G.TradePersonalRefuseReq();
                
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradePersonalRefuseReq value)
        {
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradePersonalRequestReq value)
        {
            value = new NetProtocol.Packet.C2G.TradePersonalRequestReq();
                
            if (!Read(msg, out value.Target))
                return false;
            if (!Read(msg, out value.ItemId))
                return false;
            if (!Read(msg, out value.Count))
                return false;
            if (!Read(msg, out value.Price))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradePersonalRequestReq value)
        {
            Write(msg, value.Target);
            Write(msg, value.ItemId);
            Write(msg, value.Count);
            Write(msg, value.Price);
        }
        public static bool Read(Message msg, out NetProtocol.Models.Account.AccountSummary value)
        {
            value = new NetProtocol.Models.Account.AccountSummary();
                
            if (!Read(msg, out value.Id))
                return false;
            if (!Read(msg, out value.Name))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Models.Account.AccountSummary value)
        {
            Write(msg, value.Id);
            Write(msg, value.Name);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.TradePersonalWithdrawReq value)
        {
            value = new NetProtocol.Packet.C2G.TradePersonalWithdrawReq();
                
            if (!Read(msg, out value.TradeId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.TradePersonalWithdrawReq value)
        {
            Write(msg, value.TradeId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.WeaponAppearanceCollectListV2Req value)
        {
            value = new NetProtocol.Packet.C2G.WeaponAppearanceCollectListV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.WeaponAppearanceCollectListV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.WeaponAppearanceEquipV2Req value)
        {
            value = new NetProtocol.Packet.C2G.WeaponAppearanceEquipV2Req();
                
            if (!Read(msg, out value.ItemDataId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.WeaponAppearanceEquipV2Req value)
        {
            Write(msg, value.ItemDataId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.WeaponAppearanceExtractFromItemV2Req value)
        {
            value = new NetProtocol.Packet.C2G.WeaponAppearanceExtractFromItemV2Req();
                
            if (!Read(msg, out value.ItemIds))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.WeaponAppearanceExtractFromItemV2Req value)
        {
            Write(msg, value.ItemIds);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.WeaponAppearanceHiddenV2Req value)
        {
            value = new NetProtocol.Packet.C2G.WeaponAppearanceHiddenV2Req();
                
            if (!Read(msg, out value.ItemDataId))
                return false;
            if (!Read(msg, out value.IsHidden))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.WeaponAppearanceHiddenV2Req value)
        {
            Write(msg, value.ItemDataId);
            Write(msg, value.IsHidden);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.WeaponAppearanceListV2Req value)
        {
            value = new NetProtocol.Packet.C2G.WeaponAppearanceListV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.WeaponAppearanceListV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.WeaponAppearanceUnequipV2Req value)
        {
            value = new NetProtocol.Packet.C2G.WeaponAppearanceUnequipV2Req();
                
            if (!Read(msg, out value.PlayerId))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.WeaponAppearanceUnequipV2Req value)
        {
            Write(msg, value.PlayerId);
        }
        public static bool Read(Message msg, out NetProtocol.Packet.C2G.ZoneStatusReq value)
        {
            value = new NetProtocol.Packet.C2G.ZoneStatusReq();
                
            if (!Read(msg, out value.ZoneIndex))
                return false;
            return true;
        }
        public static void Write(Message msg, NetProtocol.Packet.C2G.ZoneStatusReq value)
        {
            Write(msg, value.ZoneIndex);
        }
    }
}
#pragma warning restore CS0108
