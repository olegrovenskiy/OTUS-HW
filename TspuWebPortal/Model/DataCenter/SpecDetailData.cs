using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class SpecDetailData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SpecDetailId { get; set; }
        public string SpecItemFullName { get; set; } = string.Empty;
        public string SpecItemShortName { get; set; } = string.Empty;
        public string SpecItemType { get; set; } = string.Empty;
        public int DeliveryYear { get; set; }

        public List<InitialDetailRecordData>? InitialDetailRecords { get; set; }

        public int EntityModelId { get; set; }
        [ForeignKey("EntityModelId")]
        public EntityModelData? EntityModel { get; set; }


    }
}
