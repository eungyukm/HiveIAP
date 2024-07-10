using NetProtocol.Packet;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

#nullable enable
namespace NetProtocol
{
    public static partial class DamageCalculator
    {
        private static readonly ThreadLocal<Random> _random = new(() => new Random());
        private const double DIVISION = 10e-5;
        public static bool Log;

        //https://playwith.sharepoint.com/:x:/s/RohanM2Studio/EcSauPpi1LJEjKIi5dZC-_IBbDGQrYtavod5bTne7rnsXg?e=YYV1Lp
        public static AttackResult Process(StatComponent attacker, StatComponent defender, in AttackInfo info)
        {
            var log = Log ? new AttackLog(info) : null;
            var judgment = AttackProcess(attacker, defender, info, log);
            if (AttackJudgment.Normal != judgment && AttackJudgment.Critical != judgment)
                return AttackResult.Create(judgment, log);

            if (info.ShieldStack > 0)
                return AttackResult.Create(judgment, true, log);

            return DamageProcess(judgment, attacker, defender, info, log);
        }

        private static AttackJudgment AttackProcess(StatComponent attacker, StatComponent defender, in AttackInfo info, AttackLog? log)
        {
            if (IsMiss(attacker, defender, info, log))
                return AttackJudgment.Miss;
            else if (IsEvasion(defender, info, log))
                return AttackJudgment.Dodge;
            else if (IsBlock(defender, info, log))
                return AttackJudgment.Block;
            else if (IsCritical(attacker, defender, info, log))
                return AttackJudgment.Critical;
            else
                return AttackJudgment.Normal;
        }

        private static AttackResult DamageProcess(AttackJudgment judgment, StatComponent attacker, StatComponent defender, in AttackInfo info, AttackLog? log)
        {
            var damage = GetDamage(attacker, info);
            var defense = GetDefense(defender, info);

            var penetrationAdder = info.AddPenetration ? damage : 0;
            var penetration = GetPenetration(attacker, defender, info, penetrationAdder, log);
            var criticalDamage = GetCriticalDamage(attacker, defender, info, judgment, log);
            var adjustment = GetAdjustment(attacker, defender, info, log);
            var elemental = GetElemental(attacker, defender, log);
            var abnormal = GetAbnormal(attacker, defender, info, log);

            var delta = adjustment + elemental + abnormal;

            double shield = info.Shield;
            var hasSheild = shield > 0;
            var passDefense = info.PassDefense;

            //damage *= (info.SkillRate * DIVISION) + attacker.GetIncreaseSkillPower();
            var skillRate = info.SkillRate * DIVISION;
            damage = false == hasSheild || info.PassSheild ?
                Process(damage, skillRate, defense, penetration) :
                Process(damage, skillRate);

            // 보호막이 있었나?
            if (hasSheild)
            {
                if (damage > shield)
                {
                    damage -= shield; 
                    damage = Process(damage, 1, defense, penetration); //잔여 데미지만큼 데미지량 재계산. 잔여 데미지 계산할 땐 위력 추가 없음
                }
                else
                {
                    shield -= damage;
                    damage = 0;
                }
            }

            var (hp, mp) = GetDrain(attacker, damage, info, log);
            var reflex = GetReflex(defender, damage, log);

            var resultDamage = DamageRange(damage);
            return AttackResult.Create(judgment, (int)resultDamage, hp, mp, reflex, (int)shield, log);

            int Process(double damage, double skillRate, double defense = 0, double penetration = 0)
            {
                // 피해량 계산 1
                damage -= passDefense ? 0 : (defense * (1 - penetration));
                damage = damage > 0 ? damage : 1; // 피해량 최소 1
                damage *= skillRate + attacker.GetIncreaseSkillPower();
                
                // 피해량 계산 2
                damage *= criticalDamage;

                // 피해량 계산 3
                damage += (damage * delta);

                if (0 > damage)
                    damage = 0;

                return (int)damage;
            }
        }

        private static int DamageRange(double damage)
        {
            var rand = _damageMin + _random.Value.NextDouble() * (_damageMax - _damageMin);
            var result = damage *= rand;
            return (int)result;
        }

        private static (long hp, long mp) GetDrain(StatComponent attacker, double damage, in AttackInfo info, AttackLog? log)
        {
            var (hpDrain, mpDrain) = (attacker.GetHpAbsorb(), attacker.GetMpAbsorb());
            var hp = (long)(damage * Math.Min(hpDrain + info.HpDrainRate, HpDrain.Max));
            var mp = (long)(damage * Math.Min(mpDrain + info.MpDrainRate, MpDrain.Max));

            log?.SetDrain(hp, mp);
            return (hp, mp);
        }

