using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class CardData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CardId { get; set; }

        public string? SnType { get; set; }
        public int? DeliveryYear { get; set; }
        public string? Comments { get; set; }
        public string? CardStatus { get; set; }
        public string? SerialNumber { get; set; }
        public string? CardSlotInChassis { get; set; }
        public string? CurrentLocation { get; set; }
        public int? InitialDetailRecordId { get; set; }
        public int? DetailChangeId { get; set; }
        public string? InventoryNumber { get; set; }
        public bool? IsInstalled { get; set; }
        public int? EntityModelId { get; set; }
        public int? ChassisId { get; set; }

        public string? PositionInUpperEntity { get; set; }


        [ForeignKey("EntityModelId")]
        public EntityModelData? EntityModel { get; set; }


        [ForeignKey("ChassisId")]
        public ChassisData? Chassis { get; set; }

        [ForeignKey("DetailChangeId")]
        public ChangeApplicationData? DetailChange { get; set; }

        [ForeignKey("InitialDetailRecordId")]
        public InitialDetailRecordData? InitialDetailRecord { get; set; }

        public List<ModuleData>? Modules { get; set; }
    }
}
