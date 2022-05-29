using Refit;
using RefitUsage.Contract.Model;

namespace RefitUsage.Proxy.Apis;

public interface IWriterApi
{
    [Get("/writers")]
    Task<IEnumerable<Writer>> GetAllWriters();
}