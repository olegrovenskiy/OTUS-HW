using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class CableData
    {
        [Key]
        public int CableId { get; set; }
        public string SnType { get; set; } = string.Empty;
        public int DeliveryYear { get; set; }
        public string Comments { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int InitialDetailRecordId { get; set; }
        public int DetailChangeId { get; set; }
        public string InventoryNumber { get; set; } = string.Empty;
        public bool IsInstalled { get; set; }
        public int EntityModelId { get; set; }
        public EntityModelData? EntityModel { get; set; }
        public ChangeApplicationData? DetailChange { get; set; }
        public InitialDetailRecordData? InitialDetailRecord { get; set; }
    }
}
