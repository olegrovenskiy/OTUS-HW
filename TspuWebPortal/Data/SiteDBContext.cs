namespace TspuWebPortal.Data;
using Microsoft.EntityFrameworkCore;

    public class SiteDBContext : DbContext
    {
   

    public SiteDBContext (DbContextOptions<SiteDBContext> options) : base (options)
    {
    }
    public DbSet<SiteData> Sites { get; set; } = null!;

    //private const string ConnectionString = "Host=192.168.105.250;Port=5432;Database=TspuSitesDb;Username=vstudio;Password=76Lj,<fpHf,Yjh";
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //optionsBuilder.UseNpgsql(ConnectionString);
    //}

}
