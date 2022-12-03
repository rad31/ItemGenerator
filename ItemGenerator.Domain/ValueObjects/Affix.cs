using ItemGenerator.Domain.Enumerations;
using static ItemGenerator.Domain.Enumerations.AffixClass;

namespace ItemGenerator.Domain.ValueObjects;

public sealed class Affix
{
    public AffixClass AffixClass { get; init; }
    public List<Modifier> Modifiers { get; init; }

    public Affix(
        AffixClass affixClass,
        List<Modifier> modifiers)
    {
        AffixClass = affixClass;
        Modifiers = modifiers;
    }

    public static Affix FromRange(AffixRange affixRange)
    {
        if (affixRange.AffixClass == ResistAll)
        {
            return new Affix(
                affixRange.AffixClass,
                affixRange.Modifiers.Select(m => Modifier.FromRangeSingleValue(m)).ToList());
        }

        return new Affix(
            affixRange.AffixClass,
            affixRange.Modifiers.Select(m => Modifier.FromRange(m)).ToList());
    }

    public static List<Modifier> CombineModifiers(List<Affix> affixes)
    {
        var modifiers = new List<Modifier>();

        foreach (var affix in affixes)
        {
            modifiers.Add(affix.Modifiers[0]);

            if (affix.AffixClass.IsCompound)
                modifiers.Add(affix.Modifiers[1]);
        }

        return modifiers
            .GroupBy(modifier => modifier.ModifierType)
            .Select(group => group.Aggregate((modifier1, Modifier) =>
                new Modifier(
                    group.Key,
                    modifier1.Values
                        .Zip(Modifier.Values, (v1, v2) => (ushort)(v1 + v2))
                        .ToArray())))
            .ToList();
    }
}