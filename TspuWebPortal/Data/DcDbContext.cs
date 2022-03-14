namespace TspuWebPortal.Data;
using Microsoft.EntityFrameworkCore;

    public class DcDbContext : DbContext
{
    public DcDbContext(DbContextOptions<TspuDbContext> options) : base(options) { }

    public DbSet<DataCenterData>? DataCenters { get; set; }
    public DbSet<RoomData>? Rooms { get; set; }
    public DbSet<RowData>? Rows { get; set; }
    public DbSet<RackData>? Racks { get; set; }
    public DbSet<UnitData>? Units { get; set; }
    public DbSet<EntityModelData>? EntityModel { get; set; }
    public DbSet<ChassisData>? Chassis { get; set; }
    public DbSet<CardData>? Cards { get; set; }
    public DbSet<ModuleData>? Modules { get; set; }
    public DbSet<CableData>? Cables { get; set; }
    public DbSet<LicenseData>? Licenses { get; set; }
    public DbSet<ServerSlotData>? ServerSlots { get; set; }
    public DbSet<ServerLinkData>? ServerLinks { get; set; }
    public DbSet<ChangeApplicationData>? DetailChange { get; set; }
    public DbSet<InitialDetailRecordData>? DetailRecord { get; set; }
    public DbSet<InitialDetailTableData>? DetailTable { get; set; }
    public DbSet<InitialMaterialRecordData>? MaterialRecord { get; set; }
    public DbSet<InitialMaterialTableData>? MaterialTable { get; set; }
    public DbSet<InitialMaterialTableData>? Accounts { get; set; }
}

