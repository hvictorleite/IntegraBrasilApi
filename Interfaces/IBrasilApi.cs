using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Interfaces;

public interface IBrasilApi
{
    Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCep(string cep);
    Task<ResponseGenerico<IEnumerable<BancoModel>>> BuscarBancos();
    Task<ResponseGenerico<BancoModel>> BuscarBancoPorCodigo(string codigo);
}