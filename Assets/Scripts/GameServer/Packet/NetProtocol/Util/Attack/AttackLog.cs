using NetProtocol.Packet;
using System.Text;

namespace NetProtocol
{
    public class AttackLog
    {
        private AttackJudgment AttackJudgment;
        private int Damage;
        private long HpDrain;
        private long MpDrain;
        private int Reflex;

        private readonly string AttackerName;
        private readonly string DefenderName;
        private readonly string AttackType;
        private readonly int AttackerLv = 0;
        private readonly int DefenderLv = 0;

        private double AttackerAccuracy = 0;
        private double DefenderDodge = 0;
        private double AttackerCritical = 0;
        private double DefenderCriticalResist = 0;
        private double AttackerPenetration = 0;
        private double DefenderPenetrationResist = 0;
        private double DefenderBlock = 0;
        private int AttackPower = 0;
        private int DefensePower = 0;
        private double DamageReflexPower = 0;

        private double AccuracyPer = 0;
        private double DodgePer = 0;
        private double BlockPer = 0;
        private double CriticalPer = 0;
        private double Penetrate = 0;
        private double DamageReflexPer = 0;

        private double AccuracyRate = 0;
        private double DodgeRate = 0;
        private double BlockRate = 0;
        private double CriticalRate = 0;
        private double DamageReflexRate = 0;

        private double CriticalDamageRate = 0;
        private double CriticalDamagePer = 0;
        private double CriticalDamageResistPer = 0;
        private double AdjustmentTotal = 0;
        private double AdjustmentPlus = 0;
        private double AdjustmentMinus = 0;

        private int Damage1st = 0;
        private int Damage2nd = 0;
        private int Damage3rd = 0;
        private int DamageFinal = 0;

        private uint SkillIndex = 0;
        private uint SkillLinkIndex = 0;
        private int SkillEffectType = 0;
        private uint ApplyProb = 0;
        private int ApplyRate = 0;
        private int ElementA = 0;
        private int ElementB = 0;
        private int ElementC = 0;
        private int ElementD = 0;
        private int ElementE = 0;

        internal AttackLog(in AttackInfo info)
        {
            AttackerName = info.Attacker.IsPlayer ? info.Attacker.Name : info.Attacker.Id.ToString();
            AttackerLv = info.Attacker.Lv;
            DefenderName = info.Defender.IsPlayer ? info.Defender.Name : info.Defender.Id.ToString();
            DefenderLv = info.Defender.Lv;
            AttackType = info.IsPhysical ? "Physical" : "Magical";
        }

        internal void SetAccuracy(double accuracy, double per, double rate)
            => (AttackJudgment, AttackerAccuracy, AccuracyPer, AccuracyRate)
            = (AttackJudgment.Miss, accuracy, per, rate);

        internal void SetDodge(double dodge, double per, double rate)
            => (AttackJudgment, DefenderDodge, DodgePer, DodgeRate)
            = (AttackJudgment.Dodge, dodge, per, rate);

        internal void SetBlock(double block, double per, double rate)
            => (AttackJudgment, DefenderBlock, BlockPer, BlockRate)
            = (AttackJudgment.Block, block, per, rate);

        internal void SetCritial(double critial, double per, double rate)
            => (AttackJudgment, AttackerCritical, CriticalPer, CriticalRate)
            = (AttackJudgment.Critical, critial, per, rate);

        internal void SetSkill(uint index, uint link, int type)
            => (SkillIndex, SkillLinkIndex, SkillEffectType) = (index, link, type);

        internal void SetSkillDetail(uint applyProb, int applyRate, int elementA, int elementB, int elementC, int elementD)
            => (ApplyProb, ApplyRate, ElementA, ElementB, ElementC, ElementD)
            = (applyProb, applyRate, elementA, elementB, elementC, elementD);


        internal void SetPenetration(double penetration, double resist, double value)
            => (AttackerPenetration, DefenderPenetrationResist, Penetrate)
            = (penetration, resist, value);

