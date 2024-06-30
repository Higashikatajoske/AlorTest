
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using AlorTest.Service;
using Microsoft.Extensions.Configuration;
using AlorTest.Configure;
using AlorTest.Repository;
using Microsoft.EntityFrameworkCore;

namespace AlorTest.Extensions;

public static class ServiceCollectionExtension
{
    private const string ClientName = "AlorTest";

    public static ServiceCollection AddConfig(this ServiceCollection serviceCollection)
    {
        IConfigurationBuilder builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json");

        IConfiguration config = builder.Build();
        string? stringConnection = config.GetConnectionString("DefaultConnection");

        serviceCollection.Configure<StorageOptions>(config.GetSection("StorageSettings"));

        serviceCollection.AddDbContext<TestContext>(options =>
        {
            options.UseSqlServer(stringConnection);
        });
        return serviceCollection;
    }

    public static ServiceCollection AddServices(this ServiceCollection serviceCollection)
    {
        serviceCollection.AddHttpClient(ClientName);
        serviceCollection.AddScoped(s => s.GetRequiredService<IHttpClientFactory>().CreateClient(ClientName));
        serviceCollection.AddScoped<IHttpService, HttpService>();
        serviceCollection.AddScoped<IFileService, FileService>();
        serviceCollection.AddTransient<StartApp>();
        return serviceCollection;
    }
}
