using Microsoft.EntityFrameworkCore;

using SalesWebMvc.Infra.Data.Context;
using SalesWebMvc.Ioc;

using System.Text;

var builder = WebApplication.CreateBuilder(args);

void ConfigureServices(IServiceCollection services)
{
    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
    services.AddDbContext<SalesWebMvcContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("Sales")), ServiceLifetime.Scoped);
    InjectionDependencyCore.ConfigureServices(services);
}

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
