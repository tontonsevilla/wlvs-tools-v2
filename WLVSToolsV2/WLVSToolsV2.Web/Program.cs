var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

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
