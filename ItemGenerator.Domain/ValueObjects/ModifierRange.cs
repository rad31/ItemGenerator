using ItemGenerator.Domain.Enumerations;

namespace ItemGenerator.Domain.ValueObjects;

public sealed class ModifierRange2
{
    public ModifierRange2(
        ModifierType modifierType,
        ushort[] minValues,
        ushort[] maxValues)
    {
        ModifierType = modifierType;
        MinValues = minValues;
        MaxValues = maxValues;
    }
    public readonly ModifierType ModifierType;
    public readonly ushort[] MinValues;
    public readonly ushort[] MaxValues;
}