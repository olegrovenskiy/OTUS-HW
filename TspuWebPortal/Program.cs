using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TspuWebPortal.Data;
using TspuWebPortal.Shared;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Microsoft.EntityFrameworkCore.SqlServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<SiteDataService>();
//builder.Services.AddDbContext<SiteDBContext>(options => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true"));
//builder.Services.AddDbContextFactory<SiteDBContext>(options => options.UseSqlite("Data Source={nameof(SiteDBContext)}.db"));
//builder.Services.AddDbContext<SiteDBContext>(options => options.UseSqlite("Data Source=TSPU_Sites.db"));
//builder.Services.AddDbContextFactory<SiteDBContext>(options => options.UseSqlite("Data Source=TSPU_Sites.db"));
//builder.Services.AddDbContextFactory<SiteDBContext>(options => options.UseNpgsql("Host=192.168.105.250;Port=5432;Database=TspuSitesDb;Username=vstudio;Password=76Lj,<fpHf,Yjh"));
builder.Services.AddDbContextFactory<SiteDBContext>(options => options.UseNpgsql("Server=192.168.105.250;Port=5432;Database=TspuSitesDb;Username=viktor;Password=postgres"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
