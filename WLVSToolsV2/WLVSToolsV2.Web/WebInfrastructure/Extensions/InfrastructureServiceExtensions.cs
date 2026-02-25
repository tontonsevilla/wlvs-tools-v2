namespace WLVSToolsV2.Web.WebInfrastructure.Extensions
{
    public static class InfrastructureServiceExtensions
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services,
            IConfiguration config)
        {
            // Example: EF Core, Identity, external APIs
            //services.AddDbContext<AppDbContext>(options =>
            //    options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            return services;
        }
    }

}
