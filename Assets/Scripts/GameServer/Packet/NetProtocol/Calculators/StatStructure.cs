using System;

namespace NetProtocol
{
    public enum StatIndex : ushort
    {
        Str = 10000,                                // 힘
        Dex = 10001,                                // 민첩
        Vit = 10002,                                // 체력
        Int = 10003,                                // 지능
        Wis = 10004,                                // 정신
        Agi = 10005,                                // 순발

        PhysicalAp = 20000,                         // 물리 공격력
        MagicalAp = 20001,                          // 마법 공격력
        PhysicalDp = 20002,                         // 물리 방어력
        MagicalDp = 20003,                          // 마법 방어력
        PhysicalAccuracy = 20004,                   // 물리 명중
        MagicalAccuracy = 20005,                    // 마법 명중
        PhysicalDodge = 20006,                      // 물리 회피
        MagicalDodge = 20007,                       // 마법 회피
        PhysicalPenetration = 20008,                // 물리 관통
        MagicalPenetration = 20009,                 // 마법 관통
        PhysicalPenetrationResist = 20010,          // 물리 관통 저항
        MagicalPenetrationResist = 20011,           // 마법 관통 저항
        MaxHp = 20012,                              // MAX_HP
        MaxMp = 20013,                              // MAX_MP,
        HpRecovery = 20014,                         // HP 회복
        MpRecovery = 20015,                         // MP 회복

        PhysicalCriticalDamage = 21000,             // 물리 치명타 피해량(%)
        MagicalCriticalDamage = 21001,              // 마법 치명타 피해량(%)
        PhysicalCriticalDamageResist = 21002,       // 물리 치명타 피해량 감소(%)
        MagicalCriticalDamageResist = 21003,        // 마법 치명타 피해량 감소(%)
        PhysicalCriticalProb = 21004,               // 물리 치명타 확률(%)
        MagicalCriticalProb = 21005,                // 마법 치명타 확률(%)
        PhysicalCriticalResistProb = 21006,         // 물리 치명타 저항(%)
        MagicalCriticalResistProb = 21007,          // 마법 치명타 저항(%)
        PhysicalAbnormalStateProb = 21008,          // 물리 상태 이상 부여 확률(%)
        MagicalAbnormalStateProb = 21009,           // 마법 상태 이상 부여 확률(%)
        PhysicalAbnormalStateResistProb = 21010,    // 물리 상태 이상 저항 확률(%)
        MagicalAbnormalStateResistProb = 21011,     // 마법 상태 이상 저항 확률(%)
        FireElementAp = 21012,                      // 불 속성 공격(%)
        WaterElementAp = 21013,                     // 물 속성 공격(%)
        DivineElementAp = 21014,                    // 신성 속성 공격(%)
        DarkElementAp = 21015,                      // 암흑 속성 공격(%)
        PoisonElementAp = 21016,                    // 독 속성 공격(%)
        AllElement = 21017,                         // 모든 속성 공격(%)
        WaterElementDp = 21018,                     // 물 속성 방어(%)
        FireElementDp = 21019,                      // 불 속성 방어(%)
        DivineElementDp = 21020,                    // 신성 속성 방어(%)
        DarkElementDp = 21021,                      // 암흑 속성 방어(%)
        PoisonElementDp = 21022,                    // 독 속성 방어(%)
        AllElementDp = 21023,                       // 모든 속성 공격(%)
        HpAbsorption = 21024,                       // HP 흡수(%)
        MpAbsorption = 21025,                       // MP 흡수(%)
        DamageReflexPower = 21026,                  // 피해 반사 위력(%)
        DamageReflexProb = 21027,                   // 피해 반사 확률(%)
        BlockProb = 21028,                          // 막기 확률(%)
        HpRecoveryIncrease = 21029,                 // HP 회복량 증가(%)
        MpRecoveryIncrease = 21030,                 // MP 회복량 증가(%)

