using CBF.Domain.DTOs.Request;
using CBF.Service.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CBF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstatisticasController : ControllerBase
    {
        private readonly IEstatisticaService _estatisticaService;

        public EstatisticasController(IEstatisticaService estatisticaService)
        {
            _estatisticaService = estatisticaService;
        }

        [HttpDelete("Deletar-Estatistica-Jogador/{id}")]
        [Authorize(Roles = "Administrador")]
        public async Task<ActionResult> DeletarEstatisticaJogador([FromRoute] long id)
        {
            await _estatisticaService.DeletarEstatisticaJogadorAsync(id);

            return Ok("Estastística Jogador deletada da base!");
        }

        [HttpDelete("Deletar-Estatistica-Jogador-Clube/{id}")]
        [Authorize(Roles = "Administrador")]
        public async Task<ActionResult> DeletarEstatisticaJogadorClube([FromRoute] long id)
        {
            await _estatisticaService.DeletarEstatisticaJogadorClubeAsync(id);

            return Ok("Estastística Jogador Clube deletada da base!");
        }

        [HttpPut("Atualizar-Estatistica-Jogador/{id}")]
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> AtualizarEstatisticaJogador([FromRoute] long id, [FromBody] EstatisticaJogadorRequest request)
        {
            var estatistica = await _estatisticaService.AtualizarEstatisticaJogadorAsync(id, request);

            return Ok(new { Mensagem = "Estatística Atualizada!", estatistica });
        }

        [HttpPut("Atualizar-Estatistica-Jogador-Clube/{id}")]
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> AtualizarEstatisticaJogadorClube([FromRoute] long id, [FromBody] EstatisticaJogadorClubeRequest request)
        {
            var estatistica = await _estatisticaService.AtualizarEstatisticaJogadorClubeAsync(id, request);

            return Ok(new { Mensagem = "Estatística Atualizada!", estatistica });
        }

        [HttpPost("Criar-Estatistica-Jogador")]
        [Authorize(Roles = "Administrador")]
        public async Task<ActionResult> CriarEstatisticaJogador([FromBody] EstatisticaJogadorRequest request)
        {
            var response = await _estatisticaService.CadastrarEstatisticaJogadorAsync(request);

            return Ok(response);
        }

        [HttpPost("Criar-Estatistica-Jogador-Clube")]
        [Authorize(Roles = "Administrador")]
        public async Task<ActionResult> CriarEstatisticaJogadorClube([FromBody] EstatisticaJogadorClubeRequest request)
        {
            var response = await _estatisticaService.CadastrarEstatisticaJogadorClubeAsync(request);

            return Ok(response);
        }

        [HttpGet("Buscar-Jogadores-Gols-Temporada/{idTemporada}")]
        public async Task<IActionResult> GetJogadoresGolsTemporada([FromRoute] long idTemporada)
        {
            var result = await _estatisticaService.GetJogadoresGolsAsync(idTemporada);

            return Ok(result);
        }

        [HttpGet("Buscar-Jogadores-Vermelhos-Temporada/{idTemporada}")]
        public async Task<IActionResult> GetJogadoresVermelhosTemporada([FromRoute] long idTemporada)
        {
            var result = await _estatisticaService.GetJogadoresVermelhosAsync(idTemporada);

            return Ok(result);
        }

        [HttpGet("Buscar-Jogadores-Amarelos-Temporada/{idTemporada}")]
        public async Task<IActionResult> GetJogadoresAmarelosTempoarada([FromRoute] long idTemporada)
        {
            var result = await _estatisticaService.GetJogadoresAmarelosAsync(idTemporada);

            return Ok(result);
        }


        [HttpGet("Buscar-Jogadores-Assistentencias-Temporada/{idTemporada}")]
        public async Task<IActionResult> GetJogadoresAssistenciasTempoarada([FromRoute] long idTemporada)
        {
            var result = await _estatisticaService.GetJogadoresAssistenciasAsync(idTemporada);

            return Ok(result);
        }


        [HttpGet("Buscar-Jogadores-Partidas-Temporada/{idTemporada}")]
        public async Task<IActionResult> GetJogadoresPartidasTemporada([FromRoute] long idTemporada)
        {
            var result = await _estatisticaService.GetJogadoresPartidasAsync(idTemporada);

            return Ok(result);
        }
    }
}
