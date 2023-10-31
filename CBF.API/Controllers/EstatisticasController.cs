using Microsoft.AspNetCore.Mvc;
using CBF.Service.Services.Interfaces;
using CBF.Domain.Entities;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using CBF.Domain.DTOs.Request;
using CBF.Service.Services;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace CBF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstatisticasController : ControllerBase
    {
        #region Atributos
        private readonly IEstatisticaService _estatisticaService;
        #endregion

        #region Construtor
        public EstatisticasController(IEstatisticaService estatisticaService)
        {
            _estatisticaService = estatisticaService;
        }
        #endregion

        #region Excluir Estatísticas Jogador
        [HttpDelete("Deletar-Estatistica-Jogador/{id}")]
        [Authorize(Roles = "Administrador")]
        public async Task<ActionResult> DeletarEstatisticaJogador([FromRoute] long id)
        {
            var estatistica = await _estatisticaService.DeletarEstatisticaJogadorAsync(id);

            return Ok("Estastística Jogador deletada da base!");
        }
        #endregion

        #region Excluir Estatísticas Jogador Clube
        [HttpDelete("Deletar-Estatistica-Jogador-Clube/{id}")]
        [Authorize(Roles = "Administrador")]
        public async Task<ActionResult> DeletarEstatisticaJogadorClube([FromRoute] long id)
        {
            var estatistica = await _estatisticaService.DeletarEstatisticaJogadorClubeAsync(id);

            return Ok("Estastística Jogador Clube deletada da base!");
        }
        #endregion

        #region Atualizar Estatísticas Jogador
        [HttpPut("Atualizar-Estatistica-Jogador/{id}")]
        public async Task<IActionResult> AtualizarEstatisticaJogador([FromRoute] long id, [FromBody] EstatisticaJogadorRequest request)
        {
            var estatistica = await _estatisticaService.AtualizarEstatisticaJogadorAsync(id, request);

            return Ok(new { Mensagem = "Estatística Atualizada!", estatistica });
        }
        #endregion

        #region Atualizar Estatísticas Jogador Clube
        [HttpPut("Atualizar-Estatistica-Jogador-Clube/{id}")]
        public async Task<IActionResult> AtualizarEstatisticaJogadorClube([FromRoute] long id, [FromBody] EstatisticaJogadorClubeRequest request)
        {
            var estatistica = await _estatisticaService.AtualizarEstatisticaJogadorClubeAsync(id, request);

            return Ok(new { Mensagem = "Estatística Atualizada!", estatistica });
        }
        #endregion

        #region Incluir Estatísticas Jogador
        [HttpPost("Criar-Estatistica-Jogador")]
        public async Task<ActionResult> CriarEstatisticaJogador([FromBody] EstatisticaJogadorRequest request)
        {
            var response = await _estatisticaService.CadastrarEstatisticaJogadorAsync(request);

            return Ok(response);
        }
        #endregion

        #region Incluir Estatísticas Jogador Clube
        [HttpPost("Criar-Estatistica-Jogador-Clube")]
        public async Task<ActionResult> CriarEstatisticaJogadorClube([FromBody] EstatisticaJogadorClubeRequest request)
        {
            var response = await _estatisticaService.CadastrarEstatisticaJogadorClubeAsync(request);

            return Ok(response);
        }
        #endregion

        #region Jogador Gols Temporada
        [HttpGet("Buscar-Jogadores-Gols-Temporada/{idTemporada}")]
        public async Task<IActionResult> GetJogadoresGolsTemporada([FromRoute] long idTemporada)
        {
            try
            {

               var result =  await _estatisticaService.GetJogadoresGolsAsync(idTemporada);

                if ( result == null || !result.Any())
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Erro interno do servidor", message = ex.Message });
            }
        }
        #endregion

        #region Jogadores Vermelhos Temporada
        [HttpGet("Buscar-Jogadores-Vermelhos-Temporada/{idTemporada}")]
        public async Task<IActionResult> GetJogadoresVermelhosTemporada([FromRoute] long idTemporada)
        {
            try
            {
                var result = await _estatisticaService.GetJogadoresVermelhosAsync(idTemporada);

                if (result == null || !result.Any())
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Erro interno do servidor", message = ex.Message });
            }
        }
        #endregion

        #region Jogadores Amarelos Temporada
        [HttpGet("Buscar-Jogadores-Amarelos-Temporada/{idTemporada}")]
        public async Task<IActionResult> GetJogadoresAmarelosTempoarada([FromRoute] long idTemporada)
        {
            try
            {
                var result = await _estatisticaService.GetJogadoresAmarelosAsync(idTemporada);

                if (result == null || !result.Any())
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Erro interno do servidor", message = ex.Message });
            }
        }
        #endregion

        #region Jogadores Assistência Temporada

        [HttpGet("Buscar-Jogadores-Assistentencias-Temporada/{idTemporada}")]
        public async Task<IActionResult> GetJogadoresAssistenciasTempoarada([FromRoute] long idTemporada)
        {
            try
            {
                var result = await _estatisticaService.GetJogadoresAssistenciasAsync(idTemporada);

                if (result == null || !result.Any())
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Erro interno do servidor", message = ex.Message });
            }
        }
        #endregion

        #region Jogadores Partidas Temporada

        [HttpGet("Buscar-Jogadores-Partidas-Temporada/{idTemporada}")]
        public async Task<IActionResult> GetJogadoresPartidasTemporada([FromRoute] long idTemporada)
        {
            try
            {
                var result = await _estatisticaService.GetJogadoresAssistenciasAsync(idTemporada);

                if (result == null || !result.Any())
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Erro interno do servidor", message = ex.Message });
            }
        }
        #endregion

        #region Clubes Gols Temporada
        [HttpPost("Buscar-Clubes-Temporada")]
        public async Task<IActionResult> GetEstatisticasClubesTemporada([FromBody] EstatisticasClubesRequest request)
        {
            try
            {
                var result = await _estatisticaService.GetEstatisticasClubesTemporada(request);

                if (result == null || !result.Any())
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Erro interno do servidor", message = ex.Message });
            }
        }
        #endregion
    }
}
