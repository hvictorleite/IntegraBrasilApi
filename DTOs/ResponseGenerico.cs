using System.Dynamic;
using System.Net;
namespace IntegraBrasilApi.DTOs;

public class ResponseGenerico<TEntity>
    where TEntity : class
{
    public HttpStatusCode CodigoHttp { get; set; }
    public TEntity? DadosRetorno { get; set; }
    public ExpandoObject? ErroRetorno { get; set; }
}