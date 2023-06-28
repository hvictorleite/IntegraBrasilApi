using AutoMapper;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Interfaces;

namespace IntegraBrasilApi.Services;

public class EnderecoService : IEnderecoService
{
    private readonly IMapper _mapper;
    private readonly IBrasilApi _brasilApi;

    public EnderecoService(IMapper mapper, IBrasilApi brasilApi)
    {
        _mapper = mapper;
        _brasilApi = brasilApi;
    }

    public async Task<ResponseGenerico<EnderecoResponse>> BuscarEnderecoPorCep(string cep)
    {
        var endereco = await _brasilApi.BuscarEnderecoPorCep(cep);
        return _mapper.Map<ResponseGenerico<EnderecoResponse>>(endereco);
    }
}
