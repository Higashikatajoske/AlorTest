using AlorTest;
using AlorTest.Extensions;
using AlorTest.Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

ServiceProvider serviceProvider = new ServiceCollection().AddServices().BuildServiceProvider();
StartApp? app = serviceProvider.GetService<StartApp>();
if (app != null)
{
    await app.Start();
}

Console.ReadKey();
