using RefitUsage.Contract.Model;

namespace RefitUsage.Domain.Interfaces.Repositories;

public interface IWriterRepository
{
    Task<IEnumerable<Writer>> GetWriters();
}