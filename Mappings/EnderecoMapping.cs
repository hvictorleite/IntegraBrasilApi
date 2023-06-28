using AutoMapper;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Mappings;

public class EnderecoMapping : Profile
{
    public EnderecoMapping()
    {
        CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
        CreateMap<EnderecoModel, EnderecoResponse>().ReverseMap();
    }
}
