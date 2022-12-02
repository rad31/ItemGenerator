

using ItemGenerator.Domain.Enumerations;
using ItemGenerator.Domain.ValueObjects;

namespace ItemGenerator.Contracts.Item;

public sealed class ItemResponse
{
    public readonly Guid Id;
    public readonly string Name;
    public readonly string Rarity;
    public readonly List<Affix> Affixes;
    public readonly List<string> ItemText;
    public ItemResponse(
        string name,
        string rarity,
        List<Affix> affixes)
    {
        Id = Guid.NewGuid();
        Name = name;
        Rarity = rarity;
        Affixes = affixes;
        ItemText = new();

        var uniqueAffixes = new Dictionary<AffixClass, ushort>();

        foreach (var affix in affixes)
        {
            // Affix.AddText(affix.AffixClass, ItemText);
        }
    }
}