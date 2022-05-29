using RefitUsage.Domain.Interfaces.Repositories;
using RefitUsage.Contract.Model;


namespace RefitUsage.DataAccess.Repositories;
public class WriterRepository : IWriterRepository
{
    public async Task<IEnumerable<Writer>> GetWriters()
    {
        var result = await Task.Run(() => {return new List<Writer>{

            new Writer {Id = 1, FirstName = "fiirstname1", LastName="lastname1"},
            new Writer {Id = 2, FirstName = "fiirstname2", LastName="lastname2"},
            new Writer {Id = 3, FirstName = "fiirstname3", LastName="lastname3"}

        }; });

        return result;
    }
}
