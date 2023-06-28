using IntegraBrasilApi.DTOs;

namespace IntegraBrasilApi.Interfaces;

public interface IBancoService
{
    Task<ResponseGenerico<IEnumerable<BancoResponse>>> BuscarBancos();
    Task<ResponseGenerico<BancoResponse>> BuscarBancoPorCodigo(string codigo);
}