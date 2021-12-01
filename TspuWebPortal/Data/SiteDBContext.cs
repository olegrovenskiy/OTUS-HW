namespace TspuWebPortal.Data;
using Microsoft.EntityFrameworkCore;

    public class SiteDBContext : DbContext
    {
        public SiteDBContext(DbContextOptions<SiteDBContext> options)
        : base(options)
        {
            

        }
    public DbSet<SiteData> Sites { get; set; } = null!;

    }
