using AlorTest;
using AlorTest.Extensions;
using AlorTest.Service;
using Microsoft.Extensions.DependencyInjection;

ServiceProvider serviceProvider = new ServiceCollection()
    .AddServices()
    .AddConfig()
    .BuildServiceProvider();

IConsoleService? app = serviceProvider.GetService<IConsoleService>();
if (app != null)
{
    await app.StartProgram();
}
