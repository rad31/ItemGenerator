using ItemGenerator.Domain.Common;

namespace ItemGenerator.Domain.Enumerations;

public class AffixClass : Enumeration<AffixClass>
{
    public readonly bool IsCompound;
    private AffixClass(
       byte value,
       string name,
       bool isCompound)
       : base(value, name)
    {
        IsCompound = isCompound;
    }

    public static readonly AffixClass AddSockets = new(0, "AddSockets", false);
    public static readonly AffixClass AttackRating = new(1, "AttackRating", false);
    public static readonly AffixClass AttackRatingAndEnhancedDamage = new(2, "AttackRatingAndEnhancedDamage", true);
    public static readonly AffixClass AttackRatingAndMaxDamage = new(3, "AttackRatingAndMaxDamage", true);
    public static readonly AffixClass AttackRatingAndMaxDamageBasedOnCharacterLevel = new(4, "AttackRatingAndMaxDamageBasedOnCharacterLevel", true);
    public static readonly AffixClass AttackRatingBasedOnCharacterLevel = new(5, "AttackRatingBasedOnCharacterLevel", false);
    public static readonly AffixClass AttackRatingPercentBasedOnCharacterLevel = new(6, "AttackRatingPercentBasedOnCharacterLevel", false);
    public static readonly AffixClass AttackRatingAndEnhancedDamageVsDemons = new(7, "AttackRatingAndEnhancedDamageVsDemons", true);
    public static readonly AffixClass AttackRatingAndEnhancedDamageVsUndead = new(8, "AttackRatingAndEnhancedDamageVsUndead", true);
    public static readonly AffixClass AttackRatingVsDemons = new(9, "AttackRatingVsDemons", false);
    public static readonly AffixClass AttackRatingVsUndead = new(10, "AttackRatingVsUndead", false);
    public static readonly AffixClass AttackSpeed = new(11, "AttackSpeed", false);
    public static readonly AffixClass BlockRateAndChance = new(12, "BlockRateAndChance", true);
    public static readonly AffixClass CauseMonsterFlee = new(13, "CauseMonsterFlee", false);
    public static readonly AffixClass CastRate = new(14, "CastRate", false);
    public static readonly AffixClass DamageCold = new(15, "DamageCold", false);
    public static readonly AffixClass DamageEnhanced = new(16, "DamageEnhanced", false);
    public static readonly AffixClass DamageEnhancedVsDemons = new(17, "DamageEnhancedVsDemons", false);
    public static readonly AffixClass DamageEnhancedVsUndead = new(18, "DamageEnhancedVsUndead", false);
    public static readonly AffixClass DamageFire = new(19, "DamageFire", false);
    public static readonly AffixClass DamageLightning = new(20, "DamageLightning", false);
    public static readonly AffixClass DamageMagicReduced = new(21, "DamageMagicReduced", false);
    public static readonly AffixClass DamagePhysical = new(22, "DamagePhysical", false);
    public static readonly AffixClass DamagePhysicalMaxBasedOnCharacterLevel = new(23, "DamagePhysicalMaxBasedOnCharacterLevel", false);
    public static readonly AffixClass DamagePoison = new(24, "DamagePoison", false);
    public static readonly AffixClass DamageReduced = new(25, "DamageReduced", false);
    public static readonly AffixClass DamageReflect = new(26, "DamageReflect", false);
    public static readonly AffixClass DamageTakenGoesToMana = new(27, "DamageTakenGoesToMana", false);
    public static readonly AffixClass Defense = new(28, "Defense", false);
    public static readonly AffixClass DefenseBasedOnCharacterLevel = new(29, "DefenseBasedOnCharacterLevel", false);
    public static readonly AffixClass DefenseEnhanced = new(30, "DefenseEnhanced", false);
    public static readonly AffixClass Dexterity = new(31, "Dexterity", false);
    public static readonly AffixClass Energy = new(32, "Energy", false);
    public static readonly AffixClass FreezeDuration = new(33, "FreezeDuration", false);
    public static readonly AffixClass GoldFind = new(34, "GoldFind", false);
    public static readonly AffixClass HitRecovery = new(35, "HitRecovery", false);
    public static readonly AffixClass IgnoreTargetDefense = new(36, "IgnoreTargetDefense", false);
    public static readonly AffixClass IncreasedStackSize = new(37, "IncreasedStackSize", false);
    public static readonly AffixClass Indestructable = new(38, "Indestructable", false);
    public static readonly AffixClass Knockback = new(39, "Knockback", false);
    public static readonly AffixClass Life = new(40, "Life", false);
    public static readonly AffixClass LifeBasedOnCharacterLevel = new(41, "LifeBasedOnCharacterLevel", false);
    public static readonly AffixClass LifeLeech = new(42, "LifeLeech", false);
    public static readonly AffixClass LightRadius = new(43, "LightRadius", false);
    public static readonly AffixClass LightRadiusAndAttackRating = new(44, "LightRadiusAndAttackRating", true);
    public static readonly AffixClass LifeRegeneration = new(45, "LifeRegeneration", false);
    public static readonly AffixClass MagicFind = new(46, "MagicFind", false);
    public static readonly AffixClass Mana = new(47, "Mana", false);
    public static readonly AffixClass ManaBasedOnCharacterLevel = new(48, "ManaBasedOnCharacterLevel", false);
    public static readonly AffixClass ManaLeech = new(49, "ManaLeech", false);
    public static readonly AffixClass ManaOnKill = new(50, "ManaOnKill", false);
    public static readonly AffixClass PoisonLengthReduced = new(51, "PoisonLengthReduced", false);
    public static readonly AffixClass PreventMonsterHeal = new(52, "PreventMonsterHeal", false);
    public static readonly AffixClass QuantityReplish = new(53, "QuantityReplish", false);
    public static readonly AffixClass QuantityIncreased = new(54, "QuantityIncreased", false);
    public static readonly AffixClass RequirementReduction = new(55, "RequirementReduction", false);
    public static readonly AffixClass ResistAll = new(56, "ResistAll", false);
    public static readonly AffixClass ResistCold = new(57, "ResistCold", false);
    public static readonly AffixClass ResistFire = new(58, "ResistFire", false);
    public static readonly AffixClass ResistLightning = new(59, "ResistLightning", false);
    public static readonly AffixClass ResistPoison = new(60, "ResistPoison", false);
    public static readonly AffixClass RunWalkSpeed = new(61, "RunWalkSpeed", false);
    public static readonly AffixClass RunWalkSpeedAndStaminaDrain = new(62, "RunWalkSpeedAndStaminaDrain", true);
    public static readonly AffixClass SelfRepair = new(63, "SelfRepair", false);
    public static readonly AffixClass Skills = new(64, "Skills", false);
    public static readonly AffixClass SpellCharge = new(65, "SpellCharge", false);
    public static readonly AffixClass SpellProc = new(66, "SpellProc", false);
    public static readonly AffixClass Stamina = new(67, "Stamina", false);
    public static readonly AffixClass StaminaDrain = new(68, "StaminaDrain", false);
    public static readonly AffixClass StaminaRegeneration = new(69, "StaminaRegeneration", false);
    public static readonly AffixClass Strength = new(70, "Strength", false);
    public static readonly AffixClass Vitality = new(71, "Vitality", false);
}
