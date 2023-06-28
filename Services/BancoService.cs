using AutoMapper;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Interfaces;

namespace IntegraBrasilApi.Services;

public class BancoService : IBancoService
{
    private readonly IMapper _mapper;
    private readonly IBrasilApi _brasilApi;

    public BancoService(IMapper mapper, IBrasilApi brasilApi)
    {
        _mapper = mapper;
        _brasilApi = brasilApi;
    }

    public async Task<ResponseGenerico<IEnumerable<BancoResponse>>> BuscarBancos()
    {
        var bancos = await _brasilApi.BuscarBancos();
        return _mapper.Map<ResponseGenerico<IEnumerable<BancoResponse>>>(bancos);
    }

    public async Task<ResponseGenerico<BancoResponse>> BuscarBancoPorCodigo(string codigo)
    {
        var banco = await _brasilApi.BuscarBancoPorCodigo(codigo);
        return _mapper.Map<ResponseGenerico<BancoResponse>>(banco);
    }
}
