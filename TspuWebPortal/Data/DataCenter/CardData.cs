using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Data
{
    public class CardData
    {
        [Key]
        public int CardId { get; set; }
        public string SnType { get; set; } = string.Empty;
        public int DeliveryYear { get; set; }
        public string Comments { get; set; } = string.Empty;
        public string CardStatus { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public string CardSlotInChassis { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int InitialDetailRecordId { get; set; }
        public int DetailChangeId { get; set; }
        public string InventoryNumber { get; set; } = string.Empty;
        public bool IsInstalled { get; set; }
        public int EntityModelId { get; set; }
        public EntityModelData? EntityModel { get; set; }
        public int ChassisId { get; set; }
        public ChassisData? Chassis { get; set; }
        public List<ModuleData>? Modules { get; set; }
        public ChangeApplicationData? DetailChange { get; set; }
        public InitialDetailRecordData? InitialDetailRecord { get; set; }

    }
}
