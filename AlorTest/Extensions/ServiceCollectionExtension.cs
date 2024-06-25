
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using AlorTest.Service;

namespace AlorTest.Extensions;

public static class ServiceCollectionExtension
{
    private const string ClientName = "AlorTest";

    public static ServiceCollection AddServices(this ServiceCollection serviceCollection)
    {
        serviceCollection.AddHttpClient(ClientName);
        serviceCollection.AddScoped(s => s.GetRequiredService<IHttpClientFactory>().CreateClient(ClientName));
        serviceCollection.AddScoped<IHttpService, HttpService>();
        serviceCollection.AddTransient<StartApp>();
        return serviceCollection;
    }
}
