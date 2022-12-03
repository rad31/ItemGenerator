using ItemGenerator.Domain.ValueObjects;
using ItemGenerator.Domain.Enumerations;
using static ItemGenerator.Domain.Enumerations.ModifierType;

namespace ItemGenerator.Domain.Common;

public class ModifierReader
{
    private const string _basedOnCharacterLevel = "(Based on Character Level)";

    public static List<string> GetText(List<Modifier> modifiers)
    {
        List<string> text = new();

        foreach (var modifier in modifiers)
        {
            AddText(text, modifier);
        }

        return text;
    }

    private static void AddText(List<string> text, Modifier modifier)
    {
        switch (modifier.ModifierType)
        {
            case AddSockets:
                text.Add(modifier.Values[0] == 1
                    ? $"Adds {modifier.Values[0]} socket"
                    : $"Adds {modifier.Values[0]} sockets");
                break;
            case AttackRating:
                text.Add($"+{modifier.Values[0]} to Attack Rating");
                break;
            case AttackRatingBasedOnCharacterLevel:
                text.Add($"{modifier.Values[0] / 100} Attack Rating {_basedOnCharacterLevel}");
                break;
            case AttackRatingPercentBasedOnCharacterLevel:
                text.Add($"{modifier.Values[0]}% Bonus to Attack Rating {_basedOnCharacterLevel}");
                break;
            case AttackRatingVsDemons:
                text.Add($"+{modifier.Values[0]} to Attack Rating vs Demons");
                break;
            case AttackRatingVsUndead:
                text.Add($"+{modifier.Values[0]} to Attack Rating vs Undead");
                break;
            case AttackSpeed:
                text.Add($"{modifier.Values[0]}% Increased Attack Speed");
                break;
            case CauseMonsterFlee:
                text.Add($"Hit Causes Monster to Flee {modifier.Values[0]}%");
                break;
            case BlockRate:
                text.Add($"{modifier.Values[0]}% Faster Block Rate");
                break;
            case BlockChance:
                text.Add($"{modifier.Values[0]}% Increased Chance of Blocking");
                break;
            case CastRate:
                text.Add($"{modifier.Values[0]}% Faster Cast Rate");
                break;
            case DamageEnhanced:
                text.Add($"{modifier.Values[0]}% Enhanced Damage");
                break;
            case DamageEnhancedVsDemons:
                text.Add($"+{modifier.Values[0]}% Damage to Demons");
                break;
            case DamageEnhancedVsUndead:
                text.Add($"+{modifier.Values[0]}% Damage to Undead");
                break;
            case DamageCold:
                AddDamageText(text, modifier.Values[0], modifier.Values[1], "Cold Damage");
                break;
            case DamageFire:
                AddDamageText(text, modifier.Values[0], modifier.Values[1], "Fire Damage");
                break;
            case DamageLightning:
                AddDamageText(text, modifier.Values[0], modifier.Values[1], "Lightning Damage");
                break;
            case DamageMagicReduced:
                text.Add($"Magic Damage Reduced by {modifier.Values[0]}");
                break;
            case DamagePoison:
                text.Add($"Adds {modifier.Values[0]} Poison Damage Over {modifier.Values[1]} Seconds");
                break;
            case DamagePhysical:
                AddDamageText(text, modifier.Values[0], modifier.Values[1], "Damage");
                break;
            case DamageReduced:
                text.Add($"Damage Reduced by {modifier.Values[0]}");
                break;
            case DamageReflect:
                text.Add($"Attack Takes Damage of {modifier.Values[0]}");
                break;
            case DamagePhysicalBasedOnCharacterLevel:
                AddDamageText(
                    text,
                    modifier.Values[0] / 100,
                    modifier.Values[1] / 100,
                    $"Damage {_basedOnCharacterLevel}");
                break;
            case DamageTakenGoesToMana:
                text.Add($"{modifier.Values[0]}% Damage Taken Goes to Mana");
                break;
            case Defense:
                text.Add($"+{modifier.Values[0]} to Defense");
                break;
            case DefenseBasedOnCharacterLevel:
                text.Add($"+{modifier.Values[0]} to Defense {_basedOnCharacterLevel}");
                break;
            case DefenseEnhanced:
                text.Add($"{modifier.Values[0]}% Enhanced Defense");
                break;
            case Dexterity:
                text.Add($"+{modifier.Values[0]} to Dexterity");
                break;
            case Energy:
                text.Add($"+{modifier.Values[0]} to Energy");
                break;
            case FreezeDuration:
                text.Add($"Half Freeze Duration");
                break;
            case GoldFind:
                text.Add($"{modifier.Values[0]}% Extra Gold from Monsters");
                break;
            case HitRecovery:
                text.Add($"{modifier.Values[0]}% Faster Hit Recovery");
                break;
            case IgnoreTargetDefense:
                text.Add($"Ignores Target's Defense");
                break;
            case IncreasedStackSize:
                text.Add($"Increased Stack Size +{modifier.Values[0]}");
                break;
            case Indestructable:
                text.Add($"Indestructable");
                break;
            case Knockback:
                text.Add($"Knockback");
                break;
            case Life:
                text.Add($"+{modifier.Values[0]} to Life");
                break;
            case LifeBasedOnCharacterLevel:
                text.Add($"+{modifier.Values[0] / 100} to Life {_basedOnCharacterLevel}");
                break;
            case LifeLeech:
                text.Add($"{modifier.Values[0]}% Life Stolen per Hit");
                break;
            case LifeRegeneration:
                text.Add($"Replenish Life +{modifier.Values[0]}");
                break;
            case LightRadius:
                text.Add($"+{modifier.Values[0]} to Light Radius");
                break;
            case MagicFind:
                text.Add($"{modifier.Values[0]}% Better Chance of Getting Magic Items");
                break;
            case Mana:
                text.Add($"+{modifier.Values[0]} to Mana");
                break;
            case ManaBasedOnCharacterLevel:
                text.Add($"{modifier.Values[0]} to Mana {_basedOnCharacterLevel}");
                break;
            case ManaLeech:
                text.Add($"{modifier.Values[0]}% Mana Stolen per Hit");
                break;
            case ManaOnKill:
                text.Add($"+{modifier.Values[0]} Mana After Each Kill");
                break;
            case PoisonLengthReduced:
                text.Add($"Poison Length Reduced by {modifier.Values[0]}%");
                break;
            case PreventMonsterHeal:
                text.Add($"Prevents Monster Heal");
                break;
            case QuantityReplish:
                text.Add($"Replenishes {modifier.Values[0]} Quantity Every {modifier.Values[1]} Seconds");
                break;
            case RequirementReduction:
                text.Add($"Requirements -{modifier.Values[0]}%");
                break;
            case ResistAll:
                AddResistText(text, modifier.Values[0], modifier.Values[1], modifier.Values[2], modifier.Values[3]);
                break;
            case RunWalkSpeed:
                text.Add($"{modifier.Values[0]}% Faster Run/Walk");
                break;
            case SelfRepair:
                text.Add($"Repairs {modifier.Values[0]} Durability Every {modifier.Values[1]} Seconds");
                break;
            case Skills:
                text.Add($"+{modifier.Values[0]} to {Skill.FromValue(modifier.Values[1])!.Name}");
                break;
            case SpellCharges:
                text.Add($"Level {modifier.Values[0]} {Spell.FromValue(modifier.Values[1])!.Name} ({modifier.Values[2]}/{modifier.Values[2]} Charges)");
                break;
            case SpellProc:
                text.Add($"{modifier.Values[0]}% Chance to Cast Level {modifier.Values[1]} {Spell.FromValue(modifier.Values[2])!.Name} on {ProcType.FromValue(modifier.Values[3])!.Name}");
                break;
            case Stamina:
                text.Add($"+{modifier.Values[0]} to Maximum Stamina");
                break;
            case StaminaRegeneration:
                text.Add($"{modifier.Values[0]}% Slower Stamina Drain");
                break;
            case StaminaDrain:
                text.Add($"");
                break;
            case Strength:
                text.Add($"+{modifier.Values[0]} to Strength");
                break;
            case Vitality:
                text.Add($"+{modifier.Values[0]} to Vitality");
                break;
        };
    }

    private static void AddDamageText(List<string> text, int min, int max, string damageType)
    {
        if (min == max)
            text.Add($"Adds {min} {damageType}");
        else if (min == 0)
            text.Add($"+{max} to Maximum {damageType}");
        else if (max == 0)
            text.Add($"+{min} to Minimum {damageType}");
        else
            text.Add($"Adds {min}-{max} {damageType}");
    }

    private static void AddResistText(List<string> text, int cold, int fire, int lightning, int poison)
    {
        if (cold == fire && cold == lightning && cold == poison)
        {
            text.Add($"All Resistances +{cold}%");
            return;
        }

        if (cold > 0)
            text.Add($"+{cold}% to Cold Resistance");

        if (fire > 0)
            text.Add($"+{fire}% to Fire Resistance");

        if (lightning > 0)
            text.Add($"+{lightning}% to Lightning Resistance");

        if (poison > 0)
            text.Add($"+{poison}% to Poison Resistance");
    }
}