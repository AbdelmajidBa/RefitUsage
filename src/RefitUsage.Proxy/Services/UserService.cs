using RefitUsage.Contract.Interfaces;
using RefitUsage.Contract.Model;
using RefitUsage.Proxy.Apis;

namespace RefitUsage.Proxy.Services;

public class UserService : IUserService
{
    private readonly IUserApi _userApi;
    public UserService(IUserApi userApi)
    {
        _userApi = userApi;
    }

    public async Task<User> GetUserByLogin(string login)
    {
        return await _userApi.GetUserByLogin(login);
    }

    public async Task<IEnumerable<User>> GetUsers()
    {
        return await _userApi.GetAllUsers();
    }
} 