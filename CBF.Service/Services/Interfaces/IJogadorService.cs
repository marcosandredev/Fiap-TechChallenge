using CBF.Domain.DTOs.Request;
using CBF.Domain.DTOs.Response;

namespace CBF.Service.Services.Interfaces;
public interface IJogadorService
{
    Task<JogadorResponse> CadastrarJogadorAsync(JogadorRequest request);
    Task<JogadorResponse> DeletarJogadorAsync(long id);
    Task<JogadorResponse> AtualizarJogadorAsync(long id, JogadorUpdateRequest request);
    Task<JogadorResponse> BuscaJogadorPorIdAsync(long id);
    Task<IEnumerable<JogadorResponse>> BuscaJogadoresAsync();
    Task<IEnumerable<JogadorResponse>> BuscarJogadoresPorNacionalidadeAsync(string nacionalidade);


}
