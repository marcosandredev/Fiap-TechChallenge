﻿using Azure;
using CBF.Domain.DTOs.Request;
using CBF.Domain.DTOs.Response;
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
              var response = await _jogadorService.CadastrarJogadorAsync(request);
              
              return Ok(response);
        }

        [HttpPost("Criar-Jogadores-Em-Massa")]
        public async Task<ActionResult> CriarJogadorMassa([FromBody] IList<JogadorRequest> request)
        {
            IDictionary<string,string> nomesJogadores = new Dictionary<string,string>();

            var response = new JogadorResponse();

            foreach (var jogador in request)
            {
                try
                {
                    response = await _jogadorService.CadastrarJogadorAsync(jogador);

                    nomesJogadores.Add(response.Nome,"Sucesso");
                }
                catch (Exception e)
                {
                    nomesJogadores.Add(jogador.Nome, e.Message);
                }
            }

            return Ok(new {Mensagem = "Status cadastro:", nomesJogadores});
        }

        [HttpDelete("Deletar-Jogador/{id}")]
        [Authorize(Roles = "Administrador")]
        public async Task<ActionResult> DeletarJogador([FromRoute] long id)
        {
              var jogador = await _jogadorService.DeletarJogadorAsync(id);

              return Ok($"Jogador {jogador.Nome} foi deletado da base!");

        }

        [HttpPut("Atualizar-Jogador/{id}")]
        public async Task<IActionResult> AtualizarJogador([FromRoute] long id, [FromBody] JogadorUpdateRequest request)
        {
              var jogadorAtualizado = await _jogadorService.AtualizarJogadorAsync(id, request);
              
              return Ok(new { Mensagem = "Jogador Atualizado!", jogadorAtualizado });
        }

        [HttpGet("Buscar-Jogador-Por-Id/{id}")]
        public async Task<IActionResult> BuscarJogadorPorId([FromRoute] long id)
        {
                var jogador = await _jogadorService.BuscaJogadorPorIdAsync(id);
                return Ok(jogador);
        }

        [HttpGet("Buscar-Jogador-Por-Nacionalidade/{nacionalidade}")]
        public async Task<IActionResult> BuscarJogadoresPorNacionalidade(string nacionalidade)
        {
              var jogadores = await _jogadorService.BuscarJogadoresPorNacionalidadeAsync(nacionalidade);
              return Ok(jogadores);
        }
    }
}
