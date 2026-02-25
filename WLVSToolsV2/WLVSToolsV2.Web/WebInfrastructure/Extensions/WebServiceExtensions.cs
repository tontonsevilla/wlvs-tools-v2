using WLVSToolsV2.Web.WebInfrastructure.Filters;

namespace WLVSToolsV2.Web.WebInfrastructure.Extensions
{
    public static class WebServiceExtensions
    {
        public static IServiceCollection AddWebServices(
            this IServiceCollection services)
        {
            //services.AddControllers();
            //services.AddEndpointsApiExplorer();
            //services.AddSwaggerGen();

            services.AddWebOptimizer(pipeline =>
            {
                pipeline.AddCssBundle("/css/bundle.css", "lib/bootstrap/dist/css/bootstrap.css", "css/site.css");
                pipeline.AddJavaScriptBundle(
                    "/js/bundle.js", 
                    "lib/jquery/dist/jquery.js",
                    "lib/bootstrap/dist/js/bootstrap.js", 
                    "js/site.js");
            });

            services.AddControllersWithViews(options =>
            {
                options.Filters.Add<NullModelFilter>();
            });

            return services;
        }
    }

}
