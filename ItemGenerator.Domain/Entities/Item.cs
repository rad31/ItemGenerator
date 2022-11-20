using System.Linq;
using ItemGenerator.Domain.Enumerations;
using ItemGenerator.Domain.ValueObjects;

namespace ItemGenerator.Domain.Entities;

public sealed class Item
{
    public readonly Guid Id;
    public readonly string Name;
    public readonly Rarity Rarity;
    public readonly DateTime CreateDate;
    public readonly List<Affix> Prefixes;

    public Item(
        string name,
        Rarity rarity,
        DateTime createDate,
        List<Affix> prefixes)
    {
        Id = Guid.NewGuid();
        Name = name;
        Rarity = rarity ?? Rarity.Normal;
        CreateDate = createDate;
        Prefixes = prefixes;
    }
}