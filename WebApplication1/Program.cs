using WebApplication1;

WebApplicationBuilder builder = WebApplication.CreateBuilder();

WebApplication app = builder.Build();


//app.UseMiddleware<TokenMiddleware>();

app.UseToken();

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello metanit .com");
});



app.Run();
