using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();   
builder.Services.AddMvc(option => option.EnableEndpointRouting = false).AddXmlSerializerFormatters();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");


app.UseDeveloperExceptionPage();
app.UseStaticFiles();
//app.UseMvcWithDefaultRoute();
app.UseMvc(route =>
{
    route.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
});
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Hello Kasun");
//});

app.Run();
