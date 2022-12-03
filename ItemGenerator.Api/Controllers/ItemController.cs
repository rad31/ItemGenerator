using ItemGenerator.Application.ItemGeneration.Queries.GenerateItem;
using ItemGenerator.Contracts.Item;
using ItemGenerator.Domain.Enumerations;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ItemGenerator.Api.Controllers;

[Route("item")]
public sealed class ItemController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;
    public ItemController(
        ISender sender,
        IMapper mapper)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpGet("{type}/{rarity}/{level}")]
    [AllowAnonymous]
    public async Task<IActionResult> GenerateItem(
        [FromRoute]string type,
        [FromRoute]string rarity,
        [FromRoute]string level)
    {
        var itemType = ItemType.FromName(type);
        var itemRarity = Rarity.FromName(rarity);
        var itemLevel = byte.TryParse(level, out var i) ? i : (byte)100;

        var query = new GenerateItemQuery(itemType, itemRarity, itemLevel);

        var result = await _sender.Send(query);

        return result.Match(
            item => Ok(_mapper.Map<ItemResponse>(item).ItemText),
            errors => Problem(errors));
    }
}