using Microsoft.Extensions.DependencyInjection;

namespace DropBear.Templates.ClassLibrary;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddService(this IServiceCollection services, Action<ServiceOptions>? options = null)
    {
        var serviceOptions = new ServiceOptions();
        options?.Invoke(serviceOptions);
        return services;
    }        
}
