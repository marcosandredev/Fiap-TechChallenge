using CBF.Domain.DTOs.Request;
using CBF.Service.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CBF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogadorController : ControllerBase
    {
        private readonly IJogadorService _jogadorService;

        public JogadorController(IJogadorService jogadorService)
        {
            _jogadorService = jogadorService;
        }

        [HttpPost("Criar-Jogador")]
        public async Task<ActionResult> CriarJogador([FromBody] JogadorRequest request)
        {
            try
            {
                var response = await _jogadorService.CadastrarJogadorAsync(request);

                return Ok(response);

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

        [HttpDelete("Deletar-Jogador/{id}")]
        [Authorize(Roles = "Administrador")]
        public async Task<ActionResult> DeletarJogador([FromRoute] long id)
        {
            try
            {
                var jogador = await _jogadorService.DeletarJogadorAsync(id);

                return Ok($"Jogador {jogador.Nome} foi deletado da base!");

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("Atualizar-Jogador/{id}")]
        public async Task<IActionResult> AtualizarJogador([FromRoute] long id, [FromBody] JogadorUpdateRequest request)
        {
            try
            {
                var jogadorAtualizado = await _jogadorService.AtualizarJogadorAsync(id, request);

                return Ok(new { Mensagem = "Jogador Atualizado!", jogadorAtualizado });
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("Buscar-Jogador-Por-Id/{id}")]
        public async Task<IActionResult> BuscarJogadorPorId([FromRoute] long id)
        {
            try
            {
                var jogador = await _jogadorService.BuscaJogadorPorIdAsync(id);
                return Ok(jogador);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("Buscar-Jogador-Por-Nacionalidade/{nacionalidade}")]
        public async Task<IActionResult> BuscarJogadoresPorNacionalidade(string nacionalidade)
        {
            try
            {
                var jogadores = await _jogadorService.BuscarJogadoresPorNacionalidadeAsync(nacionalidade);
                return Ok(jogadores);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
