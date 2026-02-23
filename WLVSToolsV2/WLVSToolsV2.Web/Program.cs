using WLVSToolsV2.Web.WebInfrastructure.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddWebOptimizer(pipeline =>
{
    pipeline.AddCssBundle("/css/bundle.css", "lib/bootstrap/dist/css/bootstrap.css", "css/site.css");
    pipeline.AddJavaScriptBundle("/js/bundle.js", "lib/bootstrap/dist/js/bootstrap.js", "js/site.js");
});

builder.Services.AddControllersWithViews(options => 
{ 
    options.Filters.Add<NullModelFilter>(); 
});

var app = builder.Build();

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

app.Run();
