using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();   
builder.Services.AddMvc(option => option.EnableEndpointRouting = false);

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");


app.UseDeveloperExceptionPage();
app.UseStaticFiles();
app.UseMvcWithDefaultRoute();
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Hello Kasun");
//});

app.Run();
