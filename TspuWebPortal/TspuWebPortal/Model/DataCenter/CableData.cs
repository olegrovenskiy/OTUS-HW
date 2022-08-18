using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class CableData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CableId { get; set; }
        //public string? SnType { get; set; }
        //public int? DeliveryYear { get; set; }
        public string Comments { get; set; } = string.Empty;
        //public string? SerialNumber { get; set; }
        //public string? CurrentLocation { get; set; }
        //public string? InventoryNumber { get; set; }
        public bool IsInstalled { get; set; } = true;

        //public int? EntityModelId { get; set; }
        //[ForeignKey("EntityModelId")]
        //public EntityModelData? EntityModel { get; set; }

        //public int? DetailChangeId { get; set; }                      //В обратном направлении связь.
        //[ForeignKey("DetailChangeId")]
        //public ChangeApplicationData? DetailChange { get; set; }

        public int InitialDetailRecordId { get; set; }
        [ForeignKey("InitialDetailRecordId")]
        public DetailRecordData? InitialDetailRecord { get; set; }
    }
}
