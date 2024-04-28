var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoint =>
{
    endpoint.MapDefaultControllerRoute();
});

app.Run();
