using ItemGenerator.Domain.Common;

namespace ItemGenerator.Domain.Enumerations;

public sealed class Rarity : Enumeration<Rarity>
{
    private Rarity(byte value, string name) : base(value, name) { }
    public static readonly Rarity Normal = new(0, "Normal");
    public static readonly Rarity Magic = new(1, "Magic");
    public static readonly Rarity Rare = new(2, "Rare");
    public static readonly Rarity Set = new(3, "Set");
    public static readonly Rarity Unique = new(4, "Unique");
}