        SkillCoolTimeDecrease = 31000,              // 스킬 재사용 시간 감소(%)
        SkillPowerIncrease = 31001,                 // 스킬 위력 증가(%)
        MpConsumeDecrease = 31002,                  // MP 소모량 감소(%)
        HpPotionRecoveryIncrease = 31003,           // HP 포션 회복량 증가(%)
        MpPotionRecoveryIncrease = 31004,           // MP 포션 회복량 증가(%)
        MoveSpeed = 31005,                          // 이동 속도 증가(%)
        AttackSpeed = 31006,                        // 공격 속도 증가(%)
        CronAcquisitionAmount = 31007,              // 크론 획득량 증가(%)
        ExpAcquisitionAmount = 31008,               // 경험치 획득량 증가(%)
        ItemAcquisitionIncreaseRate = 31009,        // 아이템 획득 증가율(%)
        DamageIncrease_All = 31010,                 // 피해량 증가 - All(%)
        DamageIncrease_Boss = 31011,                // 피해량 증가 - Boss(%)
        DamageIncrease_PvP = 31012,                 // 피해량 증가 - PvP(%)
        DamageIncrease_FireElement = 31013,         // 피해량 증가 - 불 속성(%)
        DamageIncrease_WaterElement = 31014,        // 피해량 증가 - 물 속성(%)
        DamageIncrease_DivineElement = 31015,       // 피해량 증가 - 신성 속성(%)
        DamageIncrease_DarkElement = 31016,         // 피해량 증가 - 암흑 속성(%)
        DamageIncrease_PoisonElement = 31017,       // 피해량 증가 - 독 속성(%)
        DamageIncrease_BloodFog = 31018,            // 피해량 증가 - 블러드포그(%)
        DamageIncrease_DarkLeap = 31019,            // 피해량 증가 - 암흑 도약(%)
        DamageDecrease_All = 31020,                 // 피해량 감소 - All(%)
        DamageDecrease_Boss = 31021,                // 피해량 감소 - Boss(%)
        DamageDecrease_PvP = 31022,                 // 피해량 감소 - PvP(%)
        DamageDecrease_FireElement = 31023,         // 피해량 감소 - 불 속성(%)
        DamageDecrease_WaterElement = 31024,        // 피해량 감소 - 물 속성(%)
        DamageDecrease_DivineElement = 31025,       // 피해량 감소 - 신성 속성(%)
        DamageDecrease_DarkElement = 31026,         // 피해량 감소 - 암흑 속성(%)
        DamageDecrease_PoisonElement = 31027,       // 피해량 감소 - 독 속성(%)
        DamageDecrease_BloodFog = 31028,            // 피해량 감소 - 블러드포그(%)
        DamageDecrease_DarkLeap = 31029,            // 피해량 감소 - 암흑 도약(%)
    }
    public enum Stat1stOrder : ushort
    {
        Str,                                        // 힘
        Dex,                                        // 민첩
        Vit,                                        // 체력
        Int,                                        // 지능
        Wis,                                        // 정신
        Agi,                                        // 순발

        End
    }
    public enum Stat2ndOrder : ushort
    {
        PhysicalAp,                                 // 물리 공격력
        MagicalAp,                                  // 마법 공격력
        PhysicalDp,                                 // 물리 방어력
        MagicalDp,                                  // 마법 방어력
        PhysicalAccuracy,                           // 물리 명중
        MagicalAccuracy,                            // 마법 명중
        PhysicalDodge,                              // 물리 회피
        MagicalDodge,                               // 마법 회피
        PhysicalPenetration,                        // 물리 관통
        MagicalPenetration,                         // 마법 관통
        PhysicalPenetrationResist,                  // 물리 관통 저항
        MagicalPenetrationResist,                   // 마법 관통 저항
        MaxHp,                                      // MAX_HP
        MaxMp,                                      // MAX_MP,
        HpRecovery,                                 // HP 회복
        MpRecovery,                                 // MP 회복

