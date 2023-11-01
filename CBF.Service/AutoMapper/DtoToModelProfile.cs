using AutoMapper;
using CBF.Domain.DTOs.Request;
using CBF.Domain.Entities;

namespace CBF.Service.AutoMapper;
public class DtoToModelProfile : Profile
{
    public DtoToModelProfile()
    {
        CreateMap<UsuarioRequest, Usuario>();
        CreateMap<JogadorRequest, Jogador>();
        CreateMap<JogadorUpdateRequest, Jogador>();
        CreateMap<TemporadaRequest, Temporada>();
        CreateMap<ClubeRequest, Clube>();
        CreateMap<ClubeJogadorRequest, ClubeJogador>();
        CreateMap<TransferenciaRequest, Transferencias>();
        CreateMap<EstatisticaJogadorClubeRequest, EstatisticaJogadorClube>();
        CreateMap<EstatisticaJogadorRequest, EstatisticaJogador>();
    }
}
