WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

WebApplication app = builder.Build();
app.MapRazorPages();

app.Run("https://*:50001");