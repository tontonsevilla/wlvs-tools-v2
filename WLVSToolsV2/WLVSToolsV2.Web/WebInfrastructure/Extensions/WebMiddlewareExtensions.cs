namespace WLVSToolsV2.Web.WebInfrastructure.Extensions
{
    public static class WebMiddlewareExtensions
    {
        public static IApplicationBuilder UseWebMiddlewares(this IApplicationBuilder app)
        {
            app.UseHttpsRedirection();

            //app.UseSwagger();
            //app.UseSwaggerUI();

            app.UseWebOptimizer();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                // Area route
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                // Default route
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            return app;
        }
    }

}
