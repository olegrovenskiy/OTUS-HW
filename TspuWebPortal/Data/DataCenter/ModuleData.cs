using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Data
{
    public class ModuleData
    {
        [Key]
        public int ModuleId { get; set; }
        public string SnType { get; set; } = string.Empty;
        public int DeliveryYear { get; set; }
        public string Comments { get; set; } = string.Empty;
        public string ModuleStatus { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public string CardSlotInChassisOrCard { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int InitialDetailRecordId { get; set; }
        public int DetailChangeId { get; set; }
        public string InventoryNumber { get; set; } = string.Empty;
        public bool IsInstalled { get; set; }
        public int ServeroMesto { get; set; }
        public int EntityModelId { get; set; }
        public EntityModelData? EntityModel { get; set; }
        public int ChassisId { get; set; }
        public ChassisData? Chassis { get; set; }
        public int CardId { get; set; }
        public CardData? Card { get; set; }
        public ChangeApplicationData? DetailChange { get; set; }
        public InitialDetailRecordData? InitialDetailRecord { get; set; }

        public ModuleAData? ModuleA { get; set; }
        public ModuleBData? ModuleB { get; set; }

    }
}
