using NetCoreSampleService.APIs;

namespace NetCoreSampleService;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IUsersService, UsersService>();
    }
}
