using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class InitialMaterialRecordData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InitialMaterialId { get; set; }

        public int? MaterialStorageItemId { get; set; }
        [ForeignKey("MaterialStorageItemId")]
        public MaterialStorageData? MaterialStorageRecords { get; set; }

        public string? DocumentNumber { get; set; }
        public string? MaterialOfficialName { get; set; }
        public int? Quantity { get; set; }
        public string? Location { get; set; }
        public DateOnly? DeliveryDate { get; set; }
        public int? OperationId { get; set; }
        public OperationData? Operation { get; set; }

    }
}
