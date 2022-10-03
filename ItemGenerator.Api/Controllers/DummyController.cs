using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ItemGenerator.Api.Controllers;

public class DummyController : ApiController
{
    [HttpGet]
    [Route("check")]
    public IActionResult Check()
    {
        return Ok();
    }
}