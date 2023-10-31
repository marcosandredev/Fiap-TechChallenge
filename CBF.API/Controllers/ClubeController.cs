using CBF.Domain.DTOs.Request;
using CBF.Service.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CBF.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClubeController : ControllerBase
    {
        private readonly IClubeService _clubeService;

        public ClubeController(IClubeService clubeService)
        {
            _clubeService = clubeService;
        }

        [HttpGet("Buscar-Clubes")]
        public async Task<IActionResult> BuscarClubes(string nome)
        {
            var clubes = await _clubeService.BuscarClubesPorNomeAsync(nome);
            return Ok(clubes);
        }

        [HttpGet("Buscar-Clube-Com-Jogadores/{id}")]
        public async Task<IActionResult> BuscarClubes([FromRoute] long id)
        {
            var clube = await _clubeService.BuscarClubeComJogadoresAsync(id);
            return Ok(clube);
        }

        [HttpGet("Buscar-Clubes-Por-Id/{id}")]
        public async Task<IActionResult> BuscarClubesPorId([FromRoute] long id)
        {
            var clube = await _clubeService.BuscarClubesPorIdAsync(id);
            return Ok(clube);
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost("Cadastrar-Clube")]
        public async Task<ActionResult> CadastrarClube([FromBody] ClubeRequest request)
        {
            var response = await _clubeService.CadastrarClubeAsync(request);

            return Ok(response);
        }

        [Authorize(Roles = "Administrador")]
        [HttpPut("Atualizar-Clube-Por-Id/{id}")]
        public async Task<IActionResult> AtualizarClubePorId([FromRoute] long id, [FromBody] ClubeRequest request)
        {
            var clubeAtualizado = await _clubeService.AtualizarClubeAsync(id, request);

            return Ok(new { Mensagem = "Clube Atualizado!", clubeAtualizado });
        }

        [Authorize(Roles = "Administrador")]
        [HttpDelete("Deletar-Clube/{id}")]
        public async Task<ActionResult> DeletarClube([FromRoute] long id)
        {
            var clube = await _clubeService.DeletarClubeAsync(id);

            return Ok($"Clube {clube.Nome} foi deletado com sucesso!");
        }
    }
}