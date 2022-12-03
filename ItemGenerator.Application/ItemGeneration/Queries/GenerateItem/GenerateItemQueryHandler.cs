using ErrorOr;
using ItemGenerator.Application.Common.Interfaces.Services;
using ItemGenerator.Domain.Entities;
using ItemGenerator.Domain.Enumerations;
using ItemGenerator.Domain.ValueObjects;
using MediatR;

namespace ItemGenerator.Application.ItemGeneration.Queries.GenerateItem;

public sealed class GenerateItemQueryHandler
    : IRequestHandler<GenerateItemQuery, ErrorOr<Item>>
{
    private static readonly Random _random = new();
    private readonly IDateTimeProvider _dateTimeProvider;

    public GenerateItemQueryHandler(IDateTimeProvider dateTimeProvider)
    {
        _dateTimeProvider = dateTimeProvider;
    }
    public async Task<ErrorOr<Item>> Handle(
        GenerateItemQuery query,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        var numPrefixes = (int)_random.NextInt64(2, 3);
        var numSuffixes = (int)_random.NextInt64(2, 3);

        var affixes = GenerateAffixes(query, AffixType.Prefix, numPrefixes);
        affixes.AddRange(GenerateAffixes(query, AffixType.Suffix, numSuffixes));

        return new Item(
            "Item name",
            query.Rarity!,
            _dateTimeProvider.UtcNow,
            affixes);
    }

    private static List<Affix> GenerateAffixes(
        GenerateItemQuery query,
        AffixType affixType,
        int numAffixes)
    {
        List<Affix> affixes = new();

        var affixRanges = AffixRange.Enumerations(e => e.Constraints.IsApplicable(
            affixType,
            query.Rarity!,
            query.Level,
            query.ItemType!));

        for (var i = 0; i < numAffixes; i++)
        {
            var index = (int)_random.NextInt64(0, affixRanges.Count);
            var affixRange = affixRanges[index];

            while (affixes.Any(p => p.AffixClass == affixRange.AffixClass))
            {
                index = (int)_random.NextInt64(0, affixRanges.Count);
                affixRange = affixRanges[index];
            }

            affixes.Add(Affix.FromRange(affixRange));
        }

        return affixes;
    }
}