using WLVSToolsV2.Web.WebInfrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Move all service registrations out
builder.Services.AddApplicationServices(builder.Configuration); 
builder.Services.AddInfrastructureServices(builder.Configuration); 
builder.Services.AddWebServices();

var app = builder.Build();

// Move all middleware registrations out
app.UseWebMiddlewares(); 
app.UseApplicationMiddlewares(); 
app.UseInfrastructureMiddlewares();

app.Run();
