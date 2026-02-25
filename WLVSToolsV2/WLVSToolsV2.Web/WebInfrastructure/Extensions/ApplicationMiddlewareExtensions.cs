namespace WLVSToolsV2.Web.WebInfrastructure.Extensions
{
    public static class ApplicationMiddlewareExtensions
    {
        public static IApplicationBuilder UseApplicationMiddlewares(this IApplicationBuilder app)
        {
            // Example: custom middlewares
            // app.UseMiddleware<RequestLoggingMiddleware>();
            // app.UseMiddleware<ExceptionHandlingMiddleware>();

            return app;
        }
    }

}