        private static int GetReflex(StatComponent defender, double damage, AttackLog? log)
        {
            var reflexProb = defender.GetDamageReflectionRate();
            var rate = GetRate();
            var reflexPower = reflexProb > rate ? defender.GetDamageReflectionPower() : 0;
            //todo. reflexPower랑 최대비율이랑 함 해야함
            var reflex = (int)(damage * Math.Min(reflexPower, Reflex.Max));

            log?.SetReflex(reflex, reflexProb, rate, reflexPower);
            return reflex;
        }

        private static double GetCriticalDamage(StatComponent attacker, StatComponent defender, in AttackInfo info, AttackJudgment judgment, AttackLog? log)
        {
            const float DEFAULT = 1F;

            if (judgment is not AttackJudgment.Critical)
                return DEFAULT;

            var (critical, reduction) = info.IsPhysical ?
                (attacker.GetPhysicalCriticalDamage(), defender.GetPhysicalCriticalDamageReduction()) :
                (attacker.GetMagicCriticalDamage(), defender.GetMagicCriticalDamageReduction());

            if (info.IsPvp)
            {
                critical += attacker.GetPvpCriticalDamage();
                reduction += defender.GetPvpCriticalDamageReduction();
            }

            var value = Math.Clamp(DEFAULT + info.CriticalRate + critical - reduction, CriticalDamage.Min, CriticalDamage.Max);
            log?.SetDamageCritical(critical, reduction, value);
            return value;
        }

        private static double GetPenetration(StatComponent attacker, StatComponent defender, in AttackInfo info, double adder, AttackLog? log)
        {
            var (penetration, resist) = GetPenetrasion(attacker, defender, info);

            penetration += adder;
            //NaN 방지
            if (0 == penetration)
                return penetration;

            var sum = resist + penetration;
            var value = (penetration / sum) * (1 - (resist / sum)) * Penetrate.Max;

            log?.SetPenetration(penetration, resist, value);
            return value;
        }

        private static double GetElemental(StatComponent attacker, StatComponent defender, AttackLog? log)
        {
            var increase = attacker.GetIncreaseDamageAllElements();
            var decrease = defender.GetDecreaseDamageAllElements();

            return increase + decrease;
        }

        //TODO. 증감 기획 리뷰 이후 작업 -by antique, plan team Heizelk
        private static double GetAdjustment(StatComponent attacker, StatComponent defender, in AttackInfo info, AttackLog? log)
        {
            var increase = attacker.GetIncreaseDamage();
            var decrease = defender.GetDecreaseDamage();

            if (info.IsPhysical)
            {
                increase += attacker.GetPhysicalIncreaseDamage();
                decrease += defender.GetPhysicalDecreaseDamage();
            }
            else
            {
                increase += attacker.GetMagicIncreaseDamage();
                decrease += defender.GetMagicDecreaseDamage();
            }

            if (info.IsPvp)
            {
                increase += attacker.GetIncreaseDamagePvp();
                decrease += defender.GetDecreaseDamagePvp();
            }

            if (info.Defender.IsBoss)
            {
                increase += attacker.GetIncreaseDamageBossMonster();
                decrease += defender.GetDecreaseDamageBossMonster();
            }

            if (info.Defender.IsNormalMonster)
            {
                increase += attacker.GetIncreaseDamageNormalMonster();
                decrease += defender.GetDecreaseDamageNormalMonster();
            }

            return increase - decrease;
        }

        // 상태이상 피해 증갑 리뷰 후 작업  -by antique, plan team Heizelk
        private static double GetAbnormal(StatComponent attacker, StatComponent defender, in AttackInfo info, AttackLog? log)
        {
            return 0;
        }

        // 공격자 기준 연산 1
        private static bool IsMiss(StatComponent attacker, StatComponent defender, in AttackInfo info, AttackLog? log)
        {
            var (accuracy, resist) = GetAccuracies(attacker, defender, info);
            var temp = accuracy - resist;
            var result = Math.Clamp(temp / ((info.Attacker.Lv * Hit.ParameterA) + Math.Max(temp + (info.Defender.Lv - info.Attacker.Lv) * Hit.ParameterB, 0)), Hit.Min, Hit.Max);
            var rate = GetRate();

            log?.SetAccuracy(accuracy, result, rate);
            return result < rate;
        }

