using NetProtocol.Packet;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace NetProtocol
{
    public class StatCalculator
    {
        public const int BUFF_RATE_DIVISION = 10000;
        public static ulong[] Stat2ndMaxValues { get; protected set; } = null; // 2nd stat max values
        public static Dictionary<byte, (Stat2ndOrder order, ulong[] stats)[]> CharClassStatus { get; protected set; } = null; // key: class, value: (Stat2ndOrder, 1st varable stats)[]
        public static Dictionary<byte, (ulong[], (StatIndex, ulong)[])> CharCreateStats { get; protected set; } = null; // key: tribe, value: (tribe base 1st stat array, tribe base 2nd stat array)
        public static (ulong, ulong, ulong, ulong)[] WantedEvents { get; protected set; } = null; // wanted panalty array

        public static HashSet<ushort> CharStatusByValue { get; set; } = null;  // 정수형 스탯 인덱스
        private static Dictionary<StatIndex, Stat2ndOrder> StatIndexTo2ndOrder = null;
        private static Dictionary<Stat2ndOrder, StatIndex> Stat2ndOrderToIndex = null;
        private static Dictionary<StatIndex, Stat1stOrder> StatIndexTo1stOrder = null;
        private static Dictionary<Stat1stOrder, StatIndex> Stat1stOrderToIndex = null;

        public static bool IsRate(ushort index)
        {
            return !CharStatusByValue.Contains(index);
        }

        public static bool IsRate(Stat2ndOrder order)
        {
            var index = ToStatIndex(order);
            return !CharStatusByValue.Contains((ushort)index);
        }

        public static bool Is1stStat(uint index)
        {
            return index < 20000;
        }

        #region >>> PlayerActors
        // 캐릭터 기본 스탯 얻기
        public static ulong[] GetCharCreateStat1st(byte tribe) => CharCreateStats.TryGetValue(tribe, out var stat) ? stat.Item1 : Array.Empty<ulong>();
        public static (StatIndex, ulong)[] GetCharCreateStat2nd(byte tribe) => CharCreateStats.TryGetValue(tribe, out var stat) ? stat.Item2 : Array.Empty<(StatIndex, ulong)>();

        // 1차 스탯부터 최종 스탯 일괄 계산
        public static ErrorCode CalcPlayerStatAll(byte classType, Stat1st stat1st, PlayerStat2nd stat2nd)
        {
            if (CharClassStatus == null)
                return ErrorCode.TableEmpty;

            if (!CharClassStatus.TryGetValue(classType, out var classStatus))
                return ErrorCode.TableInvalid;

            stat1st.CalcFinal();

            Array.Fill<ulong>(stat2nd.Var, 0);

            foreach (var status in classStatus)
            {
                var order = (int)status.Item1;

                for (int i = 0; i < (int)Stat1stOrder.End; ++i)
                {
                    if (status.Item2[i] != 0)
                        stat2nd.Var[order] += (ulong)(stat1st.Final[i] * (float)(status.Item2[i]));
                }
            }

            stat2nd.CalcFinal(Stat2ndMaxValues);

            return ErrorCode.Success;
        }

        // 2차 스탯만 재계산(전체)
        public static void CalcPlayerStat2ndFinal(PlayerStat2nd stat2nd)
        {
            stat2nd.CalcFinal(Stat2ndMaxValues);
        }
        // 2차 스탯만 재계산(일부)
        public static void CalcPlayerStat2ndFinal(PlayerStat2nd stat2nd, int order)
        {
            stat2nd.CalcFinal(order, Stat2ndMaxValues[order]);
        }
        public static void CalcPlayerStat2ndFinal(PlayerStat2nd stat2nd, Stat2ndOrder order)
        {
            CalcPlayerStat2ndFinal(stat2nd, (int)order);
        }

        // 플레이어 스탯을 초기값으로 설정
        public static ErrorCode InitPlayerStat(byte tribe, Stat1st stat1st, PlayerStat2nd stat2nd, bool isCreate = false)
        {
            if (!CharCreateStats.TryGetValue(tribe, out var createStat))
                return ErrorCode.TableInvalid;

            if (isCreate)
            {
                for (int i = 0; i < (int)Stat1stOrder.End; ++i)
                {                    
                    stat1st.Origin[i] = createStat.Item1[i] / 1_000_000;
                }
            }

            foreach (var stat in createStat.Item2)
            {
                var order = StatIndexTo2ndOrder[stat.Item1];
                stat2nd.Base[(int)order] = stat.Item2;
            }

            return ErrorCode.Success;
        }

        // 플레이어의 1차 스탯 변경
        public static void AddPlayerStatOriginByIndex(Stat1st stat1st, uint index, ushort value)
        {
            var order = StatIndexTo1stOrder[(StatIndex)index];
            AddStatValue(ref stat1st.Origin[(int)order], value);
        }
        public static void SubPlayerStatOriginByIndex(Stat1st stat1st, uint index, ushort value)
        {
            var order = StatIndexTo1stOrder[(StatIndex)index];
            SubStatValue(ref stat1st.Origin[(int)order], value);
        }

        // 스탯 인덱스로 플레이어 스킬 스탯 변경
        public static (bool, int) AddPlayerStatSkillByIndex(Stat1st stat1st, PlayerStat2nd stat2nd, uint index, ulong value, ulong per)
        {
            var is1stStat = Is1stStat(index);
            int order;

            if (is1stStat)
            {
                order = (int)StatIndexTo1stOrder[(StatIndex)index];

                if (per != 0)
                    AddStatValue(ref stat1st.SkillForRate[order], ConvertToUint16(per));
                
                if (value != 0)
                    AddStatValue(ref stat1st.SkillForValue[order], ConvertToUint16(value));
            }
            else
            {
                order = (int)StatIndexTo2ndOrder[(StatIndex)index];

                if (per != 0)
                    AddStatValue(ref stat2nd.SkillForRate[order], per);

                if (value != 0)
                    AddStatValue(ref stat2nd.SkillForValue[order], value);
            }

            return (is1stStat, order);
        }
        public static (bool, int) SubPlayerStatSkillByIndex(Stat1st stat1st, PlayerStat2nd stat2nd, uint index, ulong value, ulong per)
        {
            var is1stStat = Is1stStat(index);
            int order;

            if (is1stStat)
            {
                order = (int)StatIndexTo1stOrder[(StatIndex)index];

                if (per != 0)
                    SubStatValue(ref stat1st.SkillForRate[order], ConvertToUint16(per));
                if (value != 0)
                    SubStatValue(ref stat1st.SkillForValue[order], ConvertToUint16(value));
            }
            else
            {
                order = (int)StatIndexTo2ndOrder[(StatIndex)index];

                if (per != 0)
                    SubStatValue(ref stat2nd.SkillForRate[order], per);
                if (value != 0)
                    SubStatValue(ref stat2nd.SkillForValue[order], value);
            }

            return (is1stStat, order);
        }
        // 스탯 인덱스로 플레이어 아이템 스탯 변경
        public static (bool, int) AddPlayerStatItemByIndex(Stat1st stat1st, PlayerStat2nd stat2nd, uint index, ulong value, ulong per)
        {
            var is1stStat = Is1stStat(index);
            int order;

            if (is1stStat)
            {
                order = (int)StatIndexTo1stOrder[(StatIndex)index];

                if (per != 0)
                    AddStatValue(ref stat1st.ItemForRate[order], ConvertToUint16(per));
                if (value != 0)
                    AddStatValue(ref stat1st.ItemForValue[order], ConvertToUint16(value));
            }
            else
            {
                order = (int)StatIndexTo2ndOrder[(StatIndex)index];
                if (per != 0)
                    AddStatValue(ref stat2nd.ItemForRate[order], per);
                if (value != 0)
                    AddStatValue(ref stat2nd.ItemForValue[order], value);
            }

            return (is1stStat, order);
        }
        public static (bool, int) SubPlayerStatItemByIndex(Stat1st stat1st, PlayerStat2nd stat2nd, uint index, ulong value, ulong per)
        {
            var is1stStat = Is1stStat(index);
            int order;

            if (is1stStat)
            {
                order = (int)StatIndexTo1stOrder[(StatIndex)index];

                if (per != 0)
                    SubStatValue(ref stat1st.ItemForRate[order], ConvertToUint16(per));
                if (value != 0)
                    SubStatValue(ref stat1st.ItemForValue[order], ConvertToUint16(value));
            }
            else
            {
                order = (int)StatIndexTo2ndOrder[(StatIndex)index];

                if (per != 0)
                    SubStatValue(ref stat2nd.ItemForRate[order], per);
                if (value != 0)
                    SubStatValue(ref stat2nd.ItemForValue[order], value);
            }

            return (is1stStat, order);
        }
        // 스탯 인덱스로 플레이어 이벤트 스탯 변경
        public static (bool, int) AddPlayerStatEventByIndex(Stat1st stat1st, PlayerStat2nd stat2nd, uint index, ulong value, ulong per)
        {
            var is1stStat = Is1stStat(index);
            int order;

            if (is1stStat)
            {
                order = (int)StatIndexTo1stOrder[(StatIndex)index];

                if (per != 0)
                    AddStatValue(ref stat1st.EventForRate[order], ConvertToUint16(per));
                if (value != 0)
                    AddStatValue(ref stat1st.EventForValue[order], ConvertToUint16(value));
            }
            else
            {
                order = (int)StatIndexTo2ndOrder[(StatIndex)index];

                if (per != 0)
                    AddStatValue(ref stat2nd.EventForRate[order], per);
                if (value != 0)
                    AddStatValue(ref stat2nd.EventForValue[order], value);
            }

            return (is1stStat, order);
        }
        public static (bool, int) SubPlayerStatEventByIndex(Stat1st stat1st, PlayerStat2nd stat2nd, uint index, ulong value, ulong per)
        {
            var is1stStat = Is1stStat(index);
            int order;

            if (is1stStat)
            {
                order = (int)StatIndexTo1stOrder[(StatIndex)index];

                if (per != 0)
                    SubStatValue(ref stat1st.EventForRate[order], ConvertToUint16(per));
                if (value != 0)
                    SubStatValue(ref stat1st.EventForValue[order], ConvertToUint16(value));
            }
            else
            {
                order = (int)StatIndexTo2ndOrder[(StatIndex)index];

                if (per != 0)
                    SubStatValue(ref stat2nd.EventForRate[order], per);
                if (value != 0)
                    SubStatValue(ref stat2nd.EventForValue[order], value);
            }

            return (is1stStat, order);
        }

        // 일괄 처리
        public static ErrorCode BatchInitPlayerStat(byte tribe, byte classType, Stat1st stat1st, PlayerStat2nd stat2nd, bool isCreate = false)
        {
            var err = InitPlayerStat(tribe, stat1st, stat2nd, isCreate);
            if (err != ErrorCode.Success)
                return err;

            return CalcPlayerStatAll(classType, stat1st, stat2nd);
        }

        public static ErrorCode BatchAddPlayerStatOriginByIndex(byte classType, Stat1st stat1st, PlayerStat2nd stat2nd, uint index, ushort value)
        {
            AddPlayerStatOriginByIndex(stat1st, index, value);

            return CalcPlayerStatAll(classType, stat1st, stat2nd);
        }
        public static ErrorCode BatchSubPlayerStatOriginByIndex(byte classType, Stat1st stat1st, PlayerStat2nd stat2nd, uint index, ushort value)
        {
            SubPlayerStatOriginByIndex(stat1st, index, value);

            return CalcPlayerStatAll(classType, stat1st, stat2nd);
        }

        public static ErrorCode BatchAddPlayerStatSkillByIndex(byte classType, Stat1st stat1st, PlayerStat2nd stat2nd, uint index, ulong value, ulong per)
        {
            (var is1stStat, var order) = AddPlayerStatSkillByIndex(stat1st, stat2nd, index, value, per);
            if (is1stStat)
                return CalcPlayerStatAll(classType, stat1st, stat2nd);

            CalcPlayerStat2ndFinal(stat2nd, order);

            return ErrorCode.Success;
        }
        public static ErrorCode BatchSubPlayerStatSkillByIndex(byte classType, Stat1st stat1st, PlayerStat2nd stat2nd, uint index, ulong value, ulong per)
        {
            (var is1stStat, var order) = SubPlayerStatSkillByIndex(stat1st, stat2nd, index, value, per);
            if (is1stStat)
                return CalcPlayerStatAll(classType, stat1st, stat2nd);

            CalcPlayerStat2ndFinal(stat2nd, order);

            return ErrorCode.Success;
        }
        public static ErrorCode BatchAddPlayerStatItemByIndex(byte classType, Stat1st stat1st, PlayerStat2nd stat2nd, uint index, ulong value, ulong per)
        {
            (var is1stStat, var order) = AddPlayerStatItemByIndex(stat1st, stat2nd, index, value, per);
            if (is1stStat)
                return CalcPlayerStatAll(classType, stat1st, stat2nd);

            CalcPlayerStat2ndFinal(stat2nd, order);

            return ErrorCode.Success;
        }
        public static ErrorCode BatchSubPlayerStatItemByIndex(byte classType, Stat1st stat1st, PlayerStat2nd stat2nd, uint index, ulong value, ulong per)
        {
            (var is1stStat, var order) = SubPlayerStatItemByIndex(stat1st, stat2nd, index, value, per);
            if (is1stStat)
                return CalcPlayerStatAll(classType, stat1st, stat2nd);

            CalcPlayerStat2ndFinal(stat2nd, order);

            return ErrorCode.Success;
        }
        public static ErrorCode BatchAddPlayerStatEventByIndex(byte classType, Stat1st stat1st, PlayerStat2nd stat2nd, uint index, ulong value, ulong per)
        {
            (var is1stStat, var order) = AddPlayerStatEventByIndex(stat1st, stat2nd, index, value, per);
            if (is1stStat)
                return CalcPlayerStatAll(classType, stat1st, stat2nd);

            CalcPlayerStat2ndFinal(stat2nd, order);

            return ErrorCode.Success;
        }
        public static ErrorCode BatchSubPlayerStatEventByIndex(byte classType, Stat1st stat1st, PlayerStat2nd stat2nd, uint index, ulong value, ulong per)
        {
            (var is1stStat, var order) = SubPlayerStatEventByIndex(stat1st, stat2nd, index, value, per);
            if (is1stStat)
                return CalcPlayerStatAll(classType, stat1st, stat2nd);

            CalcPlayerStat2ndFinal(stat2nd, order);

            return ErrorCode.Success;
        }

        // 2차 스탯 중 현상수배 이벤트 스탯만 일괄 계산
        public static ErrorCode BatchPlayerStatEvent_Wanted(byte classType, Stat1st stat1st, PlayerStat2nd stat2nd, int wantedLv, bool isActive)
        {
            //List<int> orderList = new();

            //if (wantedLv > 0)
            //{
            //    var wantedPenalty = WantedEvents[wantedLv - 1];
            //    if (wantedPenalty.Item2 > 0)
            //    {
            //        if (isActive)
            //        {
            //            SubPlayerStatEventByIndex(stat1st, stat2nd, (int)StatIndex.PhysicalAp, wantedPenalty.Item2);
            //            SubPlayerStatEventByIndex(stat1st, stat2nd, (int)StatIndex.MagicalAp, wantedPenalty.Item2);
            //        }
            //        else
            //        {
            //            AddPlayerStatEventByIndex(stat1st, stat2nd, (int)StatIndex.PhysicalAp, wantedPenalty.Item2);
            //            AddPlayerStatEventByIndex(stat1st, stat2nd, (int)StatIndex.MagicalAp, wantedPenalty.Item2);
            //        }


            //        if (!orderList.Exists(x => x == (int)Stat2ndOrder.PhysicalAp))
            //            orderList.Add((int)Stat2ndOrder.PhysicalAp);
            //        if (!orderList.Exists(x => x == (int)Stat2ndOrder.MagicalAp))
            //            orderList.Add((int)Stat2ndOrder.MagicalAp);
            //    }
            //    if (wantedPenalty.Item3 > 0)
            //    {
            //        if (isActive)
            //        {
            //            SubPlayerStatEventByIndex(stat1st, stat2nd, (int)StatIndex.PhysicalDp, wantedPenalty.Item3);
            //            SubPlayerStatEventByIndex(stat1st, stat2nd, (int)StatIndex.MagicalDp, wantedPenalty.Item3);
            //        }
            //        else
            //        {
            //            AddPlayerStatEventByIndex(stat1st, stat2nd, (int)StatIndex.PhysicalDp, wantedPenalty.Item3);
            //            AddPlayerStatEventByIndex(stat1st, stat2nd, (int)StatIndex.MagicalDp, wantedPenalty.Item3);
            //        }

            //        if (!orderList.Exists(x => x == (int)Stat2ndOrder.PhysicalDp))
            //            orderList.Add((int)Stat2ndOrder.PhysicalDp);
            //        if (!orderList.Exists(x => x == (int)Stat2ndOrder.MagicalDp))
            //            orderList.Add((int)Stat2ndOrder.MagicalDp);
            //    }
            //}

            //for (int i = 0; i < orderList.Count; ++i)
            //{
            //    CalcPlayerStat2ndFinal(stat2nd, orderList[i]);
            //}

            return ErrorCode.Success;
        }
        #endregion
        #region >>> Npc
        // 2차 스탯만 재계산(전체)
        public static void CalcNpcStat2ndFinal(Stat2nd stat2nd)
        {
            stat2nd.CalcFinal(Stat2ndMaxValues);
        }
        // 2차 스탯만 재계산(일부)
        public static void CalcNpcStat2ndFinal(Stat2nd stat2nd, int order)
        {
            stat2nd.CalcFinal(order, Stat2ndMaxValues[order]);
        }

        // 스탯 인덱스로 NPC 스킬 스탯 추가
        public static int AddNpcStatSkillByIndex(Stat2nd stat2nd, uint index, ulong value, ulong per)
        {
            var order = (int)ToStat2ndOrder((StatIndex)index);

            if (per != 0)
                AddStatValue(ref stat2nd.SkillForRate[order], per, Stat2ndMaxValues[order]);
            if (value != 0)
                AddStatValue(ref stat2nd.SkillForValue[order], value, Stat2ndMaxValues[order]);

            return order;
        }
        public static int SubNpcStatSkillByIndex(Stat2nd stat2nd, uint index, ulong value, ulong per)
        {
            var order = (int)ToStat2ndOrder((StatIndex)index);

            if (per != 0)
                SubStatValue(ref stat2nd.SkillForRate[order], per);
            if (value != 0)
                SubStatValue(ref stat2nd.SkillForValue[order], value);

            return order;
        }

        // 일괄 처리
        public static void BatchAddNpcStatSkillByIndex(Stat2nd stat2nd, uint index, ulong value, ulong per)
        {
            var order = AddNpcStatSkillByIndex(stat2nd, index, value, per);
            CalcNpcStat2ndFinal(stat2nd, order);
        }
        public static void BatchSubNpcStatSkillByIndex(Stat2nd stat2nd, uint index, ulong value, ulong per)
        {
            var order = SubNpcStatSkillByIndex(stat2nd, index, value, per);
            CalcNpcStat2ndFinal(stat2nd, order);
        }
        #endregion

        public static void AddStatValue(ref ulong stat, ushort value, ushort maxValue = ushort.MaxValue)
        {
            if (maxValue - stat >= value)
                stat += value;
            else
                stat = maxValue;
        }
        public static void AddStatValue(ref ulong stat, ulong value, ulong maxValue = ulong.MaxValue)
        {
            if (maxValue - stat >= value)
                stat += value;
            else
                stat = maxValue;
        }
        public static void SubStatValue(ref ushort stat, ushort value)
        {
            if (stat >= value)
                stat -= value;
            else
                stat = 0;
        }
        public static void SubStatValue(ref ulong stat, ulong value)
        {
            if (stat >= value)
                stat -= value;
            else
                stat = 0;
        }
        public static ushort ConvertToUint16(ulong value)
        {
#if Debug
            // log
            return (ushort)(value % ushort.MaxValue);
#endif
            return (ushort)value;
        }

        public static void LoadEnumMapping()
        {
            StatIndexTo1stOrder = new();
            StatIndexTo2ndOrder = new();
            Stat1stOrderToIndex = new();
            Stat2ndOrderToIndex = new();

            var statIndex = Enum.GetValues(typeof(StatIndex));
            var stat1order = Enum.GetValues(typeof(Stat1stOrder));
            var stat2order = Enum.GetValues(typeof(Stat2ndOrder));

            if (statIndex.Length + 2 != stat1order.Length + stat2order.Length)
                throw new Exception("Stat Enum is Not Matched");

            for (int i = 0, len = statIndex.Length; i < len; i++)
            {
                var s = (StatIndex)statIndex.GetValue(i);
                var stat = (int)s;
                if (stat / 10000 == 1)
                {
                    // 1차 스탯                    
                    var so = (Stat1stOrder)stat1order.GetValue(i - StatIndexTo2ndOrder.Count);

                    if (!StatIndexTo1stOrder.ContainsKey(s))
                        StatIndexTo1stOrder.Add(s, so);
                    
                    if (!Stat1stOrderToIndex.ContainsKey(so))
                        Stat1stOrderToIndex.Add(so, s);
              
                }
                else
                {
                    // 2차 스탯
                    var so = (Stat2ndOrder)stat2order.GetValue(i - StatIndexTo1stOrder.Count);

                    if (!StatIndexTo2ndOrder.ContainsKey(s))
                        StatIndexTo2ndOrder.Add(s, so);

                    if (!Stat2ndOrderToIndex.ContainsKey(so))
                        Stat2ndOrderToIndex.Add(so, s);

                }
            }
        }

        public static Stat1stOrder ToStat1stOrder(StatIndex index)
        {
            return StatIndexTo1stOrder[index];
        }

        public static Stat2ndOrder ToStat2ndOrder(StatIndex index)
        {
            return StatIndexTo2ndOrder[index];
        }

        public static StatIndex ToStatIndex(Stat1stOrder order)
        {
            return Stat1stOrderToIndex[order];
        }

        public static StatIndex ToStatIndex(Stat2ndOrder order)
        {
            return Stat2ndOrderToIndex[order];
        }

        public static ErrorCode LoadTable(List<ulong> stat2ndMaxValues,                                       // 2nd stat max values
                                            Dictionary<byte, List<(Stat2ndOrder, ulong[])>> charClassStatus,    // key: class, value: (Stat2ndOrder, 1st stat array)
                                            Dictionary<byte, ulong[]> charClassMain,                           // key: tribe, value: 2nd stat max value array
                                            Dictionary<byte, List<(StatIndex, ulong)>> charClassSub,            // key: tribe, value: (StatIndex, 2nd stat value)
                                            List<(ulong, ulong, ulong, ulong)> wantedEvents)                    // wanted panalty array
        {
            if(StatIndexTo1stOrder is null || StatIndexTo2ndOrder is null ||
               Stat1stOrderToIndex is null || Stat2ndOrderToIndex is null)
                LoadEnumMapping();

            Stat2ndMaxValues = new ulong[stat2ndMaxValues.Count];
            Array.Copy(stat2ndMaxValues.ToArray(), Stat2ndMaxValues, stat2ndMaxValues.Count);

            CharClassStatus = new();
            CharStatusByValue = new();
            foreach (var status in charClassStatus)
            {
                CharClassStatus.Add(status.Key, status.Value.ToArray());

                for (int i = 0, len = status.Value.Count; i < len; ++i)
                {
                    var stat = status.Value[i];
                    for (int j = 0, len_j = stat.Item2.Length, divide = len_j/2; j < len_j; ++j)
                    {
                        if (Stat2ndOrderToIndex is null)
                            continue;

                        StatIndex statindex = Stat2ndOrderToIndex[stat.Item1];

                        if (stat.Item2[j] > 0)
                        {
                            if (j < divide)
                            {
                                CharStatusByValue.Add((ushort)statindex);
                            }
                        }
                    }
                }
            }

            CharCreateStats = new();
            foreach (var tribe in charClassMain.Keys)
            {
                if (!charClassSub.TryGetValue(tribe, out var tribeBaseStats))
                    return ErrorCode.TableEmpty;

                CharCreateStats.Add(tribe, (charClassMain[tribe], tribeBaseStats.ToArray()));
            }

            WantedEvents = new (ulong, ulong, ulong, ulong)[wantedEvents.Count];
            Array.Copy(wantedEvents.ToArray(), WantedEvents, wantedEvents.Count);

            return ErrorCode.Success;
        }
    }
}