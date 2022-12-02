using ItemGenerator.Domain.Enumerations;

namespace ItemGenerator.Domain.ValueObjects;

public sealed class Modifier
{
    private static readonly Random _random = new();
    public readonly ModifierType ModifierType;
    public readonly ushort[] Values;

    public Modifier(
        ModifierType modifierType,
        ushort[] values)
    {
        ModifierType = modifierType;
        Values = values;
    }

    public static Modifier FromRange(ModifierRange2 range)
    {
        var values = range.MinValues
            .Zip(range.MaxValues, (min, max) => (ushort)_random.NextInt64(min, max + 1))
            .ToArray();

        return new Modifier(
            range.ModifierType,
            values);
    }
}