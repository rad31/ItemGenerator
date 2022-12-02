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
    public static readonly AffixClass BlockChance = new(12, "BlockChance", false);
    public static readonly AffixClass BlockRate = new(13, "BlockRate", false);
    public static readonly AffixClass BlockRateAndChance = new(14, "BlockRateAndChance", true);
    public static readonly AffixClass CauseMonsterFlee = new(15, "CauseMonsterFlee", false);
    public static readonly AffixClass CastRate = new(16, "CastRate", false);
    public static readonly AffixClass DamageCold = new(17, "DamageCold", false);
    public static readonly AffixClass DamageEnhanced = new(18, "DamageEnhanced", false);
    public static readonly AffixClass DamageEnhancedVsDemons = new(19, "DamageEnhancedVsDemons", false);
    public static readonly AffixClass DamageEnhancedVsUndead = new(20, "DamageEnhancedVsUndead", false);
    public static readonly AffixClass DamageFire = new(21, "DamageFire", false);
    public static readonly AffixClass DamageLightning = new(22, "DamageLightning", false);
    public static readonly AffixClass DamageMagicReduced = new(23, "DamageMagicReduced", false);
    public static readonly AffixClass DamagePhysical = new(24, "DamagePhysical", false);
    public static readonly AffixClass DamagePhysicalMaxBasedOnCharacterLevel = new(25, "DamagePhysicalMaxBasedOnCharacterLevel", false);
    public static readonly AffixClass DamagePoison = new(26, "DamagePoison", false);
    public static readonly AffixClass DamageReduced = new(27, "DamageReduced", false);
    public static readonly AffixClass DamageReflect = new(28, "DamageReflect", false);
    public static readonly AffixClass DamageTakenGoesToMana = new(29, "DamageTakenGoesToMana", false);
    public static readonly AffixClass Defense = new(30, "Defense", false);
    public static readonly AffixClass DefenseBasedOnCharacterLevel = new(31, "DefenseBasedOnCharacterLevel", false);
    public static readonly AffixClass DefenseEnhanced = new(32, "DefenseEnhanced", false);
    public static readonly AffixClass Dexterity = new(33, "Dexterity", false);
    public static readonly AffixClass Energy = new(34, "Energy", false);
    public static readonly AffixClass FreezeDuration = new(35, "FreezeDuration", false);
    public static readonly AffixClass GoldFind = new(36, "GoldFind", false);
    public static readonly AffixClass HitRecovery = new(37, "HitRecovery", false);
    public static readonly AffixClass IgnoreTargetDefense = new(38, "IgnoreTargetDefense", false);
    public static readonly AffixClass IncreasedStackSize = new(39, "IncreasedStackSize", false);
    public static readonly AffixClass Indestructable = new(40, "Indestructable", false);
    public static readonly AffixClass Knockback = new(41, "Knockback", false);
    public static readonly AffixClass Life = new(42, "Life", false);
    public static readonly AffixClass LifeBasedOnCharacterLevel = new(43, "LifeBasedOnCharacterLevel", false);
    public static readonly AffixClass LifeLeech = new(44, "LifeLeech", false);
    public static readonly AffixClass LightRadius = new(45, "LightRadius", false);
    public static readonly AffixClass LightRadiusAndAttackRating = new(46, "LightRadiusAndAttackRating", true);
    public static readonly AffixClass LifeRegeneration = new(47, "LifeRegeneration", false);
    public static readonly AffixClass MagicFind = new(48, "MagicFind", false);
    public static readonly AffixClass Mana = new(49, "Mana", false);
    public static readonly AffixClass ManaBasedOnCharacterLevel = new(50, "ManaBasedOnCharacterLevel", false);
    public static readonly AffixClass ManaLeech = new(51, "ManaLeech", false);
    public static readonly AffixClass ManaOnKill = new(52, "ManaOnKill", false);
    public static readonly AffixClass PoisonLengthReduced = new(53, "PoisonLengthReduced", false);
    public static readonly AffixClass PreventMonsterHeal = new(54, "PreventMonsterHeal", false);
    public static readonly AffixClass QuantityReplish = new(55, "QuantityReplish", false);
    public static readonly AffixClass QuantityIncreased = new(56, "QuantityIncreased", false);
    public static readonly AffixClass RequirementReduction = new(57, "RequirementReduction", false);
    public static readonly AffixClass ResistAll = new(58, "ResistAll", false);
    public static readonly AffixClass ResistCold = new(59, "ResistCold", false);
    public static readonly AffixClass ResistFire = new(60, "ResistFire", false);
    public static readonly AffixClass ResistLightning = new(61, "ResistLightning", false);
    public static readonly AffixClass ResistPoison = new(62, "ResistPoison", false);
    public static readonly AffixClass RunWalkSpeed = new(63, "RunWalkSpeed", false);
    public static readonly AffixClass RunWalkSpeedAndStaminaDrain = new(64, "RunWalkSpeedAndStaminaDrain", true);
    public static readonly AffixClass SelfRepair = new(65, "SelfRepair", false);
    public static readonly AffixClass Skills = new(66, "Skills", false);
    public static readonly AffixClass SpellCharge = new(67, "SpellCharge", false);
    public static readonly AffixClass SpellProc = new(68, "SpellProc", false);
    public static readonly AffixClass Stamina = new(69, "Stamina", false);
    public static readonly AffixClass StaminaDrain = new(70, "StaminaDrain", false);
    public static readonly AffixClass StaminaRegeneration = new(71, "StaminaRegeneration", false);
    public static readonly AffixClass Strength = new(72, "Strength", false);
    public static readonly AffixClass Vitality = new(73, "Vitality", false);
}
