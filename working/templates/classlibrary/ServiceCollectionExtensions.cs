namespace classlibrarytemplate;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddService(this IServiceCollection services, Action<ServiceOptions>? options = null)
    {
        var serviceOptions = new ServiceOptions();
        options?.Invoke(serviceOptions);
        return services;
    }        
}
