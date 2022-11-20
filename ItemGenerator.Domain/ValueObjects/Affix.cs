using ItemGenerator.Domain.Enumerations;

namespace ItemGenerator.Domain.ValueObjects;

public sealed class Affix
{
    public readonly AffixClass AffixClass;
    public readonly List<Modifier> Modifiers;

    private Affix(
        AffixClass affixClass,
        List<Modifier> modifiers)
    {
        AffixClass = affixClass;
        Modifiers = modifiers;
    }

    public static Affix FromRange(AffixRange affixRange)
    {
        return new Affix(
            affixRange.AffixClass,
            affixRange.Modifiers.Select(m => Modifier.FromRange(m)).ToList());
    }
}