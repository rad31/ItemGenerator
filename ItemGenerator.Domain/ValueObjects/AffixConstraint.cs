using ItemGenerator.Domain.Enumerations;

namespace ItemGenerator.Domain.ValueObjects;

public sealed class AffixConstraints
{
    private readonly ulong _data;
    private const byte levelSize = 8;
    private const byte raritySize = 8;
    private const byte affixTypeSize = 1;
    private const byte rarityBitShift = levelSize;
    private const byte affixTypeBitShift = rarityBitShift + raritySize;
    private const byte itemTypeBitShift = affixTypeBitShift + affixTypeSize;

    public AffixConstraints(AffixType affixType, Rarity rarity, byte level, params ItemType[] itemTypes)
    {
        _data = level;
        _data |= (ulong)rarity.Value << rarityBitShift;
        _data |= (ulong)affixType.Value << affixTypeBitShift;

        foreach (var itemType in itemTypes)
        {
            _data |= itemType.BitMask << itemTypeBitShift;
        }
    }

    public ulong BitMask { get => _data >> affixTypeBitShift; }
    public byte Rarity { get => (byte)(_data >> rarityBitShift); }
    public byte Level { get => (byte)_data; }

    public bool IsApplicable(AffixType affixType, Rarity rarity, byte level, ItemType type)
    {
        var bitMask = affixType.Value | (type.BitMask << affixTypeSize);

        return (BitMask & bitMask) == bitMask &&
            Rarity == rarity.Value &&
            Level <= level;
    }
}