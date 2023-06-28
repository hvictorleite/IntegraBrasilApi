using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Models;

public class EnderecoModel
{
    [JsonPropertyName("cep")]
    public string? Cep { get; set; }

    [JsonPropertyName("state")]
    public string? Estado { get; set; }

    [JsonPropertyName("city")]
    public string? Cidade { get; set; }

    [JsonPropertyName("neighborhood")]
    public string? Bairro { get; set; }

    [JsonPropertyName("street")]
    public string? Logradouro { get; set; }

    [JsonPropertyName("service")]
    public string? Servico { get; set; }
}