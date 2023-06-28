using System.Text.Json.Serialization;

namespace IntegraBrasilApi.DTOs;

public class EnderecoResponse
{
    public string? Cep { get; set; }
    public string? Estado { get; set; }
    public string? Cidade { get; set; }
    public string? Bairro { get; set; }
    public string? Logradouro { get; set; }
    public string? Servico { get; set; }
}
