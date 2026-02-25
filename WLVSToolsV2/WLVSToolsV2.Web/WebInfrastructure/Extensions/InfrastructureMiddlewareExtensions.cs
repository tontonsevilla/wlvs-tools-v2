namespace WLVSToolsV2.Web.WebInfrastructure.Extensions
{
    public static class InfrastructureMiddlewareExtensions
    {
        public static IApplicationBuilder UseInfrastructureMiddlewares(this IApplicationBuilder app)
        {
            // Example: authentication/authorization
            // app.UseAuthentication();
            // app.UseAuthorization();

            return app;
        }
    }

}
