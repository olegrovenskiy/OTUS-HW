
namespace TspuWebPortal.Data;
using Microsoft.EntityFrameworkCore;
/* */
public class TspuDbContext : DbContext
    {
        public TspuDbContext(DbContextOptions<TspuDbContext> options) : base(options) {}
        public DbSet<SiteData>? Sites { get; set; }
        public DbSet<DcData>? DataCenters { get; set; }
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
        public DbSet<LinkData>? Links { get; set; }
        public DbSet<UserListData>? UserAccounts { get; set; }
        public DbSet<RequestCreationData>? CreationRequests { get; set; }
        public DbSet<RequestCompletionData>? CompletionRequests { get; set; }
        public DbSet<ModuleAData>? ModulesA { get; set; }
        public DbSet<ModuleBData>? ModulesB { get; set; }
}
