using ItemGenerator.Domain.Enumerations;

namespace ItemGenerator.Domain.ValueObjects;

public sealed class ModifierRange
{
    public ModifierType ModifierType { get; init; }
    public ushort[] MinValues { get; init; }
    public ushort[] MaxValues { get; init; }

    public ModifierRange(
        ModifierType modifierType,
        ushort[] minValues,
        ushort[] maxValues)
    {
        ModifierType = modifierType;
        MinValues = minValues;
        MaxValues = maxValues;
    }
}