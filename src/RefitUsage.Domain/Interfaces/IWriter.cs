
using RefitUsage.Contract.Model;

namespace RefitUsage.Domain.Interfaces;

public interface IWriter
{
    Task<IEnumerable<Writer>> GetWriters();
}