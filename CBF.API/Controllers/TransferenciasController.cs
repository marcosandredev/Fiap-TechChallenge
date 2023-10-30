using CBF.Domain.DTOs.Request;
using CBF.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CBF.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransferenciasController : ControllerBase
    {
        private readonly ITransferenciaService _transferenciaService;

        [HttpGet("Criar-Transferencia")]
        public IActionResult CriarTransferencia([FromBody] TransferenciaRequest request)
        {

            var response = _transferenciaService.CriarTransferenciaAsync(request);

            return Ok(response);
        }
    }
}
