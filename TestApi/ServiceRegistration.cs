using TestApi.Service.Abstracts;
using TestApi.Service.Implements;

namespace TestApi
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ILanguageService, LanguageService>();
            services.AddScoped<IWordService, WordService>();
            services.AddScoped<IGameService, GameService>();

            return services;
        }
    }
}
