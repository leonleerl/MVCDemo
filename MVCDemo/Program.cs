var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoint =>
{
    endpoint.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Create}/{id?}");
});

app.Run();