        PhysicalCriticalDamage,                     // 물리 치명타 피해량(%)
        MagicalCriticalDamage,                      // 마법 치명타 피해량(%)
        PhysicalCriticalDamageResist,               // 물리 치명타 피해량 감소(%)
        MagicalCriticalDamageResist,                // 마법 치명타 피해량 감소(%)
        PhysicalCriticalProb,                       // 물리 치명타 확률(%)
        MagicalCriticalProb,                        // 마법 치명타 확률(%)
        PhysicalCriticalResistProb,                 // 물리 치명타 저항(%)
        MagicalCriticalResistProb,                  // 마법 치명타 저항(%)
        PhysicalAbnormalStateProb,                  // 물리 상태 이상 부여 확률(%)
        MagicalAbnormalStateProb,                   // 마법 상태 이상 부여 확률(%)
        PhysicalAbnormalStateResistProb,            // 물리 상태 이상 저항 확률(%)
        MagicalAbnormalStateResistProb,             // 마법 상태 이상 저항 확률(%)
        FireElementAp,                              // 불 속성 공격(%)
        WaterElementAp,                             // 물 속성 공격(%)
        DivineElementAp,                            // 신성 속성 공격(%)
        DarkElementAp,                              // 암흑 속성 공격(%)
        PoisonElementAp,                            // 독 속성 공격(%)
        AllElement,                                 // 모든 속성 공격(%)
        WaterElementDp,                             // 물 속성 방어(%)
        FireElementDp,                              // 불 속성 방어(%)
        DivineElementDp,                            // 신성 속성 방어(%)
        DarkElementDp,                              // 암흑 속성 방어(%)
        PoisonElementDp,                            // 독 속성 방어(%)
        AllElementDp,                               // 모든 속성 공격(%)
        HpAbsorption,                               // HP 흡수(%)
        MpAbsorption,                               // MP 흡수(%)
        DamageReflexPower,                          // 피해 반사 위력(%)
        DamageReflexProb,                           // 피해 반사 확률(%)
        BlockProb,                                  // 막기 확률(%)
        HpRecoveryIncrease,                         // HP 회복량 증가(%)
        MpRecoveryIncrease,                         // MP 회복량 증가(%)

        SkillCoolTimeDecrease,                      // 스킬 재사용 시간 감소(%)
        SkillPowerIncrease,                         // 스킬 위력 증가(%)
        MpConsumeDecrease,                          // MP 소모량 감소(%)
        HpPotionRecoveryIncrease,                   // HP 포션 회복량 증가(%)
        MpPotionRecoveryIncrease,                   // MP 포션 회복량 증가(%)
        MoveSpeed,                                  // 이동 속도 증가(%)
        AttackSpeed,                                // 공격 속도 증가(%)
        CronAcquisitionAmount,                      // 크론 획득량 증가(%)
        ExpAcquisitionAmount,                       // 경험치 획득량 증가(%)
        ItemAcquisitionIncreaseRate,                // 아이템 획득 증가율(%)
        DamageIncrease_All,                         // 피해량 증가 - All(%)
        DamageIncrease_Boss,                        // 피해량 증가 - Boss(%)
        DamageIncrease_PvP,                         // 피해량 증가 - PvP(%)
        DamageIncrease_FireElement,                 // 피해량 증가 - 불 속성(%)
        DamageIncrease_WaterElement,                // 피해량 증가 - 물 속성(%)
        DamageIncrease_DivineElement,               // 피해량 증가 - 신성 속성(%)
        DamageIncrease_DarkElement,                 // 피해량 증가 - 암흑 속성(%)
        DamageIncrease_PoisonElement,               // 피해량 증가 - 독 속성(%)
        DamageIncrease_BloodFog,                    // 피해량 증가 - 블러드포그(%)
        DamageIncrease_DarkLeap,                    // 피해량 증가 - 암흑 도약(%)
        DamageDecrease_All,                         // 피해량 감소 - All(%)
        DamageDecrease_Boss,                        // 피해량 감소 - Boss(%)
        DamageDecrease_PvP,                         // 피해량 감소 - PvP(%)
        DamageDecrease_FireElement,                 // 피해량 감소 - 불 속성(%)
        DamageDecrease_WaterElement,                // 피해량 감소 - 물 속성(%)
        DamageDecrease_DivineElement,               // 피해량 감소 - 신성 속성(%)
        DamageDecrease_DarkElement,                 // 피해량 감소 - 암흑 속성(%)
        DamageDecrease_PoisonElement,               // 피해량 감소 - 독 속성(%)
        DamageDecrease_BloodFog,                    // 피해량 감소 - 블러드포그(%)
        DamageDecrease_DarkLeap,                    // 피해량 감소 - 암흑 도약(%)

        End,
    }

    //public static class StatEnumConverter
    //{
    //    public static Stat1stOrder ToStat1stOrder(this StatIndex index)
    //    {
    //        return ToStat1stOrder((uint)index);
    //    }
    //    public static Stat1stOrder ToStat1stOrder(this uint index)
    //    {
    //        if (index / 1000 != 10)
    //            return Stat1stOrder.End;

