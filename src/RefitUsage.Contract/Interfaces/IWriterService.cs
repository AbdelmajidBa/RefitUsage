using RefitUsage.Contract.Model;

namespace RefitUsage.Contract.Interfaces;

public interface IWriterService
{
    Task<IEnumerable<Writer>> GetWriters();
}