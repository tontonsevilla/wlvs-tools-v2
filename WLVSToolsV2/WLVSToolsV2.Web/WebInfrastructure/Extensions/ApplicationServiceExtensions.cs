using WLVSToolsV2.Web.Infrastructure.Services;

namespace WLVSToolsV2.Web.WebInfrastructure.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services,
            IConfiguration config)
        {
            // Example: business logic services
            services.AddHttpClient<ILocalModelClient, LocalModelClient>(client => {
                client.BaseAddress = new Uri("http://localhost:11434");
                client.Timeout = TimeSpan.FromMinutes(5);
            });
            services.AddSingleton<IToolRegistry, ToolRegistry>();
            services.AddScoped<IAgentService, AgentService>();
            services.AddSingleton<PromptLoader>();

            return services;
        }
    }
}
