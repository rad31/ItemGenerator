using ErrorOr;
using ItemGenerator.Domain.Enumerations;
using ItemGenerator.Domain.Entities;
using MediatR;

namespace ItemGenerator.Application.ItemGeneration.Queries.GenerateItem;

public record GenerateItemQuery(ItemType? ItemType, Rarity? Rarity, byte Level)
    : IRequest<ErrorOr<Item>>;