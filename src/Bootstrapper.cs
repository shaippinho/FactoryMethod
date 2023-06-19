using FactoryMethodPattern.Domain.Contracts;
using FactoryMethodPattern.Domain.Services;

namespace FactoryMethodPattern
{
    public static class Bootstrapper
    {
        public static void AddInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IScreenService, ScreenService>();

        }
    }
}
