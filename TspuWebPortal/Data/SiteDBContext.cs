namespace TspuWebPortal.Data;
using Microsoft.EntityFrameworkCore;

    public class SiteDBContext : DbContext
    {


#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public SiteDBContext(DbContextOptions<SiteDBContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
    }
    public DbSet<SiteData> Sites { get; set; }

    //private const string ConnectionString = "Host=192.168.105.250;Port=5432;Database=TspuSitesDb;Username=vstudio;Password=76Lj,<fpHf,Yjh";
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //optionsBuilder.UseNpgsql(ConnectionString);
    //}

    }
