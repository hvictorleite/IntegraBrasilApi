using System.Dynamic;
using System.Text.Json;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.REST;

public class BrasilApiRest : IBrasilApi
{
    private readonly string _apiUrl = "https://brasilapi.com.br/api";

    public async Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCep(string cep)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"{_apiUrl}/cep/v1/{cep}");

        var response = new ResponseGenerico<EnderecoModel>();
        
        using (var client = new HttpClient())
        {
            var responseBrasilApi = await client.SendAsync(request);
            var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();

            response.CodigoHttp = responseBrasilApi.StatusCode;

            if (responseBrasilApi.IsSuccessStatusCode)
                response.DadosRetorno = JsonSerializer.Deserialize<EnderecoModel>(contentResponse);
            else
                response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
        }

        return response;
    }

    public async Task<ResponseGenerico<IEnumerable<BancoModel>>> BuscarBancos()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"{_apiUrl}/banks/v1");

        var response = new ResponseGenerico<IEnumerable<BancoModel>>();

        using (var client = new HttpClient())
        {
            var responseBrasilApi = await client.SendAsync(request);
            var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();

            response.CodigoHttp = responseBrasilApi.StatusCode;

            if (responseBrasilApi.IsSuccessStatusCode)
                response.DadosRetorno = JsonSerializer.Deserialize<IEnumerable<BancoModel>>(contentResponse);
            else
                response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
        }

        return response;
    }

    public async Task<ResponseGenerico<BancoModel>> BuscarBancoPorCodigo(string codigo)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"{_apiUrl}/banks/v1/{codigo}");

        var response = new ResponseGenerico<BancoModel>();
        
        using (var client = new HttpClient())
        {
            var responseBrasilApi = await client.SendAsync(request);
            var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();

            response.CodigoHttp = responseBrasilApi.StatusCode;

            if (responseBrasilApi.IsSuccessStatusCode)
                response.DadosRetorno = JsonSerializer.Deserialize<BancoModel>(contentResponse);
            else
                response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
        }

        return response;
    }    
}
