using Microsoft.Extensions.DependencyInjection;
using Refit;
using RefitUsage.Contract.Interfaces;
using RefitUsage.Proxy.Apis;
using RefitUsage.Proxy.Services;

namespace RefitUsage.Proxy;

public static class ProxyServiceExtensions
{
    public static IServiceCollection RegisterUserServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();    
        services.AddScoped<IWriterService, WriterService>();    

        services
            .AddRefitClient<IUserApi>()
            .ConfigureHttpClient(c => 
            {
                c.DefaultRequestHeaders.Add("user-agent", "application/json");
                c.BaseAddress = new Uri("https://api.github.com");
            });

        services
            .AddRefitClient<IWriterApi>()
            .ConfigureHttpClient(c => 
            {
                //c.DefaultRequestHeaders.Add("user-agent", "application/json");
                c.BaseAddress = new Uri("https://localhost:7127");
            });
             

        

        return services;    
    }
}