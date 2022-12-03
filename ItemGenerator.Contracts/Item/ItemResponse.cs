using ItemGenerator.Domain.Common;
using ItemGenerator.Domain.ValueObjects;
using ItemGenerator.Domain.Enumerations;

namespace ItemGenerator.Contracts.Item;

public sealed class ItemResponse
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Rarity { get; init; }
    public List<Affix> Affixes { get; init; }
    public List<string> ItemText { get; init; }
    public ItemResponse(
        string name,
        Rarity rarity,
        List<Affix> affixes)
    {
        Id = Guid.NewGuid();
        Name = name;
        Rarity = rarity.Name;
        Affixes = affixes;

        var modifiers = Affix.CombineModifiers(affixes);

        ItemText = ModifierReader.GetText(modifiers);
    }
}