        // 피격자 기준 연산 1
        private static bool IsEvasion(StatComponent defender, in AttackInfo info, AttackLog? log)
        {
            var evasion = GetEvasion(defender, info);
            var value = evasion / ((info.Defender.Lv * Evasion.ParameterA) + Math.Max(evasion + (info.Attacker.Lv - info.Defender.Lv) * Evasion.ParameterB, 0));
            var result = Math.Clamp(value, Evasion.Min, Evasion.Max);
            var rate = GetRate();

            log?.SetDodge(evasion, result, rate);
            return result > rate;
        }

        // 피격자 기준 연산 2
        private static bool IsBlock(StatComponent defender, in AttackInfo info, AttackLog? log)
        {
            var block = GetBlock(defender, info);
            var result = Math.Clamp(block + LevelCorrection(info, Block.ParameterA, Block.ParameterB), Block.Min, Block.Max);
            var rate = GetRate();

            log?.SetBlock(block, result, rate);
            return result > rate;
        }

        // 공격자 기준 연산 2
        private static bool IsCritical(StatComponent attacker, StatComponent defender, in AttackInfo info, AttackLog? log)
        {
            var (critical, resist) = GetCritical(attacker, defender, info);
            var result = Math.Clamp(critical - (resist - LevelCorrection(info, Critical.ParameterA, Critical.ParameterB)) + info.CriticalRate, Critical.Min, Critical.Max);
            var rate = GetRate();

            log?.SetCritial(critical, result, rate);
            return result > rate;
        }

        // 공-수 간 각 오브젝트의 레벨에 따라 보정수치가 들어간다.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float LevelCorrection(in AttackInfo info, float paramA, float paramB)
        {
            var attackerLv = info.Attacker.Lv;
            var defenderLv = info.Defender.Lv;
            var value = (attackerLv - defenderLv) * paramA;
            return attackerLv >= defenderLv ? Math.Min(value, paramB) : Math.Max(value, paramB * -1);
        }

        private static float GetRate()
            => (float)(_random.Value.NextDouble());

        // Hp, Mp, 1차스텟 비례 데미지 때문에 데미지에 사용되는 스텟을 이용해 가져온다.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static double GetDamage(StatComponent attacker, in AttackInfo info)
        {
            var damage = attacker.GetStat(info.Stat);
            damage += attacker.GetAttack();
            return info.IsPvp ? damage + attacker.GetAttackPvp() : damage;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static double GetDefense(StatComponent defender, in AttackInfo info)
        {
            if (info.PassDefense)
                return 0;

            var defense = info.IsPhysical ? defender.GetPhysicalDefense() : defender.GetMagicDefense();
            defense += defender.GetDefense();
            return info.IsPvp ? defense + defender.GetDefensePvp() : defense;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static (double accuracy, double resist) GetAccuracies(StatComponent attacker, StatComponent defender, in AttackInfo info)
        {
            var (accuracy, resist) = info.IsPhysical ?
                (attacker.GetPhysicalAccuracy(), defender.GetPhysicalAccuracyResistance()) :
                (attacker.GetMagicAccuracy(), defender.GetMagicAccuracyResistance());

            accuracy += attacker.GetAccuracy();
            resist += defender.GetAccuracyResistance();

            if (info.IsPvp)
            {
                accuracy += attacker.GetAccuracyPvp();
                resist = defender.GetPvpAccuracyResistance();
            }

            return (accuracy, resist);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static double GetEvasion(StatComponent defender, in AttackInfo info)
        {
            var evasion = info.IsPhysical ? defender.GetPhysicalEvasion() : defender.GetMagicEvasion();
            evasion += defender.GetEvasion();

            if (info.IsPvp)
                evasion += defender.GetPvpEvasion();

            return evasion;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static double GetBlock(StatComponent defender, in AttackInfo info)
        {
            var block = defender.GetBlockRate();

            if (info.IsPvp)
                block += defender.GetPvpBlockRate();

            return block;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static (double critical, double resist) GetCritical(StatComponent attacker, StatComponent defender, in AttackInfo info)
        {
            var (critical, resist) = info.IsPhysical ?
                (attacker.GetPhysicalCriticalHitRate(), defender.GetPhysicalCriticalResistanceRate()) :
                (attacker.GetMagicCriticalHitRate(), defender.GetMagicCriticalResistanceRate());

            if (info.IsPvp)
            {
                critical += attacker.GetPvpCriticalHitRate();
                resist += defender.GetPvpCriticalResistanceRate();
            }

            return (critical, resist);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static (double penetration, double resist) GetPenetrasion(StatComponent attacker, StatComponent defender, in AttackInfo info)
        {
            return info.IsPhysical ?
                (attacker.GetPhysicalPenetrate(), defender.GetPhysicalPenetrateResistance()) :
                (attacker.GetMagicPenetrate(), defender.GetMagicPenetrateResistance());
        }
    }
}

#nullable restore