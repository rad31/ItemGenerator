using ItemGenerator.Domain.Enumerations;

namespace ItemGenerator.Domain.ValueObjects;

public sealed class ModifierRange
{
    public ModifierRange(
        ModifierType modifierType,
        ushort minValue,
        ushort maxValue)
    {
        ModifierType = modifierType;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public readonly ModifierType ModifierType;
    public readonly ushort MinValue;
    public readonly ushort MaxValue;
}