    //        return (Stat1stOrder)(index % 1000);
    //    }

    //    public static Stat2ndOrder ToStat2ndOrder(this StatIndex index)
    //        => ToStat2ndOrder((uint)index);
    //    public static Stat2ndOrder ToStat2ndOrder(this uint index)
    //        => (index / 1000) switch
    //        {
    //            20 => (Stat2ndOrder)(index % 1000),
    //            21 => (Stat2ndOrder)(index % 1000 + (int)Stat2ndOrder.ValueEnd),
    //            31 => (Stat2ndOrder)(index % 1000 + (int)Stat2ndOrder.NpcEnd),
    //            _ => Stat2ndOrder.End,
    //        };

    //    public static StatIndex ToStatIndex(this Stat1stOrder order)
    //        => ToStatIndex((uint)order);
    //    public static StatIndex ToStatIndex(this uint order)
    //        => (StatIndex)(order + 10000);

    //    public static bool IsStat1st(this StatIndex index)
    //        => IsStat1st((uint)index);
    //    public static bool IsStat1st(this uint index)
    //        => index % 1000 == 1;    
    //}

    public class Stat1st
    {
        public ulong[] Origin { get; set; }            // 순수 1차 스텟
        public ulong[] Final { get; private set; }     // 최종 스텟(스킬 등으로 합산된 최종 수치)

        public ulong[] SkillForValue { get; set; }             // 스킬에 의해 적용될 정수형 스탯 값
        public ulong[] SkillForRate { get; set; }              // 스킬에 의해 적용될 비율형 스탯 값

        public ulong[] ItemForValue { get; set; }              // 아이템에 의해 적용될 정수형 스탯 값
        public ulong[] ItemForRate { get; set; }              // 아이템에 의해 적용될 비율형 스탯 값

        public ulong[] EventForValue { get; set; }             // 기타 이벤트에 의해 적용될 정수형 스탯 값
        public ulong[] EventForRate { get; set; }             // 기타 이벤트에 의해 적용될 비율형 스탯 값

        protected int _count = (int)Stat1stOrder.End;

        public Stat1st()
        {
            Origin = new ulong[_count];
            Final = new ulong[_count];

            SkillForValue = new ulong[_count];
            SkillForRate = new ulong[_count];
            ItemForValue = new ulong[_count];
            ItemForRate = new ulong[_count];
            EventForValue = new ulong[_count];
            EventForRate = new ulong[_count];
        }

        public void CalcFinal()
        {
            for (int order = 0; order < _count; ++order)
            {
                var rate = SkillForRate[order] + ItemForRate[order] + EventForRate[order];
                Final[order] = Math.Clamp(Origin[order] + (Origin[order] * rate / StatCalculator.BUFF_RATE_DIVISION ) + SkillForValue[order] + ItemForValue[order] + EventForValue[order], ushort.MinValue, ushort.MaxValue);
            }
        }
        public void CalcFinal(int order)
        {
            var rate = SkillForRate[order] + ItemForRate[order] + EventForRate[order];
            Final[order] = Math.Clamp((Origin[order] * (Origin[order] * rate / StatCalculator.BUFF_RATE_DIVISION)) + (SkillForValue[order] + ItemForValue[order] + EventForValue[order]), ushort.MinValue, ushort.MaxValue);
        }
    }
    public class Stat2nd
    {
        public ulong[] Base { get; protected set; }     // 종족별 부여되는 기본 스탯 값        
        public double[] Final { get; protected set; }    // 최종 스텟(스킬 등으로 합산된 최종 수치)

        public ulong[] SkillForValue { get; set; }              // 스킬에 의해 적용될 정수형 스탯 값
        public ulong[] SkillForRate { get; set; }              // 스킬에 의해 적용될 비율형 스탯 값

        protected int _count = (int)Stat2ndOrder.End;

