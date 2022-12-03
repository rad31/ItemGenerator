using System.Linq;
using ItemGenerator.Domain.Enumerations;
using ItemGenerator.Domain.ValueObjects;

namespace ItemGenerator.Domain.Entities;

public sealed class Item
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public Rarity Rarity { get; init; }
    public DateTime CreateDate { get; init; }
    public List<Affix> Affixes { get; init; }

    public Item(
        string name,
        Rarity rarity,
        DateTime createDate,
        List<Affix> affixes)
    {
        Id = Guid.NewGuid();
        Name = name;
        Rarity = rarity ?? Rarity.Normal;
        CreateDate = createDate;
        Affixes = affixes;
    }
}