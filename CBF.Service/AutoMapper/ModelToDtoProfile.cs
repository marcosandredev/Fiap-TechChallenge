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
        CreateMap<Transferencias, TransferenciaResponse>();
    }
}
