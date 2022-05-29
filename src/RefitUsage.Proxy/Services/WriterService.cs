using RefitUsage.Contract.Interfaces;
using RefitUsage.Contract.Model;
using RefitUsage.Proxy.Apis;

namespace RefitUsage.Proxy.Services;

public class WriterService : IWriterService
{
    private readonly IWriterApi _writerApi;
    public WriterService(IWriterApi writerApi)
    {
        _writerApi = writerApi;
    }

    public async Task<IEnumerable<Writer>> GetWriters()
    {
        return await _writerApi.GetAllWriters();
    }
} 