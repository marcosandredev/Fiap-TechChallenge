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
    }
}
