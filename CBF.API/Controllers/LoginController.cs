using CBF.Domain.DTOs;
using CBF.Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CBF.API.Controllers
{
    [Route("api/[login]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        private readonly ITokenService _tokenService;

        public LoginController(IUsuarioService usuarioRepository, ITokenService tokenService)
        {
            _usuarioService = usuarioRepository;
            _tokenService = tokenService;
        }

        [HttpPost("GerarToken")]
        public IActionResult GerarToken([FromBody] LoginDTO loginDTO)
        {
            try
            {
                var usuario = _usuarioService.GetUsuarioLoginESenha(loginDTO.Login, loginDTO.Senha);

                if (usuario == null)
                    return NotFound("Usuário ou senha inválidos");

                var token = _tokenService.GetToken(usuario);

                usuario.Senha = null;

                return Ok(new
                {
                    Usuario = usuario,
                    token = token,
                });
            }
            catch (ApplicationException e)
            {

                return BadRequest(e.Message);
             
            }
         


        }
    }
}
