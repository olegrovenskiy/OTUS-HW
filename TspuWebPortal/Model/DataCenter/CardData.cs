using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class CardData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CardId { get; set; }

        //public string? SnType { get; set; }
        //public int? DeliveryYear { get; set; }
        public string Comments { get; set; } = string.Empty;
        //public string? CardStatus { get; set; }
        //public string? SerialNumber { get; set; }
        //public string? CardSlotInChassis { get; set; }
        //public string? CurrentLocation { get; set; }


        //public string? InventoryNumber { get; set; }
        public bool IsInstalled { get; set; } = true;



        public string PositionInUpperEntity { get; set; } = string.Empty;

        //public int? EntityModelId { get; set; }
        //[ForeignKey("EntityModelId")]
        //public EntityModelData? EntityModel { get; set; }

        public int ChassisId { get; set; }
        [ForeignKey("ChassisId")]
        public ChassisData? Chassis { get; set; }

        //public int? DetailChangeId { get; set; }
        //[ForeignKey("DetailChangeId")]
        //public ChangeApplicationData? DetailChange { get; set; }                  //Связку в обратном направлении

        public int InitialDetailRecordId { get; set; }
        [ForeignKey("InitialDetailRecordId")]
        public DetailRecordData? InitialDetailRecord { get; set; }

        public List<ModuleData>? Modules { get; set; }
    }
}
