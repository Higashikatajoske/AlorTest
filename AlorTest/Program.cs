using AlorTest;
using AlorTest.Extensions;
using Microsoft.Extensions.DependencyInjection;

ServiceProvider serviceProvider = new ServiceCollection()
    .AddServices()
    .AddConfig()
    .BuildServiceProvider();

StartApp? app = serviceProvider.GetService<StartApp>();
if (app != null)
{
    await app.Start();
}

Console.ReadKey();