        internal void SetDamageCritical(double critical, double resist, double value)
            => (CriticalDamageRate, CriticalDamageResistPer, CriticalDamagePer)
            = (critical, resist, value);

        //미구현
        internal void SetDamageElemental() { }

        internal void SetDamageAdjustment(double adjustment, double increase, double decrease)
            => (AdjustmentTotal, AdjustmentPlus, AdjustmentMinus)
            = (adjustment, increase, decrease);


        internal void SetDrain(long hp, long mp)
            => (HpDrain, MpDrain) = (hp, mp);

        internal void SetReflex(int reflex, double per, double rate, double power)
            => (Reflex, DamageReflexPer, DamageReflexRate, DamageReflexPower)
            = (reflex, per, rate, power);

        internal void SetDamage(int v1, int v2, int value)
            => (Damage1st, Damage2nd, DamageFinal)
            = (v1, v2, value);

        //미구현
        internal void SetAbnormalConditions() { }

        internal string GetLog()
        {
            StringBuilder builder = new(1024);
            builder.AppendLine("=== Attack Result ===");
            builder.AppendLine($"Attacker:{AttackerName} | Defender:{DefenderName} | Skill Index:{SkillIndex} | SkillLink Index:{SkillLinkIndex} | Attack Type:{AttackType} | Attack Result:{AttackJudgment.ToString()} | " +
                $"SKILL_EFFECT_TYPE:{SkillEffectType.ToString()} | DAMAGE:{Damage} | Drain HP:{HpDrain} | Darin MP:{MpDrain} | Reflect Damage:{Reflex}");

            return builder.ToString();
        }
        internal string GetDetailLog()
        {
            StringBuilder builder = new(1024);
            builder.AppendLine("=== Detail ===");
            builder.AppendLine("1. Use Skill");
            builder.AppendLine($"[Attacker] | Skill Index:{SkillIndex} | SkillLink Index:{SkillLinkIndex}");
            builder.AppendLine("2. Hit Check");

            var r = AttackJudgment != AttackJudgment.Miss ? "TRUE" : "FALSE";

            builder.AppendLine($"[Attacker] | Level:{AttackerLv} | Accuracy:{AttackerAccuracy} | [Defender] | Level:{DefenderLv} | [Const] | HIT_RATE_PARAMETER_A:{DamageCalculator.Hit.ParameterA} | HIT_RATE_PARAMETER_B:{DamageCalculator.Hit.ParameterB} | " +
                $"MIN_HIT_RATE:{DamageCalculator.Hit.Min} | MAX_HIT_RATE:{DamageCalculator.Hit.Max} | [Hit Result] | Hit Rate:{AccuracyPer} | Random Number:{AccuracyRate} | Hit Result:{r}");
            builder.AppendLine("3. Dodge Check");

            var r2 = AttackJudgment == AttackJudgment.Dodge ? "TRUE" : "FALSE";

            builder.AppendLine($"[Attacker] | Level:{AttackerLv} | [Defender] | Level:{DefenderLv} | Dodge:{DefenderDodge} | [Const] | DODGE_PARAMETER_A:{DamageCalculator.Evasion.ParameterA} | DODGE_PARAMETER_B:{DamageCalculator.Evasion.ParameterB} | " +
                $"MIN_DODGE_RATE:{DamageCalculator.Evasion.Min} | MAX_DODGE_RATE:{DamageCalculator.Evasion.Max} | [Dodge Result] | Dodge Rate:{DodgePer} | Random Number:{DodgeRate} | Dodge Result:{r2}");

            builder.AppendLine("4. Block Check");

            var r3 = AttackJudgment == AttackJudgment.Block ? "TRUE" : "FALSE";

            builder.AppendLine($"[Attacker] | Level:{AttackerLv} | [Defender] | Level:{DefenderLv} | BlockProb:{DefenderBlock} | [Const] | BLOCK_RATE_PARAMETER_A:{DamageCalculator.Block.ParameterA} | BLOCK_RATE_PARAMETER_B:{DamageCalculator.Block.ParameterB} | " +
                $"MIN_BLOCK_RATE:{DamageCalculator.Block.Min} | MAX_BLOCK_RATE:{DamageCalculator.Block.Max} | [Block Result] | Block Rate:{BlockPer} | Random Number:{BlockRate} | Block Result:{r3}");

            builder.AppendLine("5. Critical Check");

            var r4 = AttackJudgment == AttackJudgment.Critical ? "TRUE" : "FALSE";

            builder.AppendLine($"[Attacker] | Level:{AttackerLv} | CriticalProb:{AttackerCritical} | [Defender] | Level:{DefenderLv} | CriticalResistProb:{DefenderCriticalResist} | [Const] | CRITICAL_RATE_PARAMETER_A:{DamageCalculator.Critical.ParameterA} | CRITICAL_RATE_PARAMETER_B:{DamageCalculator.Critical.ParameterB} | " +
                $"MIN_CRITICAL_RATE:{DamageCalculator.Critical.Min} | MAX_CRITICAL_RATE:{DamageCalculator.Critical.Max} | [Critical Result] | Critical Rate:{CriticalPer} | Random Number:{CriticalRate} | Critical Result:{r4}");

            builder.AppendLine("6. Effect Check");

            var r5 = (ApplyProb > ApplyRate) ? "TRUE" : "FALSE";

            builder.AppendLine($"[Attacker] | Level:{AttackerLv} | [Defender] | Level:{DefenderLv} | " +
                $"[Effect Result] | Effect ApplyProb:{ApplyProb} | Random Number:{ApplyRate} | Effect Result:{r5} ");

            builder.AppendLine("7. Damage - 1st");

            builder.AppendLine($"[Attacker] | Ap:{AttackPower} | Penetration:{AttackerPenetration} | Skill Effect Element | A:{ElementA} | B:{ElementB} | C:{ElementC} | D:{ElementD} | E:{ElementE} | [Defender] | Dp:{DefensePower} | PenetrationResist:{DefenderPenetrationResist} | " +
                $"[Const] | PENETRATE_MAX_REDUCE_RATE:{DamageCalculator.Penetrate.Max} | [Damage - 1st Result] | Penetrate:{Penetrate} | Damage:{Damage1st}");

            builder.AppendLine("8. Damage - 2nd");

            builder.AppendLine($"[Attacker] | CriticalDamage:{CriticalDamagePer} | [Defender] | CriticalDamageResist:{CriticalDamageResistPer} | " +
                $"[Damage - 2nd Result] | Damage-1st:{Damage1st} | Critical Damage Rate:{CriticalDamageRate} | Damage:{Damage2nd}");

            builder.AppendLine("9. Damage - 3rd");

            builder.AppendLine($"[Damage - 3rd Result] | Damage-2nd:{Damage2nd} | Damage:{Damage3rd}");

            builder.AppendLine("10. Damage - Final");

            builder.AppendLine($"[Attacker] | Total Damage Increase:{AdjustmentPlus} | [Defender] | Total Damage Decrease:{AdjustmentMinus} | " +
                $"[Damage - Final Result] | Damage-3rd:{Damage3rd} | Damage Modifier:{AdjustmentTotal} | Damage:{DamageFinal}");

            builder.AppendLine("11. HP/MP Absorb");

            builder.AppendLine($"[Attacker] | HP Drain:{HpDrain} | MP Drain:{MpDrain}  | " +
                $"[HP/MP Absorb] | Damage-Final:{DamageFinal} | HP Drain:{HpDrain} | MP Drain:{MpDrain}");

            builder.AppendLine("12. Damage Reflect");

            var r6 = Reflex > 0 ? "TRUE" : "FALSE";

            builder.AppendLine($"[Defender] | DamageReflexProb:{DamageReflexPer} | DamageReflexPower:{DamageReflexPower} | " +
                $"[Damage Reflect Result] | Damage Reflex Rate:{DamageReflexPer} | Random Number:{DamageReflexRate} | Damage Reflect Result:{r6} | Damage-Final:{DamageFinal} | Reflect Damage:{Reflex}");

            return builder.ToString();
        }
    }
}
