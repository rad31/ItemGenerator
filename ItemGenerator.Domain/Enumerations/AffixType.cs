using ItemGenerator.Domain.Common;

namespace ItemGenerator.Domain.Enumerations;

public sealed class AffixType : Enumeration<AffixType>
{
    private AffixType(byte value, string name) : base(value, name) { }
    public static readonly AffixType Prefix = new(0, "Prefix");
    public static readonly AffixType Suffix = new(1, "Suffix");
}