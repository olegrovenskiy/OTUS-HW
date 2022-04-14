using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TspuWebPortal.Model;
using TspuWebPortal.Shared;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Microsoft.EntityFrameworkCore.SqlServer;
using TspuWebPortal.ORM;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<SiteDataService>();
builder.Services.AddScoped<DcSiteService>();
builder.Services.AddScoped<DcRoomService>();
builder.Services.AddScoped<DcRowService>();
builder.Services.AddScoped<DcRackService>();
builder.Services.AddScoped<DcEntityService>();
builder.Services.AddScoped<DcFileService>();
builder.Services.AddScoped<DcInitialDetailTableService>();
builder.Services.AddScoped<DcInitialDetailRecordService>();
builder.Services.AddScoped<DcOperationService>();
builder.Services.AddScoped<DcChassisService>();

builder.Services.AddDbContextFactory<TspuDbContext>(options => options.UseNpgsql("Server=192.168.105.250;Port=5432;Database=TspuSitesDb;Username=viktor;Password=postgres"));
//builder.Services.AddDbContextFactory<DcDbContext>(options => options.UseNpgsql("Server=192.168.105.13;Port=5432;Database=asbi_inventory;Username=asbi_inventory;Password=57UhzNfhDsvGsk"));

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
