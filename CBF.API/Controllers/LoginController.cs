using CBF.Domain.DTOs;
using CBF.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CBF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public LoginController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("GerarToken")]
        public async Task<IActionResult> GerarToken([FromBody] LoginDTO loginDTO)
        {
            try
            {
                var token = await _usuarioService.GerarToken(loginDTO);

                if (token == null)
                    return NotFound();

                return Ok(token);
            }
            catch (ApplicationException e)
            {

                return BadRequest(e.Message);

            }
        }
    }
}
