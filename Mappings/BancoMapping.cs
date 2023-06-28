using AutoMapper;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Mappings;

public class BancoMapping : Profile
{
    public BancoMapping()
    {
        // CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
        CreateMap<BancoModel, BancoResponse>().ReverseMap();
    }
}
