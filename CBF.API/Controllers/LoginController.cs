using CBF.Domain.DTOs;
using CBF.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CBF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ITokenService _tokenService;

        public LoginController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("GerarToken")]
        public async Task<IActionResult> GerarToken([FromBody] LoginDTO loginDTO)
        {
            var token = await _tokenService.GerarToken(loginDTO);

            return Ok(token);
        }
    }
}
