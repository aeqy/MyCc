using MyCc.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// 加载配置文件
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
// 配置数据库服务
builder.Services.ConfigureServicesDatabase(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
// 使用默认文件中间件
app.UseDefaultFiles();

// 使用静态文件中间件
app.UseStaticFiles();

app.UseHttpsRedirection();


app.Run();
