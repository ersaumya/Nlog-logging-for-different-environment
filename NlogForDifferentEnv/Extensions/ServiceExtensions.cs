using NlogForDifferentEnv.Contracts;
using NlogForDifferentEnv.LoggerService;

namespace NlogForDifferentEnv.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
    }
}
