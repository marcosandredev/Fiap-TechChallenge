using CBF.Domain.DTOs.Request;
using CBF.Service.Services;
using CBF.Service.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CBF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferenciasController : ControllerBase
    {
        private readonly ITransferenciaService _transferenciaService;

        public TransferenciasController(ITransferenciaService transferenciaService)
        {
            _transferenciaService = transferenciaService;
        }

        [HttpPost("Criar-Transferencia")]
        public async Task<IActionResult> CriarTransferencia([FromBody] TransferenciaRequest request)
        {
            var response = await _transferenciaService.CriarTransferenciaAsync(request);
            return Ok(response);
        }

        [HttpGet("Buscar-Transferencia-Por-Id/{id}")]
        public async Task<IActionResult> BuscarTransferenciaPorId([FromRoute] long id)
        {
            var response =  await _transferenciaService.BuscarTransferenciaPorId(id);
            return Ok(response);
        }

        [Authorize(Roles = "Administrador")]
        [HttpDelete("Deletar-Transferencia/{id}")]
        public async Task<IActionResult> DeletarTransferencia([FromRoute] long id)
        {
            var response = await _transferenciaService.DeletarTransferencia(id);
            return Ok($"Transferência {response.Id} foi deletada da base");
        }

        [HttpGet("Buscar-Transferencias-Por-Clube/{idClube}")]
        public async Task<IActionResult> BuscarTransferenciasClube([FromRoute] long id)
        {
            var response = await _transferenciaService.BuscarTransferenciaPorIdClube(id);
            return Ok(response);
        }

        [HttpPut("Atualizar-Transferencia/{id}")]
        public async Task<IActionResult> AtualizarTransferencia([FromRoute] long id, [FromBody] TransferenciaRequest request)
        {
            var transferenciaAtualizada = await _transferenciaService.AtualizarTransferenciaAsync(id, request);

            return Ok(new { Mensagem = "Transferência Atualizada!", transferenciaAtualizada });
        }
    }
}
