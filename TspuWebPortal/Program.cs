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
//builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<SiteDataService>();
builder.Services.AddDbContextFactory<TspuDbContext>(options => options.UseNpgsql("Server=192.168.105.250;Port=5432;Database=TspuSitesDb;Username=viktor;Password=postgres"));
//builder.Services.AddDbContextFactory<TspuDbContext>(options => options.UseNpgsql("Server=192.168.105.250;Port=5432;Database=TspuSitesDb;Username=viktor;Password=postgres"));

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
