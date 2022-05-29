using Refit;
using RefitUsage.Contract.Model;

namespace RefitUsage.Proxy.Apis;

public interface IUserApi
{
    [Get("/users/{login}")]
    Task<User> GetUserByLogin(string login);
    
    [Get("/users")]
    Task<IEnumerable<User>> GetAllUsers();
}
