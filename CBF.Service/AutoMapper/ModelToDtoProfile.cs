using AutoMapper;
using CBF.Domain.DTOs.Response;
using CBF.Domain.Entities;

namespace CBF.Service.AutoMapper;
public class ModelToDtoProfile : Profile
{
    public ModelToDtoProfile()
    {
        CreateMap<Usuario, UsuarioResponse>();
        CreateMap<Jogador, JogadorResponse>()
            .ForMember(x => x.Contrato, map => map.MapFrom(j => j.Clubes));
        CreateMap<Temporada, TemporadaResponse>();
        CreateMap<Clube, ClubeResponse>();
        CreateMap<ClubeJogador, ClubeJogadorResponse>();
    }
}
