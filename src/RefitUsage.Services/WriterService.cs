using RefitUsage.Domain.Interfaces;

using RefitUsage.Domain.Interfaces.Repositories;
using RefitUsage.Contract.Model;

namespace RefitUsage.Services;
public class WriterService : IWriter
{
    private readonly IWriterRepository _writerRepository;
    public WriterService(IWriterRepository writerRepository)
    {
        _writerRepository = writerRepository;
    }

    public async Task<IEnumerable<Writer>> GetWriters()
    {
        return await _writerRepository.GetWriters();
    }
}
