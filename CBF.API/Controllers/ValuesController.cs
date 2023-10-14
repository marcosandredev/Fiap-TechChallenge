using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CBF.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello World!");
    }
}
