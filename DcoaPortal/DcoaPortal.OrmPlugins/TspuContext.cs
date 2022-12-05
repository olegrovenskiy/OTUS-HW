using DcoaPortal.TspuModels;
using Microsoft.EntityFrameworkCore;

namespace DcoaPortal.OrmPlugins;

public class TspuContext : DbContext
{
    public TspuContext (DbContextOptions options) : base(options)   { }
    public DbSet<TspuSites>? SiteList { get; set; }
}
