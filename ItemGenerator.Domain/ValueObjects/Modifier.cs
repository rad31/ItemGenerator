using ItemGenerator.Domain.Enumerations;

namespace ItemGenerator.Domain.ValueObjects;

public sealed class Modifier
{
    private static readonly Random _random = new();
    public readonly ModifierType ModifierType;
    public readonly ushort Value;
    private Modifier(
        ModifierType modifierType,
        ushort value)
    {
        ModifierType = modifierType;
        Value = value;
    }

    public static Modifier FromRange(ModifierRange range)
    {
        return new Modifier(
            range.ModifierType,
            (ushort)_random.NextInt64(range.MinValue, range.MaxValue + 1));
    }
}