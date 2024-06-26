
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using AlorTest.Service;
using Microsoft.Extensions.Configuration;
using AlorTest.Configure;

namespace AlorTest.Extensions;

public static class ServiceCollectionExtension
{
    private const string ClientName = "AlorTest";

    public static ServiceCollection AddConfig(this ServiceCollection serviceCollection)
    {
        IConfigurationBuilder builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json");

        IConfiguration config = builder.Build();

        serviceCollection.Configure<StorageOptions>(config.GetSection("StorageSettings"));
        return serviceCollection;
    }

    public static ServiceCollection AddServices(this ServiceCollection serviceCollection)
    {
        serviceCollection.AddHttpClient(ClientName);
        serviceCollection.AddScoped(s => s.GetRequiredService<IHttpClientFactory>().CreateClient(ClientName));
        serviceCollection.AddScoped<IHttpService, HttpService>();
        serviceCollection.AddTransient<StartApp>();
        return serviceCollection;
    }
}
