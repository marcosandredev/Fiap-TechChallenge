using CBF.Domain.DTOs.Request;
using CBF.Service.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CBF.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService _usuarioService;

    public UsuarioController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] UsuarioRequest request)
    {
        var response = await _usuarioService.CreateAsync(request);

        return Ok(response);
    }

    [HttpGet("{id}")]
    [Authorize]
    public async Task<IActionResult> GetById([FromRoute] long id)
    {
        var response = await _usuarioService.GetByIdAsync(id);

        return Ok(response);
    }
}
