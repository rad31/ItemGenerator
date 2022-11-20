using FluentValidation;

namespace ItemGenerator.Application.ItemGeneration.Queries.GenerateItem;

public sealed class GenerateItemQueryValidator : AbstractValidator<GenerateItemQuery>
{
    public GenerateItemQueryValidator()
    {
        RuleFor(x => x.ItemType).NotNull().WithMessage("Invalid item type.");
        RuleFor(x => x.Rarity).NotNull().WithMessage("Invalid item rarity.");
        RuleFor(x => x.Level).GreaterThanOrEqualTo((byte)1);
        RuleFor(x => x.Level).LessThanOrEqualTo((byte)99);
    }
}