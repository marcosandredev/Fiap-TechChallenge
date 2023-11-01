using AutoMapper;
using CBF.Domain.DTOs.Response;
using CBF.Domain.Entities;

namespace CBF.Service.AutoMapper;
public class ModelToDtoProfile : Profile
{
    public ModelToDtoProfile()
    {
        CreateMap<Usuario, UsuarioResponse>();
        CreateMap<Jogador, JogadorResponse>();
        CreateMap<Temporada, TemporadaResponse>();
        CreateMap<Clube, ClubeResponse>();
        CreateMap<ClubeJogador, ClubeJogadorResponse>();
        CreateMap<Transferencias, TransferenciaResponse>();
        CreateMap<EstatisticaJogador, EstatisticaJogadorResponse>();
        CreateMap<EstatisticaJogadorClube, EstatisticaJogadorClubeResponse>();
        CreateMap<Transferencias, JogadorTransferenciaResponse>()
            .ForMember(x => x.ClubeNovo, map => map.MapFrom(t => t.ClubeNovo.Nome))
            .ForMember(x => x.ClubeAnterior, map => map.MapFrom(t => t.ClubeAnterior.Nome));
    }
}
