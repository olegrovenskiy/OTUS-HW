using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class ChassisData
    {
        [Key]
        public int ChassisId { get; set; }
        public string SnType { get; set; } = string.Empty;
        public string ChassisStatus { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public int EntityModelId { get; set; }
        public string Hostname { get; set; } = string.Empty;
        public string CurrentLocation { get; set; } = string.Empty;
        public bool IsInstalled { get; set; }
        public int InitialDetailRecordId { get; set; }
        public int DetailChangeId { get; set; }
        public string InventoryNumber { get; set; } = string.Empty;
        public int DeliveryYear { get; set; }
        public string Comments { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public EntityModelData? EntityModel { get; set; }
        public List<UnitData>? Units { get; set; }
        public List<CardData>? Cards { get; set; }
        public List<ModuleData>? Modules { get; set; }
        public ChangeApplicationData? DetailChange { get; set; }
        public InitialDetailRecordData? InitialDetailRecord { get; set; }
    }
}
