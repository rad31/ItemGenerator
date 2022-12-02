using ItemGenerator.Domain.Entities;
using ItemGenerator.Contracts.Item;
using Mapster;

namespace ItemGenerator.Api.Common.Mapping;

public sealed class ItemMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Item, ItemResponse>();
    }
}