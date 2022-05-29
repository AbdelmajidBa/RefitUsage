using RefitUsage.Contract.Model;

namespace RefitUsage.Contract.Interfaces;

public interface IUserService
{
    Task<IEnumerable<User>> GetUsers();
    Task<User> GetUserByLogin(string login);
}