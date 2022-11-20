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

        var prefixRanges = AffixRange.Enumerations(e => e.Constraints.IsApplicable(
            AffixType.Prefix,
            query.Rarity!,
            query.Level,
            query.ItemType!));

        var prefixes = new List<Affix>();

        for (var i = _random.NextInt64(0, 3); i >= 0; i--)
        {
            var index = (int)_random.NextInt64(0, prefixRanges.Count);
            var prefixRange = prefixRanges[index];

            while (prefixes.Any(p => p.AffixClass == prefixRange.AffixClass))
            {
                index = (int)_random.NextInt64(0, prefixRanges.Count);
                prefixRange = prefixRanges[index];
            }

            prefixes.Add(Affix.FromRange(prefixRange));
        }

        return new Item(
            "Item name",
            query.Rarity!,
            _dateTimeProvider.UtcNow,
            prefixes);
    }
}