        public Stat2nd()
        {
            Base = new ulong[_count];
            Final = new double[_count];
            
            SkillForValue = new ulong[_count];
            SkillForRate = new ulong[_count];
            
        }
        public virtual void CalcFinal(ulong[] maxValues) 
        {
            for (int order = 0; order < _count; ++order)
            {
                var rate = SkillForRate[order];

                if (StatCalculator.IsRate((Stat2ndOrder)order))
                {
                    Final[order] = Math.Clamp(Base[order] + (Base[order] * rate / StatCalculator.BUFF_RATE_DIVISION), 0, maxValues[order]);
                }
                else
                {
                    Final[order] = Math.Clamp(Base[order] + (Base[order] * rate / StatCalculator.BUFF_RATE_DIVISION) + SkillForValue[order], 0, maxValues[order]);
                }

                Final[order] /= 1_000_000;
            }
        }
        public virtual void CalcFinal(int order, ulong maxValue) 
        {
            var rate = SkillForRate[order];
            if (StatCalculator.IsRate((Stat2ndOrder)order))
            {
                Final[order] = Math.Clamp(Base[order] + (Base[order] * rate / StatCalculator.BUFF_RATE_DIVISION), 0, maxValue);
            }
            else
            {
                Final[order] = Math.Clamp(Base[order] + (Base[order] * rate / StatCalculator.BUFF_RATE_DIVISION) + SkillForValue[order], 0, maxValue);
            }

            Final[order] /= 1_000_000;
        }

        public ulong ConvertToUInt64(Stat2ndOrder order) => (ulong)Final[(int)order];
        public int ConvertToInt32(Stat2ndOrder order) => (int)Final[(int)order];
        public float ConvertToFloat(Stat2ndOrder order) => (float)Final[(int)order];
    }


    public class PlayerStat2nd : Stat2nd
    {
        public ulong[] Var { get; private set; }    // 1차 스텟에 의해 환산된 스탯 값

        public ulong[] ItemForValue { get; set; }              // 아이템에 의해 적용될 정수형 스탯 값
        public ulong[] ItemForRate { get; set; }              // 아이템에 의해 적용될 비율형 스탯 값

        public ulong[] EventForValue { get; set; }             // 기타 이벤트에 의해 적용될 정수형 스탯 값
        public ulong[] EventForRate { get; set; }             // 기타 이벤트에 의해 적용될 비율형 스탯 값

        public PlayerStat2nd() : base()
        {
            Var = new ulong[_count];
            ItemForValue = new ulong[_count];
            ItemForRate = new ulong[_count];
            EventForValue = new ulong[_count];
            EventForRate = new ulong[_count];
        }

        public override void CalcFinal(ulong[] maxValues)
        {
            for (int order = 0; order < _count; ++order)
            {
                var sumRate = SkillForRate[order] + ItemForRate[order] + EventForRate[order];
                if (StatCalculator.IsRate((Stat2ndOrder)order))
                {
                    Final[order] = Math.Clamp(Base[order] + Var[order] + (Base[order] + Var[order]) * sumRate / StatCalculator.BUFF_RATE_DIVISION, 0, maxValues[order]);
                }
                else
                {
                    Final[order] = Math.Clamp(Base[order] + Var[order] + (Base[order] + Var[order]) * sumRate / StatCalculator.BUFF_RATE_DIVISION + SkillForValue[order] + ItemForValue[order] + EventForValue[order], 0, maxValues[order]);
                    //Final[order] = Math.Clamp(Base[order] + Var[order] + Skill[order] + Item[order] + Event[order], 0, maxValues[order]);
                }
                
                Final[order] /= 1_000_000;
            }
        }
        public override void CalcFinal(int order, ulong maxValue)
        {
            var sumRate = SkillForRate[order] + ItemForRate[order] + EventForRate[order];
            if (StatCalculator.IsRate((Stat2ndOrder)order))
            {
                Final[order] = Math.Clamp(Base[order] + Var[order] + (Base[order] + Var[order]) * sumRate / StatCalculator.BUFF_RATE_DIVISION, 0, maxValue);
            }
            else
            {
                Final[order] = Math.Clamp(Base[order] + Var[order] + (Base[order] + Var[order]) * sumRate / StatCalculator.BUFF_RATE_DIVISION + (SkillForValue[order] + ItemForValue[order] + EventForValue[order]), 0, maxValue);
                //Final[order] = Math.Clamp(Base[order] + Var[order] + Skill[order] + Item[order] + Event[order], 0, maxValue);
            }

            Final[order] /= 1_000_000;
        }
    }
}