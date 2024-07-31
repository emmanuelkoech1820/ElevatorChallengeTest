using ElevatorChallenge.Core.Contracts;
using ElevatorChallenge.Helpers;
using ElevatorChallenge.Models;
using ElevatorChallenge.Services.Implementations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ElevatorChallenge
{
    class Program
    {
        static async Task Main(string[] args)
        {            
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            var serviceProvider = new ServiceCollection()
            .AddSingleton(configuration)
            .AddScoped<IOperationService, OperationService>()
            .AddSingleton<IConsoleOutputHelper, ConsoleOutputHelper>()
            .AddSingleton<IElevatorThreadManager, ElevatorThreadManager>()
            .AddSingleton<IControlService, ControlCentreService>()
            .Configure<ElevatorConfiguration>(configuration.GetSection("ElevatorConfiguration"))
            .BuildServiceProvider();
            try
            {
                var consoleInputHelper = serviceProvider.GetRequiredService<IOperationService>();
                await consoleInputHelper.StartTheElevatorSystemIOMonitoringProcessAsync();
                await consoleInputHelper.StartElevatorThreads();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
