using ItemGenerator.Domain.Enumerations;

namespace ItemGenerator.Domain.ValueObjects;

public sealed class Modifier
{
    private static readonly Random _random = new();
    public ModifierType ModifierType { get; init; }
    public ushort[] Values { get; init; }

    public Modifier(
        ModifierType modifierType,
        ushort[] values)
    {
        ModifierType = modifierType;
        Values = values;
    }

    public static Modifier FromRange(ModifierRange range)
    {
        var values = range.MinValues
            .Zip(range.MaxValues, (min, max) => (ushort)_random.NextInt64(min, max + 1))
            .ToArray();

        return new Modifier(
            range.ModifierType,
            values);
    }

    public static Modifier FromRangeSingleValue(ModifierRange range) {
        var value = (ushort)_random.NextInt64(range.MinValues[0], range.MaxValues[0] + 1);
        var values = new ushort[] { value, value, value, value };

        return new Modifier(
            range.ModifierType,
            values);
    }
}