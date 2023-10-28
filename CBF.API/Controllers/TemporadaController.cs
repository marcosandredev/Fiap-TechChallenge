using CBF.Domain.DTOs.Request;
using CBF.Service.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CBF.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TemporadaController : ControllerBase
{
    private readonly ITemporadaService _temporadaService;

    public TemporadaController(ITemporadaService temporadaService)
    {
        _temporadaService = temporadaService;
    }

    [HttpPost]
    [Authorize(Roles = "Administrador")]
    public async Task<IActionResult> Create([FromBody] TemporadaRequest request)
    {
        var response = await _temporadaService.CreateAsync(request);

        return Ok(response);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "Administrador")]
    public async Task<IActionResult> Update([FromRoute] long id, [FromBody] TemporadaRequest request)
    {
        var response = await _temporadaService.UpdateAsync(id, request);

        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await _temporadaService.GetAllAsync();

        return Ok(response);
    }
}
